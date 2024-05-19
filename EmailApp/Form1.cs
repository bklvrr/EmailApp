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
using System.Threading;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Drawing;

namespace EmailApp {
    public partial class Form1 : Form {

        string userEmail = "test1mailkit@gmail.com";
        string userPassword = "jgws ddxe piif zmqk";  // use google account setting to generate it
        ImapClient client;

        //static string[] CommonSentFolderNames = { "Sent Items", "Sent Mail", "Sent Messages", /* maybe add some translated names */ };
        static string[] CommonFlaggedFolderNames = { "Flagged Items", "Flagged Mail", "Flagged Messages" };
        static string[] CommonDraftedFolderNames = { "Draft Items", "Draft Mail", "Draft Messages" };

        List<string> InboxList = new List<string>();
        List<string> FlaggedList = new List<string>();
        List<string> DraftedList = new List<string>();

        string emailFor;
        string emailSubject;



        IMailFolder inboxMailFolder;
        IMailFolder flaggedMailFolder;
        IMailFolder draftMailFolder;
        //IMailFolder junkMailFolder;

        string MailText = "";

        public Form1() {
            InitializeComponent();

            textBoxUsername.Text = userEmail;
            textBoxFor.Enabled = false;
            textBoxSubject.Enabled = false;

            listBoxMail.ContextMenuStrip = contextMenuStrip1;

            client = new ImapClient();
            try {
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(userEmail, userPassword);

                // The Inbox folder is always available on all IMAP servers...

                inboxMailFolder = client.Inbox;
                inboxMailFolder.Open(FolderAccess.ReadWrite);

                var personal = client.GetFolder(client.PersonalNamespaces[0]);
                foreach (var folder in personal.GetSubfolders(false)) {
                    Console.WriteLine("[folder] {0}", folder.Name);
                }

                if ((client.Capabilities & (ImapCapabilities.SpecialUse | ImapCapabilities.XList)) != 0) {
                    draftMailFolder = client.GetFolder(SpecialFolder.Drafts);
                    flaggedMailFolder = client.GetFolder(SpecialFolder.Flagged);
                    //junkMailFolder = client.GetFolder(SpecialFolder.Junk);
                    Console.WriteLine("Hello world!");

                } else {
                    // maybe check the user's preferences for the Drafts folder?
                }


                //listBoxMail.Items.Clear();

                /*
                for (int i = mailList.Count - 1; i >= 0; i--) { // use backward "for" to get message from newest to oldest 
                    var message = mailList.GetMessage(i);
                    listBoxMail.Items.Add(message.Subject);
                }

                Console.WriteLine(listBoxMail.Items.Count);
                listBoxMail.Refresh();
                */

                LoadMessages(ref inboxMailFolder);
                toolStripMenuItemInbox.BackColor = Color.DeepSkyBlue;
                //Console.WriteLine(listBoxMail.Items.Count);


                listBoxMail.Refresh();

                //var inbox = client.Inbox;
                //inbox.Open(FolderAccess.ReadOnly);

                //Console.WriteLine("Total messages: {0}", inbox.Count);
                //Console.WriteLine("Recent messages: {0}", inbox.Recent);

                //for (int i = 0; i < inbox.Count; i++) {
                //    var message = inbox.GetMessage(i);
                //    Console.WriteLine("Subject: {0}", message.Subject);
                //}

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                //client.Disconnect(true);
            }

        }

        private void listBoxMail_SelectedIndexChanged(object sender, EventArgs e) { //FIX ME: Убрать цикл окончательно, посмотреть правильно ли работает без него
            int index = listBoxMail.SelectedIndex;
            //for (int i = inboxMailFolder.Count - 1; i >= 0; i--) {
                //if (i == index) {
                    if (toolStripMenuItemInbox.BackColor == Color.DeepSkyBlue) {
                        richTextBoxMail.Text = inboxMailFolder.GetMessage(index).TextBody;
                    }
                    if (toolStripMenuItemFlagged.BackColor == Color.DeepSkyBlue) {
                        richTextBoxMail.Text = flaggedMailFolder.GetMessage(index).TextBody;
                    }

                    if (toolStripMenuItemDraft.BackColor == Color.DeepSkyBlue) {
                        richTextBoxMail.Text = draftMailFolder.GetMessage(index).TextBody;
                    }
                //}
            //}
        }

