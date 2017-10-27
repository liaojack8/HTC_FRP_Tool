using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTC_FRP_RESET
{
    public partial class fmGUI : Form
    {
        public fmGUI()
        {
            InitializeComponent();
        }

        private void mHLabel_HTCFZ_Click(object sender, EventArgs e)
        {
            Process.Start("https://htcfz.wordpress.com/");
        }

        private void fmGUI_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;
            bool flag1 = File.Exists("AdbWinApi.dll"), flag2 = File.Exists("fastboot.exe");
            if (!flag1) AppendText("Can not found \"AdbWinApi.dll\"\r\n");
            if (!flag2) AppendText("Can not found \"fastboot.exe\"\r\n");
            if (!flag1 || !flag2)
            {
                AppendText("Disable all functions\r\n");
                mButton_R_Bootloader.Enabled = false;
                mButton_R_Download.Enabled = false;
                mButton_R_OS.Enabled = false;
                mButton_Token1.Enabled = false;
                mButton_Token2.Enabled = false;
                mButton_Flash.Enabled = false;
            }
            mNotificationBox1.Text = "\r\n\r\n1. Reboot device to bootloader or download.\r\n\r\n"
                + "2. Try \"Token (new)\" or \"Token (old)\" to get token.\r\n\r\n"
                + "3. Submit the token to HTCDev (BL Unlock).\r\n\r\n"
                + "4. Flash \"Unlock_code.bin\" download from HTCDev.";
        }

        private async void mButton_Reboot_Click(object sender, EventArgs e)
        {
            MonoFlat.MonoFlat_Button btn = (MonoFlat.MonoFlat_Button)sender;
            btn.Enabled = false;
            string arg = null;
            string tag = btn.Tag.ToString();
            if (tag == "bootloader") arg = "reboot-bootloader";
            if (tag == "download") arg = "oem reboot-download";
            if (tag == "os") arg = "reboot";
            if (arg == null) return;
            await Task.Run(() => Fastboot(arg).Dispose());
            btn.Enabled = true;
        }

        private void mButton_HTCDev_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.htcdev.com/bootloader/unlock-instructions/page-2");
        }

        private async void mButton_Token_Click(object sender, EventArgs e)
        {
            MonoFlat.MonoFlat_Button btn = (MonoFlat.MonoFlat_Button)sender;
            btn.Enabled = false;
            string arg = null;
            string tag = btn.Tag.ToString();
            if (tag == "new") arg = "dump kstoken 0 0 0";
            if (tag == "old") arg = "oem get_ks_token";
            await Task.Run(() =>
            {
                Process p = Fastboot(arg);
                if (File.Exists("0")) File.Delete("0");
                string text = p.StandardError.ReadToEnd();
                if (!string.IsNullOrEmpty(text)) AppendText("\r\n" + text + "\r\n");
                ShowToken(text);
                p.Dispose();
            });
            btn.Enabled = true;
        }

        private async void mButton_Flash_Click(object sender, EventArgs e)
        {
            MonoFlat.MonoFlat_Button btn = (MonoFlat.MonoFlat_Button)sender;
            btn.Enabled = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                await Task.Run(() =>
                {
                    Process p = Fastboot("flash kstoken \"" + file + "\"");
                    string text = p.StandardError.ReadToEnd();
                    if (!string.IsNullOrEmpty(text)) AppendText("\r\n" + text + "\r\n");
                    p.Dispose();
                });
            }
            btn.Enabled = true;
        }

        private void fmGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var p in Process.GetProcessesByName("fastboot")) p.Kill();
        }

        private void AppendText(string text)
        {
            Invoke(new Action(() => mTextBox.Instance.AppendText(text)));
        }

        private Process Fastboot(string arg)
        {
            AppendText("Send: fastboot " + arg + "\r\n");
            Process p = new Process();
            p.StartInfo.FileName = "fastboot.exe";
            p.StartInfo.Arguments = arg;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();
            p.WaitForExit(5000);
            if (!p.HasExited)
            {
                AppendText("Timeout! Kill process\r\n");
                p.Kill();
            }
            return p;
        }

        private void ShowToken(string text)
        {
            if (text.Contains("Token Start"))
            {
                using (StringReader sr = new StringReader(text))
                {
                    string tmp = null, token = null;
                    while (!(tmp = sr.ReadLine()).Contains("Token Start")) ;
                    token = tmp + "\r\n";
                    while (!(tmp = sr.ReadLine()).Contains("Token End")) token += tmp + "\r\n";
                    token += tmp + "\r\n";
                    token = token.Replace("(bootloader) ", "").Replace("INFO", "");
                    Invoke(new Action(() => mTextBox.Text = token));
                }
            }
        }
    }
}
