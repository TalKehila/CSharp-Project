namespace LabraryProject
{
    partial class EmpolyeeLogInPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelSerachBook = new Label();
            LabelHelloEmpolyee = new Label();
            ListBoxForBookSearch = new ListBox();
            TextBoxForSearchingBook = new TextBox();
            DeleteBook = new Button();
            ButtonBackToMenu = new Button();
            ReturnBppk = new Button();
            ButtonBorrowBOOK = new Button();
            ButtonAddingNewBook = new Button();
            BtnSeacrh = new Button();
            ResetSearch = new Button();
            BorrowBookList = new ListBox();
            BookDetailsbox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            booklabel = new Label();
            Detailsitem = new Label();
            TextBoxDis = new TextBox();
            TypeTextBox = new TextBox();
            Typelabel = new Label();
            label4 = new Label();
            Applay = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // LabelSerachBook
            // 
            LabelSerachBook.AutoSize = true;
            LabelSerachBook.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelSerachBook.Location = new Point(512, 88);
            LabelSerachBook.Name = "LabelSerachBook";
            LabelSerachBook.Size = new Size(80, 17);
            LabelSerachBook.TabIndex = 0;
            LabelSerachBook.Text = "Search Book";
            // 
            // LabelHelloEmpolyee
            // 
            LabelHelloEmpolyee.AutoSize = true;
            LabelHelloEmpolyee.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHelloEmpolyee.ForeColor = Color.Blue;
            LabelHelloEmpolyee.Location = new Point(347, 22);
            LabelHelloEmpolyee.Name = "LabelHelloEmpolyee";
            LabelHelloEmpolyee.Size = new Size(233, 31);
            LabelHelloEmpolyee.TabIndex = 1;
            LabelHelloEmpolyee.Text = "Hello , Welcome ";
            // 
            // ListBoxForBookSearch
            // 
            ListBoxForBookSearch.FormattingEnabled = true;
            ListBoxForBookSearch.ItemHeight = 15;
            ListBoxForBookSearch.Location = new Point(4, 245);
            ListBoxForBookSearch.Name = "ListBoxForBookSearch";
            ListBoxForBookSearch.Size = new Size(261, 409);
            ListBoxForBookSearch.TabIndex = 2;
            ListBoxForBookSearch.SelectedIndexChanged += ListBoxForBookSearch_SelectedIndexChanged_2;
            // 
            // TextBoxForSearchingBook
            // 
            TextBoxForSearchingBook.Location = new Point(438, 119);
            TextBoxForSearchingBook.Name = "TextBoxForSearchingBook";
            TextBoxForSearchingBook.Size = new Size(244, 23);
            TextBoxForSearchingBook.TabIndex = 3;
            TextBoxForSearchingBook.TextChanged += TextBoxForSearchingBook_TextChanged;
            // 
            // DeleteBook
            // 
            DeleteBook.BackColor = Color.Red;
            DeleteBook.ForeColor = Color.Black;
            DeleteBook.Location = new Point(4, 711);
            DeleteBook.Name = "DeleteBook";
            DeleteBook.Size = new Size(109, 38);
            DeleteBook.TabIndex = 6;
            DeleteBook.Text = "Delete Book";
            DeleteBook.UseVisualStyleBackColor = false;
            DeleteBook.Click += DeleteBook_Click_1;
            // 
            // ButtonBackToMenu
            // 
            ButtonBackToMenu.BackColor = SystemColors.ActiveCaption;
            ButtonBackToMenu.Location = new Point(1235, 711);
            ButtonBackToMenu.Name = "ButtonBackToMenu";
            ButtonBackToMenu.Size = new Size(127, 43);
            ButtonBackToMenu.TabIndex = 7;
            ButtonBackToMenu.Text = "  Back ";
            ButtonBackToMenu.UseVisualStyleBackColor = false;
            ButtonBackToMenu.Click += ButtonBackToMenu_Click_1;
            // 
            // ReturnBppk
            // 
            ReturnBppk.BackColor = Color.FromArgb(255, 128, 128);
            ReturnBppk.Location = new Point(1168, 100);
            ReturnBppk.Name = "ReturnBppk";
            ReturnBppk.Size = new Size(114, 44);
            ReturnBppk.TabIndex = 8;
            ReturnBppk.Text = "Return Book";
            ReturnBppk.UseVisualStyleBackColor = false;
            ReturnBppk.Click += ReturnBppk_Click;
            // 
            // ButtonBorrowBOOK
            // 
            ButtonBorrowBOOK.BackColor = Color.FromArgb(255, 128, 128);
            ButtonBorrowBOOK.Location = new Point(1004, 98);
            ButtonBorrowBOOK.Name = "ButtonBorrowBOOK";
            ButtonBorrowBOOK.Size = new Size(114, 48);
            ButtonBorrowBOOK.TabIndex = 9;
            ButtonBorrowBOOK.Text = "Borrow";
            ButtonBorrowBOOK.UseVisualStyleBackColor = false;
            ButtonBorrowBOOK.Click += ButtonBorrowBOOK_Click;
            // 
            // ButtonAddingNewBook
            // 
            ButtonAddingNewBook.BackColor = Color.FromArgb(255, 128, 255);
            ButtonAddingNewBook.Location = new Point(66, 73);
            ButtonAddingNewBook.Name = "ButtonAddingNewBook";
            ButtonAddingNewBook.Size = new Size(170, 40);
            ButtonAddingNewBook.TabIndex = 10;
            ButtonAddingNewBook.Text = "Add Item OR Edit Item";
            ButtonAddingNewBook.UseVisualStyleBackColor = false;
            ButtonAddingNewBook.Click += ButtonAddingNewBook_Click;
            // 
            // BtnSeacrh
            // 
            BtnSeacrh.Location = new Point(692, 82);
            BtnSeacrh.Name = "BtnSeacrh";
            BtnSeacrh.Size = new Size(104, 23);
            BtnSeacrh.TabIndex = 11;
            BtnSeacrh.Text = "Search book";
            BtnSeacrh.UseVisualStyleBackColor = true;
            BtnSeacrh.Click += BtnSeacrh_Click;
            // 
            // ResetSearch
            // 
            ResetSearch.Location = new Point(692, 49);
            ResetSearch.Name = "ResetSearch";
            ResetSearch.Size = new Size(104, 23);
            ResetSearch.TabIndex = 12;
            ResetSearch.Text = "Reset Serach";
            ResetSearch.UseVisualStyleBackColor = true;
            ResetSearch.Click += ResetSearch_Click;
            // 
            // BorrowBookList
            // 
            BorrowBookList.FormattingEnabled = true;
            BorrowBookList.ItemHeight = 15;
            BorrowBookList.Location = new Point(1088, 216);
            BorrowBookList.Name = "BorrowBookList";
            BorrowBookList.Size = new Size(261, 409);
            BorrowBookList.TabIndex = 13;
            BorrowBookList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // BookDetailsbox
            // 
            BookDetailsbox.FormattingEnabled = true;
            BookDetailsbox.ItemHeight = 15;
            BookDetailsbox.Location = new Point(271, 485);
            BookDetailsbox.Name = "BookDetailsbox";
            BookDetailsbox.Size = new Size(185, 169);
            BookDetailsbox.TabIndex = 16;
            BookDetailsbox.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 227);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 17;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1311, 198);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 18;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1107, 198);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 19;
            label3.Text = "Borrow Item Report";
            // 
            // booklabel
            // 
            booklabel.AutoSize = true;
            booklabel.Location = new Point(5, 216);
            booklabel.Name = "booklabel";
            booklabel.Size = new Size(108, 15);
            booklabel.TabIndex = 20;
            booklabel.Text = "Book Count Report";
            // 
            // Detailsitem
            // 
            Detailsitem.AutoSize = true;
            Detailsitem.Location = new Point(271, 467);
            Detailsitem.Name = "Detailsitem";
            Detailsitem.Size = new Size(105, 15);
            Detailsitem.TabIndex = 21;
            Detailsitem.Text = "Details Of the Item";
            // 
            // TextBoxDis
            // 
            TextBoxDis.Location = new Point(802, 485);
            TextBoxDis.Name = "TextBoxDis";
            TextBoxDis.Size = new Size(100, 23);
            TextBoxDis.TabIndex = 22;
            // 
            // TypeTextBox
            // 
            TypeTextBox.Location = new Point(802, 436);
            TypeTextBox.Name = "TypeTextBox";
            TypeTextBox.Size = new Size(100, 23);
            TypeTextBox.TabIndex = 23;
            // 
            // Typelabel
            // 
            Typelabel.AutoSize = true;
            Typelabel.Location = new Point(710, 439);
            Typelabel.Name = "Typelabel";
            Typelabel.Size = new Size(72, 15);
            Typelabel.TabIndex = 24;
            Typelabel.Text = "Type choose";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(729, 493);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 25;
            label4.Text = "discount";
            // 
            // Applay
            // 
            Applay.Location = new Point(827, 528);
            Applay.Name = "Applay";
            Applay.Size = new Size(75, 23);
            Applay.TabIndex = 26;
            Applay.Text = "aplay dis";
            Applay.UseVisualStyleBackColor = true;
            Applay.Click += Applay_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(827, 395);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 27;
            label6.Text = "Discount ";
            // 
            // EmpolyeeLogInPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 766);
            Controls.Add(label6);
            Controls.Add(Applay);
            Controls.Add(label4);
            Controls.Add(Typelabel);
            Controls.Add(TypeTextBox);
            Controls.Add(TextBoxDis);
            Controls.Add(Detailsitem);
            Controls.Add(booklabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BookDetailsbox);
            Controls.Add(BorrowBookList);
            Controls.Add(ResetSearch);
            Controls.Add(BtnSeacrh);
            Controls.Add(ButtonAddingNewBook);
            Controls.Add(ButtonBorrowBOOK);
            Controls.Add(ReturnBppk);
            Controls.Add(ButtonBackToMenu);
            Controls.Add(DeleteBook);
            Controls.Add(TextBoxForSearchingBook);
            Controls.Add(ListBoxForBookSearch);
            Controls.Add(LabelHelloEmpolyee);
            Controls.Add(LabelSerachBook);
            Name = "EmpolyeeLogInPage";
            Text = "EmpolyeeLogInPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelSerachBook;
        private Label LabelHelloEmpolyee;
        private ListBox ListBoxForBookSearch;
        private TextBox TextBoxForSearchingBook;
        private Button ButtonEDITBook;
        private Button DeleteBook;
        private Button ButtonBackToMenu;
        private Button ReturnBppk;
        private Button ButtonBorrowBOOK;
        private Button ButtonAddingNewBook;
        private Button BtnSeacrh;
        private Button ResetSearch;
        private ListBox BorrowBookList;
        private ListBox BookDetailsbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label booklabel;
        private Label Detailsitem;
        private Label label5;
        private ListBox listboxfordiscountitem;
        private TextBox TextBoxDis;
        private TextBox TypeTextBox;
        private Label Typelabel;
        private Label label4;
        private Button Applay;
        private Label label6;
    }
}