        private void buttonWrite_Click(object sender, EventArgs e) {
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
            if (toolStripMenuItemDraft.BackColor == Color.DeepSkyBlue) {
                message = draftMailFolder.GetMessage(listBoxMail.SelectedIndex);
            } else {
                
                message.From.Add(new MailboxAddress(userEmail, userEmail));
                message.To.Add(new MailboxAddress(textBoxFor.Text, textBoxFor.Text));
                message.Subject = textBoxSubject.Text;

                message.Body = new TextPart("plain") {
                    Text = richTextBoxMail.Text
                };
            }
           
                if (textBoxFor.Text != string.Empty && textBoxFor.Text.Contains("@") && (textBoxFor.Text.Contains(".com") || textBoxFor.Text.Contains(".ru"))) {
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
                    }
                } else {
                    MessageBox.Show("Уточните адрес почты",
                                    "Сообщение",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information,
                                     MessageBoxDefaultButton.Button1,
                                     MessageBoxOptions.DefaultDesktopOnly);
                }
        }

        private void buttonDelete_Click(object sender, EventArgs e) { // TODO: Сделать удаление писем с вызовом MassageBox

            if (toolStripMenuItemInbox.BackColor == Color.DeepSkyBlue) {
                inboxMailFolder.Open(FolderAccess.ReadWrite);
                inboxMailFolder.Store(listBoxMail.SelectedIndex, new StoreFlagsRequest(StoreAction.Add, MessageFlags.Deleted) { Silent = true });
                inboxMailFolder.Expunge();
                LoadMessages(ref inboxMailFolder);

            }
            if (toolStripMenuItemFlagged.BackColor == Color.DeepSkyBlue) {
                flaggedMailFolder.Open(FolderAccess.ReadWrite);
                flaggedMailFolder.Store(listBoxMail.SelectedIndex, new StoreFlagsRequest(StoreAction.Add, MessageFlags.Deleted) { Silent = true });
                flaggedMailFolder.Expunge();
                LoadMessages(ref flaggedMailFolder);
            }

            if (toolStripMenuItemDraft.BackColor == Color.DeepSkyBlue) {
                draftMailFolder.Open(FolderAccess.ReadWrite);
                draftMailFolder.Store(listBoxMail.SelectedIndex, new StoreFlagsRequest(StoreAction.Add, MessageFlags.Deleted) { Silent = true });
                draftMailFolder.Expunge();
                LoadMessages(ref draftMailFolder);
            }
           
        }

        private void textBoxFor_TextChanged(object sender, EventArgs e) {
            MailText = richTextBoxMail.Text;
        }

