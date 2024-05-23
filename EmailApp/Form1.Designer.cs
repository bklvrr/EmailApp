namespace EmailApp {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelSendRecieve = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxMail = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanelForSubject = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxFor = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.labelFor = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.tableLayoutPanelMailList = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxMail = new System.Windows.Forms.ListBox();
            this.tableLayoutUsername = new System.Windows.Forms.TableLayoutPanel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.menuStripFolders = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFolders = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInbox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFlagged = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDraft = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelSendRecieve.SuspendLayout();
            this.tableLayoutPanelForSubject.SuspendLayout();
            this.tableLayoutPanelMailList.SuspendLayout();
            this.tableLayoutUsername.SuspendLayout();
            this.menuStripFolders.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.875F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.125F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelSendRecieve, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelMailList, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelButtons, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonRefresh, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1182, 953);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelSendRecieve
            // 
            this.tableLayoutPanelSendRecieve.ColumnCount = 1;
            this.tableLayoutPanelSendRecieve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.95327F));
            this.tableLayoutPanelSendRecieve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.04673F));
            this.tableLayoutPanelSendRecieve.Controls.Add(this.richTextBoxMail, 0, 1);
            this.tableLayoutPanelSendRecieve.Controls.Add(this.tableLayoutPanelForSubject, 0, 0);
            this.tableLayoutPanelSendRecieve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSendRecieve.Location = new System.Drawing.Point(367, 3);
            this.tableLayoutPanelSendRecieve.Name = "tableLayoutPanelSendRecieve";
            this.tableLayoutPanelSendRecieve.RowCount = 2;
            this.tableLayoutPanelSendRecieve.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.01115F));
            this.tableLayoutPanelSendRecieve.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.98885F));
            this.tableLayoutPanelSendRecieve.Size = new System.Drawing.Size(812, 788);
            this.tableLayoutPanelSendRecieve.TabIndex = 1;
            // 
            // richTextBoxMail
            // 
            this.richTextBoxMail.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMail.Location = new System.Drawing.Point(3, 105);
            this.richTextBoxMail.Name = "richTextBoxMail";
            this.richTextBoxMail.ReadOnly = true;
            this.richTextBoxMail.Size = new System.Drawing.Size(806, 680);
            this.richTextBoxMail.TabIndex = 0;
            this.richTextBoxMail.Text = "";
            // 
            // tableLayoutPanelForSubject
            // 
            this.tableLayoutPanelForSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelForSubject.ColumnCount = 3;
            this.tableLayoutPanelForSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.33702F));
            this.tableLayoutPanelForSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.66299F));
            this.tableLayoutPanelForSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanelForSubject.Controls.Add(this.textBoxFor, 1, 0);
            this.tableLayoutPanelForSubject.Controls.Add(this.textBoxSubject, 1, 1);
            this.tableLayoutPanelForSubject.Controls.Add(this.labelFor, 0, 0);
            this.tableLayoutPanelForSubject.Controls.Add(this.labelSubject, 0, 1);
            this.tableLayoutPanelForSubject.Location = new System.Drawing.Point(3, 14);
            this.tableLayoutPanelForSubject.Name = "tableLayoutPanelForSubject";
            this.tableLayoutPanelForSubject.RowCount = 2;
            this.tableLayoutPanelForSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.97959F));
            this.tableLayoutPanelForSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.02041F));
            this.tableLayoutPanelForSubject.Size = new System.Drawing.Size(806, 73);
            this.tableLayoutPanelForSubject.TabIndex = 1;
            // 
            // textBoxFor
            // 
            this.textBoxFor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFor.Location = new System.Drawing.Point(126, 6);
            this.textBoxFor.MinimumSize = new System.Drawing.Size(421, 22);
            this.textBoxFor.Name = "textBoxFor";
            this.textBoxFor.Size = new System.Drawing.Size(421, 22);
            this.textBoxFor.TabIndex = 0;
            this.textBoxFor.TextChanged += new System.EventHandler(this.textBoxFor_TextChanged);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSubject.Location = new System.Drawing.Point(126, 43);
            this.textBoxSubject.MinimumSize = new System.Drawing.Size(421, 22);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(421, 22);
            this.textBoxSubject.TabIndex = 1;
            // 
            // labelFor
            // 
            this.labelFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFor.AutoSize = true;
            this.labelFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFor.Location = new System.Drawing.Point(3, 7);
            this.labelFor.Name = "labelFor";
            this.labelFor.Size = new System.Drawing.Size(117, 20);
            this.labelFor.TabIndex = 2;
            this.labelFor.Text = "Кому: ";
            this.labelFor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSubject
            // 
            this.labelSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubject.Location = new System.Drawing.Point(3, 44);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(117, 20);
            this.labelSubject.TabIndex = 3;
            this.labelSubject.Text = "Тема: ";
            this.labelSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanelMailList
            // 
            this.tableLayoutPanelMailList.ColumnCount = 1;
            this.tableLayoutPanelMailList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMailList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMailList.Controls.Add(this.listBoxMail, 0, 1);
            this.tableLayoutPanelMailList.Controls.Add(this.tableLayoutUsername, 0, 0);
            this.tableLayoutPanelMailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMailList.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelMailList.Name = "tableLayoutPanelMailList";
            this.tableLayoutPanelMailList.RowCount = 2;
            this.tableLayoutPanelMailList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.21561F));
            this.tableLayoutPanelMailList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.78439F));
            this.tableLayoutPanelMailList.Size = new System.Drawing.Size(358, 788);
            this.tableLayoutPanelMailList.TabIndex = 2;
            // 
            // listBoxMail
            // 
            this.listBoxMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMail.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMail.FormattingEnabled = true;
            this.listBoxMail.ItemHeight = 20;
            this.listBoxMail.Location = new System.Drawing.Point(3, 146);
            this.listBoxMail.Name = "listBoxMail";
            this.listBoxMail.Size = new System.Drawing.Size(352, 639);
            this.listBoxMail.TabIndex = 1;
            this.listBoxMail.SelectedIndexChanged += new System.EventHandler(this.listBoxMail_SelectedIndexChanged);
            // 
            // tableLayoutUsername
            // 
            this.tableLayoutUsername.ColumnCount = 1;
            this.tableLayoutUsername.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutUsername.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutUsername.Controls.Add(this.labelUsername, 0, 0);
            this.tableLayoutUsername.Controls.Add(this.textBoxUsername, 0, 1);
            this.tableLayoutUsername.Controls.Add(this.menuStripFolders, 0, 2);
            this.tableLayoutUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutUsername.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutUsername.Name = "tableLayoutUsername";
            this.tableLayoutUsername.RowCount = 3;
            this.tableLayoutUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutUsername.Size = new System.Drawing.Size(352, 137);
            this.tableLayoutUsername.TabIndex = 2;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.Location = new System.Drawing.Point(3, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(346, 51);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Имя пользователя";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUsername.Location = new System.Drawing.Point(3, 54);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(346, 22);
            this.textBoxUsername.TabIndex = 1;
            // 
            // menuStripFolders
            // 
            this.menuStripFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStripFolders.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripFolders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFolders});
            this.menuStripFolders.Location = new System.Drawing.Point(0, 102);
            this.menuStripFolders.Name = "menuStripFolders";
            this.menuStripFolders.Size = new System.Drawing.Size(352, 35);
            this.menuStripFolders.TabIndex = 2;
            this.menuStripFolders.Text = "Папки с письмами";
            // 
            // toolStripMenuItemFolders
            // 
            this.toolStripMenuItemFolders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInbox,
            this.toolStripMenuItemFlagged,
            this.toolStripMenuItemDraft});
            this.toolStripMenuItemFolders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItemFolders.Name = "toolStripMenuItemFolders";
            this.toolStripMenuItemFolders.Size = new System.Drawing.Size(67, 31);
            this.toolStripMenuItemFolders.Text = "Папки";
            // 
            // toolStripMenuItemInbox
            // 
            this.toolStripMenuItemInbox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolStripMenuItemInbox.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.toolStripMenuItemInbox.Name = "toolStripMenuItemInbox";
            this.toolStripMenuItemInbox.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemInbox.Text = "Входящие";
            this.toolStripMenuItemInbox.Click += new System.EventHandler(this.toolStripMenuItemInbox_Click);
            // 
            // toolStripMenuItemFlagged
            // 
            this.toolStripMenuItemFlagged.Name = "toolStripMenuItemFlagged";
            this.toolStripMenuItemFlagged.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemFlagged.Text = "Отмеченные";
            this.toolStripMenuItemFlagged.Click += new System.EventHandler(this.toolStripMenuItemFlagged_Click);
            // 
            // toolStripMenuItemDraft
            // 
            this.toolStripMenuItemDraft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItemDraft.Name = "toolStripMenuItemDraft";
            this.toolStripMenuItemDraft.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemDraft.Text = "Черновики";
            this.toolStripMenuItemDraft.Click += new System.EventHandler(this.toolStripMenuItemDraft_Click);
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelButtons.ColumnCount = 2;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonWrite, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonDelete, 1, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonSend, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonBack, 1, 1);
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(367, 838);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 2;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(812, 70);
            this.tableLayoutPanelButtons.TabIndex = 3;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWrite.Location = new System.Drawing.Point(3, 3);
            this.buttonWrite.MinimumSize = new System.Drawing.Size(261, 29);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(400, 29);
            this.buttonWrite.TabIndex = 0;
            this.buttonWrite.Text = "Написать";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Location = new System.Drawing.Point(409, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(400, 29);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(3, 38);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(400, 29);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBack.Enabled = false;
            this.buttonBack.Location = new System.Drawing.Point(409, 38);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(400, 29);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(3, 822);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(358, 103);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemContextMenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(239, 28);
            // 
            // toolStripMenuItemContextMenu
            // 
            this.toolStripMenuItemContextMenu.Name = "toolStripMenuItemContextMenu";
            this.toolStripMenuItemContextMenu.Size = new System.Drawing.Size(238, 24);
            this.toolStripMenuItemContextMenu.Text = "Добавить в избранное";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 953);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelSendRecieve.ResumeLayout(false);
            this.tableLayoutPanelForSubject.ResumeLayout(false);
            this.tableLayoutPanelForSubject.PerformLayout();
            this.tableLayoutPanelMailList.ResumeLayout(false);
            this.tableLayoutUsername.ResumeLayout(false);
            this.tableLayoutUsername.PerformLayout();
            this.menuStripFolders.ResumeLayout(false);
            this.menuStripFolders.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSendRecieve;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMailList;
        private System.Windows.Forms.RichTextBox richTextBoxMail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelForSubject;
        private System.Windows.Forms.TextBox textBoxFor;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label labelFor;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        public System.Windows.Forms.ListBox listBoxMail;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.MenuStrip menuStripFolders;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFolders;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInbox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFlagged;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDraft;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContextMenu;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

