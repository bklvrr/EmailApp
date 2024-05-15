using System;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Net.Http.Headers;
using MailKit.Net.Imap;
using System.Net.Mail;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

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

            var client = new ImapClient();
            try {
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(userEmail, userPassword);

                // The Inbox folder is always available on all IMAP servers...

                mailList = client.Inbox;
                mailList.Open(FolderAccess.ReadOnly);
                //listBoxMail.Items.Clear();

                /*
                for (int i = mailList.Count - 1; i >= 0; i--) { // use backward "for" to get message from newest to oldest 
                    var message = mailList.GetMessage(i);
                    listBoxMail.Items.Add(message.Subject);
                }
                Console.WriteLine(listBoxMail.Items.Count);
                listBoxMail.Refresh();
                */

                LoadMessages();
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
            listBoxMail.Items.Clear(); // maybe it'll be better to delite this 
            richTextBoxMail.Text = "Здесь можно написать текст...";
            buttonWrite.Enabled = false;
            buttonSend.Enabled = true;
            buttonBack.Enabled = true;
            buttonDelete.Enabled = false;
            
            MailText = "";
        }

        private void SendingEmailCheck() { // TODO: Сделать проверку на наличие @yandex.com | @gmail.com |

        }

        private void buttonSend_Click(object sender, EventArgs e) { // TODO: Сделать отправку сообещний 

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(userEmail, userEmail));
            message.To.Add(new MailboxAddress("HELLO WORLD", textBoxFor.Text));
            message.Subject = textBoxSubject.Text;

            message.Body = new TextPart("plain") {
                Text = MailText 
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
            
        }

        private void buttonDelete_Click(object sender, EventArgs e) {// TODO: Сделать удаление писем с вызовом MassageBox

        }

        private void textBoxFor_TextChanged(object sender, EventArgs e) {
            MailText = richTextBoxMail.Text;
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            MailText = "";
            buttonBack.Enabled = false;
            buttonWrite.Enabled = true;
            buttonSend.Enabled = false;
            textBoxFor.Enabled = false;
            textBoxSubject.Enabled = false;
            buttonDelete.Enabled = true;
            richTextBoxMail.Text = "";
            LoadMessages();
        }

        private void LoadMessages() { // FIX THIS: (оптимизировать повторную загрузку сообщений(сохранять их в массиве))
            for (int i = 0; i < mailList.Count; i++) {
                var message = mailList.GetMessage(i);
                listBoxMail.Items.Add(message.Subject);
            }
        }


        
    }
}
