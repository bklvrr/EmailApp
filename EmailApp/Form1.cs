using System;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Net.Http.Headers;
using MailKit.Net.Imap;
using System.Net.Mail;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Asn1.X509;
using System.Security.Cryptography;
using MailKit.Search;

namespace EmailApp {
    public partial class Form1 : Form {

        string userEmail = "test1mailkit@gmail.com";
        string userPassword = "jgws ddxe piif zmqk";  // use google account setting to generate it
        ImapClient client;

        string emailFor;
        string emailSubject;

        bool readMode = true;

        IMailFolder mailList;
        string MailText = "";

        public Form1() {
            InitializeComponent();

            textBoxUsername.Text = userEmail;
            textBoxFor.Enabled = false;
            textBoxSubject.Enabled = false;

            client = new ImapClient();
            try {
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(userEmail, userPassword);

                // The Inbox folder is always available on all IMAP servers...

                mailList = client.Inbox;
                mailList.Open(FolderAccess.ReadWrite);
                //listBoxMail.Items.Clear();

                /*
                for (int i = mailList.Count - 1; i >= 0; i--) { // use backward "for" to get message from newest to oldest 
                    var message = mailList.GetMessage(i);
                    listBoxMail.Items.Add(message.Subject);
                }
                Console.WriteLine(listBoxMail.Items.Count);
                listBoxMail.Refresh();
                */

                LoadMessages(ref mailList);
                Console.WriteLine(listBoxMail.Items.Count);
                listBoxMail.Refresh();



                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                Console.WriteLine("Total messages: {0}", inbox.Count);
                Console.WriteLine("Recent messages: {0}", inbox.Recent);

                for (int i = 0; i < inbox.Count; i++) {
                    var message = inbox.GetMessage(i);
                    Console.WriteLine("Subject: {0}", message.Subject);
                }

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                //client.Disconnect(true);
            }

        }

        private void listBoxMail_SelectedIndexChanged(object sender, EventArgs e) {
            int index = listBoxMail.SelectedIndex;
            for(int i = mailList.Count - 1; i >= 0; i--) {
                if(i == index) {
                    richTextBoxMail.Text = mailList.GetMessage(i).TextBody;
                }
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e) {
            readMode = false;
            richTextBoxMail.ReadOnly = false;
            textBoxFor.Enabled = true;
            textBoxSubject.Enabled = true;
            listBoxMail.Enabled = false; 
            richTextBoxMail.Text = "Здесь можно написать текст...";
            buttonWrite.Enabled = false;
            buttonSend.Enabled = true;
            buttonBack.Enabled = true;
            buttonDelete.Enabled = false;
            buttonRefresh.Enabled = false;
            
            MailText = "";
        }

        private void SendingEmailCheck() { // TODO: Сделать проверку на наличие @yandex.com | @gmail.com |

        }

        private void buttonSend_Click(object sender, EventArgs e) { 

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(userEmail, userEmail));
            message.To.Add(new MailboxAddress("HELLO WORLD", textBoxFor.Text));
            message.Subject = textBoxSubject.Text;

            message.Body = new TextPart("plain") {
                Text = richTextBoxMail.Text
            };

            using (var clientSMTP = new MailKit.Net.Smtp.SmtpClient()) {
                try {
                    clientSMTP.Connect("smtp.gmail.com", 465, true);

                    // Note: only needed if the SMTP server requires authentication
                    clientSMTP.Authenticate(userEmail, userPassword);
                    clientSMTP.Send(message);

                    Console.WriteLine("email SENT");

                    clientSMTP.Disconnect(true);
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                finally {
                    clientSMTP?.Dispose();
                }
            }

            MailText = "";
            buttonBack.Enabled = false;
            buttonWrite.Enabled = true;
            buttonSend.Enabled = false;
            textBoxFor.Text = "";
            textBoxFor.Enabled = false;
            textBoxSubject.Text = "";
            textBoxSubject.Enabled = false;
            buttonDelete.Enabled = true;
            richTextBoxMail.Text = "";
            richTextBoxMail.ReadOnly = true;
            listBoxMail.Enabled = true;
            buttonRefresh.Enabled = true;

        }

        private void buttonDelete_Click(object sender, EventArgs e) { // TODO: Сделать удаление писем с вызовом MassageBox
            mailList.Open(FolderAccess.ReadWrite);
            mailList.Store(listBoxMail.SelectedIndex, new StoreFlagsRequest(StoreAction.Add, MessageFlags.Deleted) { Silent = true });
            mailList.Expunge();

            LoadMessages(ref mailList);
        }

        private void textBoxFor_TextChanged(object sender, EventArgs e) {
            MailText = richTextBoxMail.Text;
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            MailText = "";
            buttonBack.Enabled = false;
            buttonWrite.Enabled = true;
            buttonSend.Enabled = false;
            textBoxFor.Text = "";
            textBoxFor.Enabled = false;
            textBoxSubject.Text = "";
            textBoxSubject.Enabled = false;
            buttonDelete.Enabled = true;
            richTextBoxMail.Text = "";
            richTextBoxMail.ReadOnly = true;
            listBoxMail.Enabled = true;
            buttonRefresh.Enabled = true;
        }
        
        private void buttonRefresh_Click(object sender, EventArgs e) { // FIX ME: добавить оптимизацию для обновления (не каждый раз обнавлять) 
 
            mailList = client.Inbox;
            //if (listBoxMail.Items.Count == mailList.Count) { // ????
            //    return;
            //}
            mailList.Open(FolderAccess.ReadOnly);
            LoadMessages(ref mailList);


        }

        private void LoadMessages(ref IMailFolder folder) { // FIX THIS: (оптимизировать повторную загрузку сообщений(сохранять их в массиве))
            listBoxMail.Items.Clear();
            for (int i = 0; i < folder.Count; i++) {
                var message = folder.GetMessage(i);
                listBoxMail.Items.Add(message.Subject);
            }
        }
    }
}
