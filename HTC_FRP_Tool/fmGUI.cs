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

namespace HTC_FRP_Tool
{
    public partial class fmGUI : Form
    {
        public fmGUI()
        {
            InitializeComponent();
            Tool.textBox = TextBox.instance;
            Icon = Properties.Resources.icon;
        }

        private async void Button_GetToken_Click(object sender, EventArgs e)
        {
            Button_GetToken.Enabled = false;
            TextBox.Text = null;
            var token = await Task.Run(() => Tool.GetToken());
            if (token != null)
            {
                Clipboard.Clear();
                Clipboard.SetText(token);
                TextBox.Text += "\r\n\r\nToken has saved to clipboard!";
            }
            Button_GetToken.Enabled = true;
        }

        private async void Button_Flash_Click(object sender, EventArgs e)
        {
            Button_Flash.Enabled = false;
            var fdg = new OpenFileDialog();
            fdg.InitialDirectory = Environment.CurrentDirectory;
            fdg.Filter = "Unlock_code|*.bin|All Files|*.*";
            if (fdg.ShowDialog() == DialogResult.OK)
            {
                TextBox.Text = null;
                await Task.Run(() => Tool.FlashUnlockCode(fdg.FileName));
            }
            Button_Flash.Enabled = true;
        }

        private void Button_HTCDev_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.htcdev.com/bootloader/");
        }

        private void Header_HTCFZ_Click(object sender, EventArgs e)
        {
            Process.Start("https://htcfz.wordpress.com/");
        }

        private void Donate_Paypal_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.me/sabpprook");
        }

        private void Donate_ECPay_Click(object sender, EventArgs e)
        {
            Process.Start("https://pay.ecpay.com.tw/CreditPayment/ExpressCredit?MerchantID=1425360&Enn=e");
        }

        private void Header_Author_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/profile.php?id=100005653172695");
        }
    }
}