        private void buttonBack_Click(object sender, EventArgs e) {

            if (richTextBoxMail.Text != "" || textBoxFor.Text != "" || textBoxSubject.Text != "") {
                DialogResult result = MessageBox.Show("Сохранить черновик?",
                                                    "Сообщение",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Information,
                                                    MessageBoxDefaultButton.Button1,
                                                    MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes) {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress(userEmail, userEmail));
                    message.To.Add(new MailboxAddress(textBoxFor.Text, textBoxFor.Text));
                    message.Subject = textBoxSubject.Text;

                    message.Body = new TextPart("plain") {
                        Text = richTextBoxMail.Text
                    };
                    draftMailFolder = client.GetFolder(SpecialFolder.Drafts);
                    draftMailFolder.Open(FolderAccess.ReadWrite);
                    draftMailFolder.Append(message, MessageFlags.Draft);
                    Console.WriteLine("Hello world222");
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
        }

        private void buttonRefresh_Click(object sender, EventArgs e) { // FIX ME: добавить оптимизацию для обновления (не каждый раз обнавлять) 

            if (toolStripMenuItemInbox.BackColor == Color.DeepSkyBlue) {
                inboxMailFolder = client.Inbox;
                inboxMailFolder.Open(FolderAccess.ReadOnly);
                LoadMessages(ref inboxMailFolder);
            }

            if (toolStripMenuItemFlagged.BackColor == Color.DeepSkyBlue) {
                flaggedMailFolder = client.GetFolder(SpecialFolder.Flagged);
                flaggedMailFolder.Open(FolderAccess.ReadOnly);
                LoadMessages(ref flaggedMailFolder);
            }

            if (toolStripMenuItemDraft.BackColor == Color.DeepSkyBlue) {
                draftMailFolder = client.GetFolder(SpecialFolder.Drafts);
                draftMailFolder.Open(FolderAccess.ReadOnly);
                LoadMessages(ref draftMailFolder);
            }

            //if (listBoxMail.Items.Count == mailList.Count) { // ????
            //    return;
            //}
        }

        private void LoadMessages(ref IMailFolder folder) { // FIX ME: (оптимизировать повторную загрузку сообщений(сохранять их в массиве))
            folder.Open(FolderAccess.ReadWrite);
            listBoxMail.Items.Clear();
            for (int i = 0; i < folder.Count; i++) {
                var message = folder.GetMessage(i);
                Console.WriteLine(folder.Name);

                if (folder.Name == "INBOX") {
                    //InboxList.Add(message.Subject);

                } else if (folder.Name == "DRAFTED") {
                    //DraftedList.Add(message.Subject);

                } else if (folder.Name == "FLAGGED") {
                    //FlaggedList.Add(message.Subject);
                }
                //    var flag = folder.PermanentFlags; // так выдаётся просто список всех флагов, надо как-то узнавать флаг конкретного сообщения.

                //Console.WriteLine(folder.Name + ": " + message.Subject);
                // ВАЖНО
                if(message.Subject == string.Empty) {
                    listBoxMail.Items.Add("< Без темы >");
                } else {
                    listBoxMail.Items.Add(message.Subject);
                }
                
                //Console.WriteLine(flag);

                /*if(flag =MessageFlags.Seen) { // FIX ME: почему-то макрек ставится на все письма сразу(допили уже эту фичу)
                    listBoxMail.Items.Add(message.Subject);
                } else {
                    listBoxMail.Items.Add(("⚫") + message.Subject);
                }
                */
            }
        }

        private void toolStripMenuItemInbox_Click(object sender, EventArgs e) {
            if (toolStripMenuItemInbox.BackColor == Color.DeepSkyBlue) {
                LoadMessages(ref inboxMailFolder);
                return;
            } else {
                toolStripMenuItemInbox.BackColor = Color.DeepSkyBlue;
                toolStripMenuItemDraft.BackColor = Color.WhiteSmoke;
                toolStripMenuItemFlagged.BackColor = Color.WhiteSmoke;
                LoadMessages(ref inboxMailFolder);
            }
        }

        private void toolStripMenuItemFlagged_Click(object sender, EventArgs e) {
            if (toolStripMenuItemFlagged.BackColor == Color.DeepSkyBlue) {
                LoadMessages(ref flaggedMailFolder);
                return;

            } else {
                toolStripMenuItemInbox.BackColor = Color.WhiteSmoke;
                toolStripMenuItemDraft.BackColor = Color.WhiteSmoke;
                toolStripMenuItemFlagged.BackColor = Color.DeepSkyBlue;
                LoadMessages(ref flaggedMailFolder);
            }
        }

        private void toolStripMenuItemDraft_Click(object sender, EventArgs e) {
            if (toolStripMenuItemDraft.BackColor == Color.DeepSkyBlue) {
                LoadMessages(ref draftMailFolder);
                return;

            } else {
                toolStripMenuItemInbox.BackColor = Color.WhiteSmoke;
                toolStripMenuItemDraft.BackColor = Color.DeepSkyBlue;
                toolStripMenuItemFlagged.BackColor = Color.WhiteSmoke;
                LoadMessages(ref draftMailFolder);
            }
        }

        /*                                                                  
        private void toolStripMenuItem1_Click(object sender, EventArgs e) {     // FIX ME: доделать функцию добавления в избранное
            if (toolStripMenuItemInbox.BackColor == Color.DeepSkyBlue && inboxMailFolder. == MessageFlags.Flagged) {
                flaggedMailFolder.Open(FolderAccess.ReadWrite);
                flaggedMailFolder.Store(listBoxMail.SelectedIndex, new StoreFlagsRequest(StoreAction.Add, MessageFlags.Flagged) { Silent = true });
                flaggedMailFolder.Expunge();
                //LoadMessages(ref flaggedMailFolder);
            }

            if (toolStripMenuItemFlagged.BackColor == Color.DeepSkyBlue) {

            }

            if (toolStripMenuItemDraft.BackColor == Color.DeepSkyBlue) {
                flaggedMailFolder.Open(FolderAccess.ReadWrite);
                flaggedMailFolder.Store(listBoxMail.SelectedIndex, new StoreFlagsRequest(StoreAction.Add, MessageFlags.Flagged) { Silent = true });
                flaggedMailFolder.Expunge();
            }
        }*/
    }
}
