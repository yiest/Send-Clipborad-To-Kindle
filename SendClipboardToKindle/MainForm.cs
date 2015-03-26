using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Diagnostics;
using System.Configuration;
using System.Net.Mime;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Resources;


namespace SendClipboardToKindle
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var settings = Properties.Settings.Default;
            if (settings.UpgradeRequired)
            {
                settings.Upgrade();
                settings.UpgradeRequired = false;
                settings.Save();
            }
            this.Visible = false;
            bool isDonateHidden = settings.isDonateHidden;
            if (isDonateHidden) HideDonateMenuItem();
            Hotkey hotkey;
            hotkey = new Hotkey(this.Handle);
            Hotkey.Hotkey1 = hotkey.RegisterHotkey(System.Windows.Forms.Keys.F3, Hotkey.KeyFlags.MOD_CONTROL); 
            hotkey.OnHotkey += new HotkeyEventHandler(OnHotkey);
        }

        public void HideDonateMenuItem()
        {
            donateToolStripMenuItem.Visible = false;
        }

        public void ShowDonateMenuItem()
        {
            donateToolStripMenuItem.Visible = true;
        }

        private void ShowOptionsForm()
        {
            if (OptionsForm.opened)
                return;
            else
            {
                OptionsForm.opened = true;
                var optionsForm = new OptionsForm(this);
                optionsForm.Show();
            }
        }

        private void optionsItem_Click(object sender, EventArgs e)
        {
            ShowOptionsForm();
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendEmail();
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://www.yiest.com/donate/"));
        }

        private string ReplaceBadCharOfFileName(string fileName)
        {
            string str = fileName;
            str = str.Replace("\\", string.Empty);
            str = str.Replace("/", string.Empty);
            str = str.Replace(":", string.Empty);
            str = str.Replace("*", string.Empty);
            str = str.Replace("?", string.Empty);
            str = str.Replace("\"", string.Empty);
            str = str.Replace("<", string.Empty);
            str = str.Replace(">", string.Empty);
            str = str.Replace("|", string.Empty);
            str = str.Replace("\t", string.Empty);
            //str = str.Replace(" ", string.Empty);    //前面的替换会产生空格,最后将其一并替换掉
            return str;
        }


        private void SendEmail()
        {
            var settings = Properties.Settings.Default;
            string smtpServer = settings.smtpServer;
            if (smtpServer == "")
            {
                MessageBox.Show("SMTP server is not defined.");
                return;
            }
            int port = settings.port;
            if (port == 0)
            {
                MessageBox.Show("SMTP port is not defined.");
                return;
            }
            bool isSsl = settings.isSsl;
            string emailFrom = settings.emailFrom;
            if (emailFrom == "")
            {
                MessageBox.Show("Sender email is not defined.");
                return;
            }
            string password = settings.password;
            if (password == "")
            {
                MessageBox.Show("SMTP password is not defined.");
                return;
            }
            string sentTo = settings.sendTo;
            if (sentTo == "")
            {
                MessageBox.Show("Kindle email address is not defined.");
                return;
            }

            IDataObject data = Clipboard.GetDataObject();

            string content = (String)data.GetData(DataFormats.Text);

            if (content == "" || content == null)
            {
                MessageBox.Show("No content in the clipboard.");
                return;
            }

            content = content.TrimStart();

            if (data.GetDataPresent(DataFormats.Text))
            {
                swapRichTextBox.Text = content;
            }

            string tempString = Regex.Match(content, @"[^\r\n]+").Value;

            if(tempString.Length>20) tempString = tempString.Substring(0,20);

            string subject = ReplaceBadCharOfFileName(tempString);

            string tempFile = subject + ".txt";

            using (System.IO.FileStream fs = System.IO.File.Create(tempFile)) { }

            swapRichTextBox.SaveFile(tempFile, RichTextBoxStreamType.PlainText);

            string from = emailFrom;
            string to = sentTo;
            MailMessage message = new MailMessage(from, to);
            message.Body = @"Developed by Yiest(www.yiest.com).";
            message.Subject = subject;

            Attachment attachment = new Attachment(tempFile, MediaTypeNames.Application.Octet);
            ContentDisposition disposition = attachment.ContentDisposition;
            disposition.CreationDate = System.IO.File.GetCreationTime(tempFile);
            disposition.ModificationDate = System.IO.File.GetLastWriteTime(tempFile);
            disposition.ReadDate = System.IO.File.GetLastAccessTime(tempFile);
            message.Attachments.Add(attachment);
            this.notifyIcon.Icon = Properties.Resources.sending;

            SmtpClient client = new SmtpClient(smtpServer);
            client.Port = port;
            client.EnableSsl = isSsl;
            client.Timeout = 10000;
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential(emailFrom, password);

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                //Error, could not send the message
                MessageBox.Show(ex.Message);
            }
            finally
            {
                attachment.Dispose();
                File.Delete(tempFile);
                this.notifyIcon.Icon = Properties.Resources.icon;
            }

            
        }

        public void OnHotkey(int HotkeyID) //设置热键的行为
        {
            SendEmail();
        }

    }

        
    public delegate void HotkeyEventHandler(int HotKeyID);

    public class Hotkey : System.Windows.Forms.IMessageFilter
    {
        Hashtable keyIDs = new Hashtable();
        IntPtr hWnd;

        static public int Hotkey1;

        public event HotkeyEventHandler OnHotkey;

        public enum KeyFlags
        {
            MOD_ALT = 0x1,
            MOD_CONTROL = 0x2,
            MOD_SHIFT = 0x4,
            MOD_WIN = 0x8
        }
        [DllImport("user32.dll")]
        public static extern UInt32 RegisterHotKey(IntPtr hWnd, UInt32 id, UInt32 fsModifiers, UInt32 vk);

        [DllImport("user32.dll")]
        public static extern UInt32 UnregisterHotKey(IntPtr hWnd, UInt32 id);

        [DllImport("kernel32.dll")]
        public static extern UInt32 GlobalAddAtom(String lpString);

        [DllImport("kernel32.dll")]
        public static extern UInt32 GlobalDeleteAtom(UInt32 nAtom);

        public Hotkey(IntPtr hWnd)
        {
            this.hWnd = hWnd;
            Application.AddMessageFilter(this);
        }

        public int RegisterHotkey(Keys Key, KeyFlags keyflags)
        {
            UInt32 hotkeyid = GlobalAddAtom(System.Guid.NewGuid().ToString());
            RegisterHotKey((IntPtr)hWnd, hotkeyid, (UInt32)keyflags, (UInt32)Key);
            keyIDs.Add(hotkeyid, hotkeyid);
            return (int)hotkeyid;
        }

        public void UnregisterHotkeys()
        {
            Application.RemoveMessageFilter(this);
            foreach (UInt32 key in keyIDs.Values)
            {
                UnregisterHotKey(hWnd, key);
                GlobalDeleteAtom(key);
            }
        }

        public bool PreFilterMessage(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == 0x312)
            {
                if (OnHotkey != null)
                {
                    foreach (UInt32 key in keyIDs.Values)
                    {
                        if ((UInt32)m.WParam == key)
                        {
                            OnHotkey((int)m.WParam);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

    }

}
