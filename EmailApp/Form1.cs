using System;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Net.Http.Headers;
using MailKit.Net.Imap;
using System.Net.Mail;
using System.Windows.Forms;

namespace EmailApp {
    public partial class Form1 : Form {

        string userEmail = "test1mailkit@gmail.com";
        string userPassword = "jgws ddxe piif zmqk";  // use google account setting to generate it
        ImapClient user;

        IMailFolder mailList;
        string MailText;

        public Form1() {
            InitializeComponent();
            var client = new ImapClient();
            try {
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(userEmail, userPassword);

                // The Inbox folder is always available on all IMAP servers...

                mailList = client.Inbox;
                mailList.Open(FolderAccess.ReadOnly);
                //listBoxMail.Items.Clear();

                for (int i = mailList.Count - 1; i >= 0; i--) { // use backward "for" to get message from newest to oldest 
                    var message = mailList.GetMessage(i);
                    listBoxMail.Items.Add(message.Subject);
                }
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
                client.Disconnect(true);
            }

        }
    }
}
