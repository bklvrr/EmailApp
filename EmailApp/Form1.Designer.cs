﻿namespace EmailApp {
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSend = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.625F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.375F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelSendRecieve, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelMailList, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelButtons, 1, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelSendRecieve
            // 
            this.tableLayoutPanelSendRecieve.ColumnCount = 1;
            this.tableLayoutPanelSendRecieve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSendRecieve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSendRecieve.Controls.Add(this.richTextBox1, 0, 1);
            this.tableLayoutPanelSendRecieve.Controls.Add(this.tableLayoutPanelForSubject, 0, 0);
            this.tableLayoutPanelSendRecieve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSendRecieve.Location = new System.Drawing.Point(248, 3);
            this.tableLayoutPanelSendRecieve.Name = "tableLayoutPanelSendRecieve";
            this.tableLayoutPanelSendRecieve.RowCount = 2;
            this.tableLayoutPanelSendRecieve.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.14196F));
            this.tableLayoutPanelSendRecieve.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.85805F));
            this.tableLayoutPanelSendRecieve.Size = new System.Drawing.Size(549, 368);
            this.tableLayoutPanelSendRecieve.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(543, 307);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
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
            this.tableLayoutPanelForSubject.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelForSubject.Name = "tableLayoutPanelForSubject";
            this.tableLayoutPanelForSubject.RowCount = 2;
            this.tableLayoutPanelForSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelForSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelForSubject.Size = new System.Drawing.Size(543, 49);
            this.tableLayoutPanelForSubject.TabIndex = 1;
            // 
            // textBoxFor
            // 
            this.textBoxFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFor.Location = new System.Drawing.Point(108, 3);
            this.textBoxFor.Name = "textBoxFor";
            this.textBoxFor.ReadOnly = true;
            this.textBoxFor.Size = new System.Drawing.Size(432, 22);
            this.textBoxFor.TabIndex = 0;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSubject.Location = new System.Drawing.Point(108, 27);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.ReadOnly = true;
            this.textBoxSubject.Size = new System.Drawing.Size(432, 22);
            this.textBoxSubject.TabIndex = 1;
            // 
            // labelFor
            // 
            this.labelFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFor.AutoSize = true;
            this.labelFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFor.Location = new System.Drawing.Point(3, 2);
            this.labelFor.Name = "labelFor";
            this.labelFor.Size = new System.Drawing.Size(99, 20);
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
            this.labelSubject.Size = new System.Drawing.Size(99, 20);
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
            this.tableLayoutPanelMailList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.17615F));
            this.tableLayoutPanelMailList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.82384F));
            this.tableLayoutPanelMailList.Size = new System.Drawing.Size(239, 368);
            this.tableLayoutPanelMailList.TabIndex = 2;
            // 
            // listBoxMail
            // 
            this.listBoxMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMail.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMail.FormattingEnabled = true;
            this.listBoxMail.ItemHeight = 20;
            this.listBoxMail.Location = new System.Drawing.Point(3, 58);
            this.listBoxMail.Name = "listBoxMail";
            this.listBoxMail.Size = new System.Drawing.Size(233, 307);
            this.listBoxMail.TabIndex = 1;
            // 
            // tableLayoutUsername
            // 
            this.tableLayoutUsername.ColumnCount = 1;
            this.tableLayoutUsername.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutUsername.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutUsername.Controls.Add(this.labelUsername, 0, 0);
            this.tableLayoutUsername.Controls.Add(this.textBoxUsername, 0, 1);
            this.tableLayoutUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutUsername.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutUsername.Name = "tableLayoutUsername";
            this.tableLayoutUsername.RowCount = 2;
            this.tableLayoutUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutUsername.Size = new System.Drawing.Size(233, 49);
            this.tableLayoutUsername.TabIndex = 2;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.Location = new System.Drawing.Point(3, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(227, 24);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Имя пользователя";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUsername.Location = new System.Drawing.Point(3, 27);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(227, 22);
            this.textBoxUsername.TabIndex = 1;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelButtons.ColumnCount = 2;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonSend, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(248, 377);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 2;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(549, 70);
            this.tableLayoutPanelButtons.TabIndex = 3;
            // 
            // buttonSend
            // 
            this.buttonSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSend.Location = new System.Drawing.Point(3, 3);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(268, 29);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(277, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelMain);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelForSubject;
        private System.Windows.Forms.TextBox textBoxFor;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label labelFor;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        public System.Windows.Forms.ListBox listBoxMail;
    }
}

