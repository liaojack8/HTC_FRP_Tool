using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTC_FRP_Tool
{
    class Tool
    {
        public static TextBox textBox;

        private static void AppendText(string text)
        {
            textBox.Invoke(new Action(() =>
            {
                textBox.Text += text;
            }));
        }

        public static string GetToken()
        {
            var count = 0;
            count = GetDeviceCount();
            if (count != 1)
            {
                AppendText(count > 1 ? "More than one device!" : "No device detected!");
                return null;
            }
            AppendText("Reboot to bootloader...");
            Fastboot("reboot-bootloader");
            Thread.Sleep(1000);
            while (GetDeviceCount() == 0)
            {
                Thread.Sleep(500);
            }
            AppendText(" OK!\r\n");
            Thread.Sleep(1000);
            var flag = CheckDownload();
            if (flag)
            {
                AppendText("Download mode detected!\r\n");
                Thread.Sleep(1000);
                AppendText("Reboot to download...");
                Fastboot("oem reboot-download");
                Thread.Sleep(1000);
                while (GetDeviceCount() == 0)
                {
                    Thread.Sleep(500);
                }
                AppendText(" OK!\r\n");
                Thread.Sleep(1000);
            }
            AppendText("Reading Token...");
            var token = GetKSToken(flag);
            if (token != null)
            {
                AppendText(" Success!");
            }
            else
            {
                AppendText(" Fail!\r\n");
                AppendText("Sorry, this model not supported!");
            }
            Thread.Sleep(1000);
            return token;
        }

        private static int GetDeviceCount()
        {
            int count = 0;
            var log = Fastboot("devices").stdout;
            while (!log.EndOfStream)
            {
                var line = log.ReadLine();
                if (line.Contains("\tfastboot"))
                {
                    count++;
                }
            }
            return count;
        }

        private static bool CheckDownload()
        {
            var log = Fastboot("oem readcid").stderr;
            return log.ReadToEnd().Contains("unknown");
        }

        private static string GetKSToken(bool download)
        {
            var log = download ? Fastboot("dump kstoken @ks 0 0").stderr : Fastboot("oem get_ks_token").stderr;
            if (File.Exists("@ks")) File.Delete("@ks");
            var token = "";
            while (!log.EndOfStream)
            {
                var line = log.ReadLine();
                if (line.Contains("Identifier Token Start"))
                {
                    token += line + "\r\n";
                    while (!(line = log.ReadLine()).Contains("Identifier Token End"))
                    {
                        token += line + "\r\n";
                    }
                    token += line;
                    return token.Replace("(bootloader) ", "").Replace("INFO", "");
                }
            }
            return null;
        }

        public static void FlashUnlockCode(string file)
        {
            var count = 0;
            count = GetDeviceCount();
            if (count != 1)
            {
                AppendText(count > 1 ? "More than one device!" : "No device detected!");
                return;
            }
            AppendText("Flashing Unlock_code.bin...");
            var log = Fastboot($"flash kstoken \"{file}\"").stderr.ReadToEnd();
            AppendText(" OK!");
            Thread.Sleep(1000);
            AppendText($"\r\n\r\nLOG:\r\n{log}");
            if (log.Contains("success"))
            {
                Fastboot("reboot");
            }
        }

        private static FastbootLog Fastboot(string command)
        {
            using (var p = new Process())
            {
                var log = new FastbootLog();
                string stderr = "", stdout = "";
                p.StartInfo.FileName = Environment.CurrentDirectory + "\\fastboot.exe";
                p.StartInfo.Arguments = command;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.StandardErrorEncoding = Encoding.UTF8;
                p.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                p.Start();
                stderr = p.StandardError.ReadToEnd();
                stdout = p.StandardOutput.ReadToEnd();
                p.WaitForExit(15000);
                log.stderr = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(stderr)));
                log.stdout = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(stdout)));
                return log;
            }
        }
    }

    class FastbootLog
    {
        public StreamReader stderr { get; set; }
        public StreamReader stdout { get; set; }
    }
}
