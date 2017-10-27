namespace HTC_FRP_RESET
{
    partial class fmGUI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.mNotificationBox1 = new MonoFlat.MonoFlat_NotificationBox();
            this.mHLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            this.mPanel2 = new MonoFlat.MonoFlat_Panel();
            this.mButton_Flash = new MonoFlat.MonoFlat_Button();
            this.mButton_Token2 = new MonoFlat.MonoFlat_Button();
            this.mButton_Token1 = new MonoFlat.MonoFlat_Button();
            this.mButton_HTCDev = new MonoFlat.MonoFlat_Button();
            this.mTextBox = new MonoFlat.MonoFlat_TextBox();
            this.mHLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            this.mPanel1 = new MonoFlat.MonoFlat_Panel();
            this.mButton_R_OS = new MonoFlat.MonoFlat_Button();
            this.mButton_R_Download = new MonoFlat.MonoFlat_Button();
            this.mButton_R_Bootloader = new MonoFlat.MonoFlat_Button();
            this.mHLabel_HTCFZ = new MonoFlat.MonoFlat_HeaderLabel();
            this.mControlBox = new MonoFlat.MonoFlat_ControlBox();
            this.mThemeContainer1.SuspendLayout();
            this.mPanel2.SuspendLayout();
            this.mPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Unlock_code";
            this.openFileDialog1.Filter = "Unlock_code|*.bin|All|*.*";
            // 
            // mThemeContainer1
            // 
            this.mThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.mThemeContainer1.Controls.Add(this.mNotificationBox1);
            this.mThemeContainer1.Controls.Add(this.mHLabel2);
            this.mThemeContainer1.Controls.Add(this.mPanel2);
            this.mThemeContainer1.Controls.Add(this.mTextBox);
            this.mThemeContainer1.Controls.Add(this.mHLabel1);
            this.mThemeContainer1.Controls.Add(this.mPanel1);
            this.mThemeContainer1.Controls.Add(this.mHLabel_HTCFZ);
            this.mThemeContainer1.Controls.Add(this.mControlBox);
            this.mThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.mThemeContainer1.Name = "mThemeContainer1";
            this.mThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.mThemeContainer1.RoundCorners = true;
            this.mThemeContainer1.Sizable = false;
            this.mThemeContainer1.Size = new System.Drawing.Size(650, 560);
            this.mThemeContainer1.SmartBounds = true;
            this.mThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mThemeContainer1.TabIndex = 0;
            this.mThemeContainer1.TabStop = false;
            this.mThemeContainer1.Text = "HTC FRP Reset";
            // 
            // mNotificationBox1
            // 
            this.mNotificationBox1.BorderCurve = 15;
            this.mNotificationBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mNotificationBox1.Image = null;
            this.mNotificationBox1.Location = new System.Drawing.Point(208, 107);
            this.mNotificationBox1.MinimumSize = new System.Drawing.Size(100, 40);
            this.mNotificationBox1.Name = "mNotificationBox1";
            this.mNotificationBox1.NotificationType = MonoFlat.MonoFlat_NotificationBox.Type.Warning;
            this.mNotificationBox1.RoundCorners = false;
            this.mNotificationBox1.ShowCloseButton = true;
            this.mNotificationBox1.Size = new System.Drawing.Size(400, 200);
            this.mNotificationBox1.TabIndex = 7;
            // 
            // mHLabel2
            // 
            this.mHLabel2.AutoSize = true;
            this.mHLabel2.BackColor = System.Drawing.Color.Transparent;
            this.mHLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mHLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mHLabel2.Location = new System.Drawing.Point(12, 290);
            this.mHLabel2.Name = "mHLabel2";
            this.mHLabel2.Size = new System.Drawing.Size(60, 19);
            this.mHLabel2.TabIndex = 6;
            this.mHLabel2.Text = "Option";
            // 
            // mPanel2
            // 
            this.mPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.mPanel2.Controls.Add(this.mButton_Flash);
            this.mPanel2.Controls.Add(this.mButton_Token2);
            this.mPanel2.Controls.Add(this.mButton_Token1);
            this.mPanel2.Controls.Add(this.mButton_HTCDev);
            this.mPanel2.Location = new System.Drawing.Point(16, 314);
            this.mPanel2.Name = "mPanel2";
            this.mPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.mPanel2.Size = new System.Drawing.Size(200, 234);
            this.mPanel2.TabIndex = 5;
            // 
            // mButton_Flash
            // 
            this.mButton_Flash.BackColor = System.Drawing.Color.Transparent;
            this.mButton_Flash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mButton_Flash.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mButton_Flash.Image = null;
            this.mButton_Flash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mButton_Flash.Location = new System.Drawing.Point(26, 179);
            this.mButton_Flash.Name = "mButton_Flash";
            this.mButton_Flash.Size = new System.Drawing.Size(146, 41);
            this.mButton_Flash.TabIndex = 3;
            this.mButton_Flash.Text = "Flash";
            this.mButton_Flash.TextAlignment = System.Drawing.StringAlignment.Center;
            this.mButton_Flash.Click += new System.EventHandler(this.mButton_Flash_Click);
            // 
            // mButton_Token2
            // 
            this.mButton_Token2.BackColor = System.Drawing.Color.Transparent;
            this.mButton_Token2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mButton_Token2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mButton_Token2.Image = null;
            this.mButton_Token2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mButton_Token2.Location = new System.Drawing.Point(26, 124);
            this.mButton_Token2.Name = "mButton_Token2";
            this.mButton_Token2.Size = new System.Drawing.Size(146, 41);
            this.mButton_Token2.TabIndex = 2;
            this.mButton_Token2.Tag = "old";
            this.mButton_Token2.Text = "Token (old)";
            this.mButton_Token2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.mButton_Token2.Click += new System.EventHandler(this.mButton_Token_Click);
            // 
            // mButton_Token1
            // 
            this.mButton_Token1.BackColor = System.Drawing.Color.Transparent;
            this.mButton_Token1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mButton_Token1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mButton_Token1.Image = null;
            this.mButton_Token1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mButton_Token1.Location = new System.Drawing.Point(26, 69);
            this.mButton_Token1.Name = "mButton_Token1";
            this.mButton_Token1.Size = new System.Drawing.Size(146, 41);
            this.mButton_Token1.TabIndex = 1;
            this.mButton_Token1.Tag = "new";
            this.mButton_Token1.Text = "Token (new)";
            this.mButton_Token1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.mButton_Token1.Click += new System.EventHandler(this.mButton_Token_Click);
            // 
            // mButton_HTCDev
            // 
            this.mButton_HTCDev.BackColor = System.Drawing.Color.Transparent;
            this.mButton_HTCDev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mButton_HTCDev.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mButton_HTCDev.Image = null;
            this.mButton_HTCDev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mButton_HTCDev.Location = new System.Drawing.Point(26, 14);
            this.mButton_HTCDev.Name = "mButton_HTCDev";
            this.mButton_HTCDev.Size = new System.Drawing.Size(146, 41);
            this.mButton_HTCDev.TabIndex = 0;
            this.mButton_HTCDev.Text = "HTC Dev";
            this.mButton_HTCDev.TextAlignment = System.Drawing.StringAlignment.Center;
            this.mButton_HTCDev.Click += new System.EventHandler(this.mButton_HTCDev_Click);
            // 
            // mTextBox
            // 
            this.mTextBox.BackColor = System.Drawing.Color.Transparent;
            this.mTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.mTextBox.Image = null;
            this.mTextBox.Location = new System.Drawing.Point(237, 73);
            this.mTextBox.MaxLength = 32767;
            this.mTextBox.Multiline = true;
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.ReadOnly = false;
            this.mTextBox.Size = new System.Drawing.Size(400, 475);
            this.mTextBox.TabIndex = 4;
            this.mTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.mTextBox.UseSystemPasswordChar = false;
            // 
            // mHLabel1
            // 
            this.mHLabel1.AutoSize = true;
            this.mHLabel1.BackColor = System.Drawing.Color.Transparent;
            this.mHLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mHLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mHLabel1.Location = new System.Drawing.Point(12, 70);
            this.mHLabel1.Name = "mHLabel1";
            this.mHLabel1.Size = new System.Drawing.Size(64, 19);
            this.mHLabel1.TabIndex = 3;
            this.mHLabel1.Text = "Reboot";
            // 
            // mPanel1
            // 
            this.mPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.mPanel1.Controls.Add(this.mButton_R_OS);
            this.mPanel1.Controls.Add(this.mButton_R_Download);
            this.mPanel1.Controls.Add(this.mButton_R_Bootloader);
            this.mPanel1.Location = new System.Drawing.Point(16, 93);
            this.mPanel1.Name = "mPanel1";
            this.mPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.mPanel1.Size = new System.Drawing.Size(200, 180);
            this.mPanel1.TabIndex = 2;
            // 
            // mButton_R_OS
            // 
            this.mButton_R_OS.BackColor = System.Drawing.Color.Transparent;
            this.mButton_R_OS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mButton_R_OS.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mButton_R_OS.Image = null;
            this.mButton_R_OS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mButton_R_OS.Location = new System.Drawing.Point(26, 124);
            this.mButton_R_OS.Name = "mButton_R_OS";
            this.mButton_R_OS.Size = new System.Drawing.Size(146, 41);
            this.mButton_R_OS.TabIndex = 2;
            this.mButton_R_OS.Tag = "os";
            this.mButton_R_OS.Text = "Reboot OS";
            this.mButton_R_OS.TextAlignment = System.Drawing.StringAlignment.Center;
            this.mButton_R_OS.Click += new System.EventHandler(this.mButton_Reboot_Click);
            // 
            // mButton_R_Download
            // 
            this.mButton_R_Download.BackColor = System.Drawing.Color.Transparent;
            this.mButton_R_Download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mButton_R_Download.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mButton_R_Download.Image = null;
            this.mButton_R_Download.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mButton_R_Download.Location = new System.Drawing.Point(26, 69);
            this.mButton_R_Download.Name = "mButton_R_Download";
            this.mButton_R_Download.Size = new System.Drawing.Size(146, 41);
            this.mButton_R_Download.TabIndex = 1;
            this.mButton_R_Download.Tag = "download";
            this.mButton_R_Download.Text = "Download";
            this.mButton_R_Download.TextAlignment = System.Drawing.StringAlignment.Center;
            this.mButton_R_Download.Click += new System.EventHandler(this.mButton_Reboot_Click);
            // 
            // mButton_R_Bootloader
            // 
            this.mButton_R_Bootloader.BackColor = System.Drawing.Color.Transparent;
            this.mButton_R_Bootloader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mButton_R_Bootloader.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mButton_R_Bootloader.Image = null;
            this.mButton_R_Bootloader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mButton_R_Bootloader.Location = new System.Drawing.Point(26, 14);
            this.mButton_R_Bootloader.Name = "mButton_R_Bootloader";
            this.mButton_R_Bootloader.Size = new System.Drawing.Size(146, 41);
            this.mButton_R_Bootloader.TabIndex = 0;
            this.mButton_R_Bootloader.Tag = "bootloader";
            this.mButton_R_Bootloader.Text = "Bootloader";
            this.mButton_R_Bootloader.TextAlignment = System.Drawing.StringAlignment.Center;
            this.mButton_R_Bootloader.Click += new System.EventHandler(this.mButton_Reboot_Click);
            // 
            // mHLabel_HTCFZ
            // 
            this.mHLabel_HTCFZ.AutoSize = true;
            this.mHLabel_HTCFZ.BackColor = System.Drawing.Color.Transparent;
            this.mHLabel_HTCFZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mHLabel_HTCFZ.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.mHLabel_HTCFZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mHLabel_HTCFZ.Location = new System.Drawing.Point(388, 20);
            this.mHLabel_HTCFZ.Name = "mHLabel_HTCFZ";
            this.mHLabel_HTCFZ.Size = new System.Drawing.Size(144, 20);
            this.mHLabel_HTCFZ.TabIndex = 1;
            this.mHLabel_HTCFZ.Text = "Copyright © HTCFZ";
            this.mHLabel_HTCFZ.Click += new System.EventHandler(this.mHLabel_HTCFZ_Click);
            // 
            // mControlBox
            // 
            this.mControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mControlBox.EnableHoverHighlight = true;
            this.mControlBox.EnableMaximizeButton = false;
            this.mControlBox.EnableMinimizeButton = true;
            this.mControlBox.Location = new System.Drawing.Point(538, 15);
            this.mControlBox.Name = "mControlBox";
            this.mControlBox.Size = new System.Drawing.Size(100, 25);
            this.mControlBox.TabIndex = 0;
            // 
            // fmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 560);
            this.Controls.Add(this.mThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTC FRP Reset";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmGUI_FormClosing);
            this.Load += new System.EventHandler(this.fmGUI_Load);
            this.mThemeContainer1.ResumeLayout(false);
            this.mThemeContainer1.PerformLayout();
            this.mPanel2.ResumeLayout(false);
            this.mPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer mThemeContainer1;
        private MonoFlat.MonoFlat_ControlBox mControlBox;
        private MonoFlat.MonoFlat_HeaderLabel mHLabel_HTCFZ;
        private MonoFlat.MonoFlat_HeaderLabel mHLabel1;
        private MonoFlat.MonoFlat_Panel mPanel1;
        private MonoFlat.MonoFlat_Button mButton_R_OS;
        private MonoFlat.MonoFlat_Button mButton_R_Download;
        private MonoFlat.MonoFlat_Button mButton_R_Bootloader;
        private MonoFlat.MonoFlat_TextBox mTextBox;
        private MonoFlat.MonoFlat_HeaderLabel mHLabel2;
        private MonoFlat.MonoFlat_Panel mPanel2;
        private MonoFlat.MonoFlat_Button mButton_Flash;
        private MonoFlat.MonoFlat_Button mButton_Token2;
        private MonoFlat.MonoFlat_Button mButton_Token1;
        private MonoFlat.MonoFlat_Button mButton_HTCDev;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MonoFlat.MonoFlat_NotificationBox mNotificationBox1;
    }
}

