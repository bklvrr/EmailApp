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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelSendRecieve.SuspendLayout();
            this.tableLayoutPanelForSubject.SuspendLayout();
            this.tableLayoutPanelMailList.SuspendLayout();
            this.tableLayoutUsername.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
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
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(782, 653);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelSendRecieve
            // 
            this.tableLayoutPanelSendRecieve.ColumnCount = 1;
            this.tableLayoutPanelSendRecieve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSendRecieve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSendRecieve.Controls.Add(this.richTextBoxMail, 0, 1);
            this.tableLayoutPanelSendRecieve.Controls.Add(this.tableLayoutPanelForSubject, 0, 0);
            this.tableLayoutPanelSendRecieve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSendRecieve.Location = new System.Drawing.Point(244, 3);
            this.tableLayoutPanelSendRecieve.Name = "tableLayoutPanelSendRecieve";
            this.tableLayoutPanelSendRecieve.RowCount = 2;
            this.tableLayoutPanelSendRecieve.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.14196F));
            this.tableLayoutPanelSendRecieve.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.85805F));
            this.tableLayoutPanelSendRecieve.Size = new System.Drawing.Size(535, 538);
            this.tableLayoutPanelSendRecieve.TabIndex = 1;
            // 
            // richTextBoxMail
            // 
            this.richTextBoxMail.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMail.Location = new System.Drawing.Point(3, 84);
            this.richTextBoxMail.Name = "richTextBoxMail";
            this.richTextBoxMail.ReadOnly = true;
            this.richTextBoxMail.Size = new System.Drawing.Size(529, 451);
            this.richTextBoxMail.TabIndex = 0;
            this.richTextBoxMail.Text = "";
            // 
            // tableLayoutPanelForSubject
            // 
            this.tableLayoutPanelForSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelForSubject.ColumnCount = 2;
            this.tableLayoutPanelForSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.33702F));
            this.tableLayoutPanelForSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.66299F));
            this.tableLayoutPanelForSubject.Controls.Add(this.textBoxFor, 1, 0);
            this.tableLayoutPanelForSubject.Controls.Add(this.textBoxSubject, 1, 1);
            this.tableLayoutPanelForSubject.Controls.Add(this.labelFor, 0, 0);
            this.tableLayoutPanelForSubject.Controls.Add(this.labelSubject, 0, 1);
            this.tableLayoutPanelForSubject.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelForSubject.Name = "tableLayoutPanelForSubject";
            this.tableLayoutPanelForSubject.RowCount = 2;
            this.tableLayoutPanelForSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelForSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelForSubject.Size = new System.Drawing.Size(529, 49);
            this.tableLayoutPanelForSubject.TabIndex = 1;
            // 
            // textBoxFor
            // 
            this.textBoxFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFor.Location = new System.Drawing.Point(105, 3);
            this.textBoxFor.MinimumSize = new System.Drawing.Size(421, 22);
            this.textBoxFor.Name = "textBoxFor";
            this.textBoxFor.Size = new System.Drawing.Size(421, 22);
            this.textBoxFor.TabIndex = 0;
            this.textBoxFor.TextChanged += new System.EventHandler(this.textBoxFor_TextChanged);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSubject.Location = new System.Drawing.Point(105, 27);
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
            this.labelFor.Location = new System.Drawing.Point(3, 2);
            this.labelFor.Name = "labelFor";
            this.labelFor.Size = new System.Drawing.Size(96, 20);
            this.labelFor.TabIndex = 2;
            this.labelFor.Text = "Кому: ";
            this.labelFor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSubject
            // 
            this.labelSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubject.Location = new System.Drawing.Point(3, 26);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(96, 20);
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
            this.tableLayoutPanelMailList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.42751F));
            this.tableLayoutPanelMailList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.57249F));
            this.tableLayoutPanelMailList.Size = new System.Drawing.Size(235, 538);
            this.tableLayoutPanelMailList.TabIndex = 2;
            // 
            // listBoxMail
            // 
            this.listBoxMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMail.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMail.FormattingEnabled = true;
            this.listBoxMail.ItemHeight = 20;
            this.listBoxMail.Location = new System.Drawing.Point(3, 86);
            this.listBoxMail.Name = "listBoxMail";
            this.listBoxMail.Size = new System.Drawing.Size(229, 449);
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
            this.tableLayoutUsername.Controls.Add(this.label1, 0, 2);
            this.tableLayoutUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutUsername.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutUsername.Name = "tableLayoutUsername";
            this.tableLayoutUsername.RowCount = 3;
            this.tableLayoutUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutUsername.Size = new System.Drawing.Size(229, 77);
            this.tableLayoutUsername.TabIndex = 2;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.Location = new System.Drawing.Point(3, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(223, 28);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Имя пользователя";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUsername.Location = new System.Drawing.Point(3, 31);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(223, 22);
            this.textBoxUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список писем \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(244, 563);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 2;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(535, 70);
            this.tableLayoutPanelButtons.TabIndex = 3;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWrite.Location = new System.Drawing.Point(3, 3);
            this.buttonWrite.MinimumSize = new System.Drawing.Size(261, 29);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(261, 29);
            this.buttonWrite.TabIndex = 0;
            this.buttonWrite.Text = "Написать";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Location = new System.Drawing.Point(270, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(262, 29);
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
            this.buttonSend.Size = new System.Drawing.Size(261, 29);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBack.Enabled = false;
            this.buttonBack.Location = new System.Drawing.Point(270, 38);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(262, 29);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRefresh.Location = new System.Drawing.Point(3, 547);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(235, 103);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelSendRecieve.ResumeLayout(false);
            this.tableLayoutPanelForSubject.ResumeLayout(false);
            this.tableLayoutPanelForSubject.PerformLayout();
            this.tableLayoutPanelMailList.ResumeLayout(false);
            this.tableLayoutUsername.ResumeLayout(false);
            this.tableLayoutUsername.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
    }
}

