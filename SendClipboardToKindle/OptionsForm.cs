using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace SendClipboardToKindle
{
    public partial class OptionsForm : Form
    {
        static public bool opened=false;
        MainForm mainForm;

        public void LoadOptions()
        {
            var settings = Properties.Settings.Default;
            donateHiddenCheck.Checked = settings.isDonateHidden;
            sendToText.Text = settings.sendTo;
            smtpServerText.Text = settings.smtpServer;
            portText.Text = settings.port.ToString();
            sslCheck.Checked = settings.isSsl;
            emailFromText.Text = settings.emailFrom;
            passwordText.Text = settings.password;
        }

        public void SaveOptions() 
        {
            var settings = Properties.Settings.Default;
            settings.sendTo = sendToText.Text;
            settings.smtpServer = smtpServerText.Text;
            int port = 0;
            int.TryParse(portText.Text, out port);
            settings.port = port;
            settings.isSsl = sslCheck.Checked;
            settings.emailFrom = emailFromText.Text;
            settings.password = passwordText.Text;
            settings.isDonateHidden = donateHiddenCheck.Checked;
            settings.Save();
            if (donateHiddenCheck.Checked) mainForm.HideDonateMenuItem();
            else mainForm.ShowDonateMenuItem();
        }


        public OptionsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            LoadOptions();
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            SaveOptions();
            Close();
        }

       private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OptionsForm.opened = false;
        }

        private void sslCheck_Click(object sender, EventArgs e)
        {
            if (sslCheck.Checked == true) portText.Text = "587";
            else portText.Text = "25";
        }

    }
}
