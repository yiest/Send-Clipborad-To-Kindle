namespace SendClipboardToKindle
{
    partial class OptionsForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.donateHiddenCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sendToText = new System.Windows.Forms.TextBox();
            this.emailTab = new System.Windows.Forms.TabPage();
            this.sslCheck = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.portText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailFromText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.smtpServerText = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.emailTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.generalTab);
            this.tabControl.Controls.Add(this.emailTab);
            this.tabControl.Location = new System.Drawing.Point(2, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(315, 234);
            this.tabControl.TabIndex = 0;
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.label5);
            this.generalTab.Controls.Add(this.donateHiddenCheck);
            this.generalTab.Controls.Add(this.label2);
            this.generalTab.Controls.Add(this.sendToText);
            this.generalTab.Location = new System.Drawing.Point(4, 21);
            this.generalTab.Name = "generalTab";
            this.generalTab.Size = new System.Drawing.Size(307, 209);
            this.generalTab.TabIndex = 2;
            this.generalTab.Text = "General";
            this.generalTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Your kindle email adrress";
            // 
            // donateHiddenCheck
            // 
            this.donateHiddenCheck.AutoSize = true;
            this.donateHiddenCheck.Location = new System.Drawing.Point(20, 134);
            this.donateHiddenCheck.Name = "donateHiddenCheck";
            this.donateHiddenCheck.Size = new System.Drawing.Size(174, 16);
            this.donateHiddenCheck.TabIndex = 4;
            this.donateHiddenCheck.Text = "Hide the donate menu item";
            this.donateHiddenCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Send To:";
            // 
            // sendToText
            // 
            this.sendToText.Location = new System.Drawing.Point(20, 50);
            this.sendToText.Name = "sendToText";
            this.sendToText.Size = new System.Drawing.Size(256, 21);
            this.sendToText.TabIndex = 2;
            // 
            // emailTab
            // 
            this.emailTab.Controls.Add(this.sslCheck);
            this.emailTab.Controls.Add(this.label7);
            this.emailTab.Controls.Add(this.portText);
            this.emailTab.Controls.Add(this.label6);
            this.emailTab.Controls.Add(this.textBox1);
            this.emailTab.Controls.Add(this.label4);
            this.emailTab.Controls.Add(this.passwordText);
            this.emailTab.Controls.Add(this.label3);
            this.emailTab.Controls.Add(this.emailFromText);
            this.emailTab.Controls.Add(this.label1);
            this.emailTab.Controls.Add(this.smtpServerText);
            this.emailTab.Location = new System.Drawing.Point(4, 21);
            this.emailTab.Name = "emailTab";
            this.emailTab.Padding = new System.Windows.Forms.Padding(3);
            this.emailTab.Size = new System.Drawing.Size(307, 209);
            this.emailTab.TabIndex = 1;
            this.emailTab.Text = "Email";
            this.emailTab.UseVisualStyleBackColor = true;
            // 
            // sslCheck
            // 
            this.sslCheck.AutoSize = true;
            this.sslCheck.Location = new System.Drawing.Point(186, 96);
            this.sslCheck.Name = "sslCheck";
            this.sslCheck.Size = new System.Drawing.Size(66, 16);
            this.sslCheck.TabIndex = 16;
            this.sslCheck.Text = "SSL/TLS";
            this.sslCheck.UseVisualStyleBackColor = true;
            this.sslCheck.Click += new System.EventHandler(this.sslCheck_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "Port:";
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(100, 94);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(66, 21);
            this.portText.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(22, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ensure the sender email address has been added to the approved email list of your" +
                " kindle.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 272);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(99, 163);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(188, 21);
            this.passwordText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // emailFromText
            // 
            this.emailFromText.Location = new System.Drawing.Point(100, 131);
            this.emailFromText.Name = "emailFromText";
            this.emailFromText.Size = new System.Drawing.Size(187, 21);
            this.emailFromText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "SMTP Server:";
            // 
            // smtpServerText
            // 
            this.smtpServerText.Location = new System.Drawing.Point(101, 67);
            this.smtpServerText.Name = "smtpServerText";
            this.smtpServerText.Size = new System.Drawing.Size(187, 21);
            this.smtpServerText.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(145, 251);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(230, 251);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 286);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsForm_FormClosed);
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            this.emailTab.ResumeLayout(false);
            this.emailTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage emailTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox smtpServerText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailFromText;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sendToText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox donateHiddenCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox sslCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox portText;
    }
}