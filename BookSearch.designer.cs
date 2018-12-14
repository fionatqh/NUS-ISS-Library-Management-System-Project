namespace SA_Team10bCAProject
{
    partial class BooksSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorBox = new System.Windows.Forms.TextBox();
            this.publisherBox = new System.Windows.Forms.TextBox();
            this.Number_BorrowedBox = new System.Windows.Forms.TextBox();
            this.Total_QuantityBox = new System.Windows.Forms.TextBox();
            this.EditionBox = new System.Windows.Forms.TextBox();
            this.Book_NameBox = new System.Windows.Forms.TextBox();
            this.Number_Borrowed = new System.Windows.Forms.Label();
            this.Total_Quantity = new System.Windows.Forms.Label();
            this.Edition = new System.Windows.Forms.Label();
            this.Publisher = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Book_Name = new System.Windows.Forms.Label();
            this.Book_ID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Retrieve_Book = new System.Windows.Forms.Button();
            this.Can_Borrow_Date = new System.Windows.Forms.Label();
            this.Can_Borrow_DateBox = new System.Windows.Forms.TextBox();
            this.Retrieve_BookNumeric = new System.Windows.Forms.NumericUpDown();
            this.Category = new System.Windows.Forms.Label();
            this.CategoryBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Retrieve_BookNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to The Bookoholics Library";
            // 
            // AuthorBox
            // 
            this.AuthorBox.BackColor = System.Drawing.Color.White;
            this.AuthorBox.Location = new System.Drawing.Point(159, 251);
            this.AuthorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.ReadOnly = true;
            this.AuthorBox.Size = new System.Drawing.Size(244, 26);
            this.AuthorBox.TabIndex = 32;
            // 
            // publisherBox
            // 
            this.publisherBox.BackColor = System.Drawing.Color.White;
            this.publisherBox.Location = new System.Drawing.Point(159, 305);
            this.publisherBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.publisherBox.Name = "publisherBox";
            this.publisherBox.ReadOnly = true;
            this.publisherBox.Size = new System.Drawing.Size(244, 26);
            this.publisherBox.TabIndex = 31;
            // 
            // Number_BorrowedBox
            // 
            this.Number_BorrowedBox.BackColor = System.Drawing.Color.White;
            this.Number_BorrowedBox.Location = new System.Drawing.Point(576, 311);
            this.Number_BorrowedBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Number_BorrowedBox.Name = "Number_BorrowedBox";
            this.Number_BorrowedBox.ReadOnly = true;
            this.Number_BorrowedBox.Size = new System.Drawing.Size(244, 26);
            this.Number_BorrowedBox.TabIndex = 30;
            // 
            // Total_QuantityBox
            // 
            this.Total_QuantityBox.BackColor = System.Drawing.Color.White;
            this.Total_QuantityBox.Location = new System.Drawing.Point(576, 257);
            this.Total_QuantityBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Total_QuantityBox.Name = "Total_QuantityBox";
            this.Total_QuantityBox.ReadOnly = true;
            this.Total_QuantityBox.Size = new System.Drawing.Size(244, 26);
            this.Total_QuantityBox.TabIndex = 29;
            // 
            // EditionBox
            // 
            this.EditionBox.BackColor = System.Drawing.Color.White;
            this.EditionBox.Location = new System.Drawing.Point(576, 204);
            this.EditionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditionBox.Name = "EditionBox";
            this.EditionBox.ReadOnly = true;
            this.EditionBox.Size = new System.Drawing.Size(244, 26);
            this.EditionBox.TabIndex = 28;
            // 
            // Book_NameBox
            // 
            this.Book_NameBox.BackColor = System.Drawing.Color.White;
            this.Book_NameBox.Location = new System.Drawing.Point(159, 198);
            this.Book_NameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Book_NameBox.Name = "Book_NameBox";
            this.Book_NameBox.ReadOnly = true;
            this.Book_NameBox.Size = new System.Drawing.Size(244, 26);
            this.Book_NameBox.TabIndex = 27;
            // 
            // Number_Borrowed
            // 
            this.Number_Borrowed.AutoSize = true;
            this.Number_Borrowed.BackColor = System.Drawing.SystemColors.Control;
            this.Number_Borrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Borrowed.Location = new System.Drawing.Point(430, 311);
            this.Number_Borrowed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Number_Borrowed.Name = "Number_Borrowed";
            this.Number_Borrowed.Size = new System.Drawing.Size(132, 22);
            this.Number_Borrowed.TabIndex = 26;
            this.Number_Borrowed.Text = "No. Borrowed";
            // 
            // Total_Quantity
            // 
            this.Total_Quantity.AutoSize = true;
            this.Total_Quantity.BackColor = System.Drawing.SystemColors.Control;
            this.Total_Quantity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Total_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Quantity.Location = new System.Drawing.Point(474, 258);
            this.Total_Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Total_Quantity.Name = "Total_Quantity";
            this.Total_Quantity.Size = new System.Drawing.Size(85, 22);
            this.Total_Quantity.TabIndex = 25;
            this.Total_Quantity.Text = "Quantity";
            // 
            // Edition
            // 
            this.Edition.AutoSize = true;
            this.Edition.BackColor = System.Drawing.SystemColors.Control;
            this.Edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edition.Location = new System.Drawing.Point(487, 204);
            this.Edition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Edition.Name = "Edition";
            this.Edition.Size = new System.Drawing.Size(72, 22);
            this.Edition.TabIndex = 24;
            this.Edition.Text = "Edition";
            // 
            // Publisher
            // 
            this.Publisher.AutoSize = true;
            this.Publisher.BackColor = System.Drawing.Color.Transparent;
            this.Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher.ForeColor = System.Drawing.Color.White;
            this.Publisher.Location = new System.Drawing.Point(31, 305);
            this.Publisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(94, 22);
            this.Publisher.TabIndex = 23;
            this.Publisher.Text = "Publisher";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.BackColor = System.Drawing.Color.Transparent;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.ForeColor = System.Drawing.Color.White;
            this.Author.Location = new System.Drawing.Point(41, 251);
            this.Author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(69, 22);
            this.Author.TabIndex = 22;
            this.Author.Text = "Author";
            // 
            // Book_Name
            // 
            this.Book_Name.AutoSize = true;
            this.Book_Name.BackColor = System.Drawing.Color.Transparent;
            this.Book_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Name.ForeColor = System.Drawing.Color.White;
            this.Book_Name.Location = new System.Drawing.Point(13, 198);
            this.Book_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Book_Name.Name = "Book_Name";
            this.Book_Name.Size = new System.Drawing.Size(101, 22);
            this.Book_Name.TabIndex = 21;
            this.Book_Name.Text = "Book Title";
            // 
            // Book_ID
            // 
            this.Book_ID.AutoSize = true;
            this.Book_ID.BackColor = System.Drawing.Color.Transparent;
            this.Book_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_ID.ForeColor = System.Drawing.Color.White;
            this.Book_ID.Location = new System.Drawing.Point(41, 148);
            this.Book_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.Size = new System.Drawing.Size(80, 22);
            this.Book_ID.TabIndex = 19;
            this.Book_ID.Text = "Book ID";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(386, 135);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "Display Books List";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Retrieve_Book
            // 
            this.Retrieve_Book.BackColor = System.Drawing.Color.Gainsboro;
            this.Retrieve_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retrieve_Book.Location = new System.Drawing.Point(650, 135);
            this.Retrieve_Book.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Retrieve_Book.Name = "Retrieve_Book";
            this.Retrieve_Book.Size = new System.Drawing.Size(170, 35);
            this.Retrieve_Book.TabIndex = 18;
            this.Retrieve_Book.Text = "Search";
            this.Retrieve_Book.UseVisualStyleBackColor = false;
            this.Retrieve_Book.Click += new System.EventHandler(this.Retrieve_Book_Click);
            // 
            // Can_Borrow_Date
            // 
            this.Can_Borrow_Date.AutoSize = true;
            this.Can_Borrow_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Can_Borrow_Date.Location = new System.Drawing.Point(452, 364);
            this.Can_Borrow_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Can_Borrow_Date.Name = "Can_Borrow_Date";
            this.Can_Borrow_Date.Size = new System.Drawing.Size(107, 22);
            this.Can_Borrow_Date.TabIndex = 33;
            this.Can_Borrow_Date.Text = "Availability";
            // 
            // Can_Borrow_DateBox
            // 
            this.Can_Borrow_DateBox.BackColor = System.Drawing.Color.White;
            this.Can_Borrow_DateBox.Location = new System.Drawing.Point(577, 366);
            this.Can_Borrow_DateBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Can_Borrow_DateBox.Name = "Can_Borrow_DateBox";
            this.Can_Borrow_DateBox.ReadOnly = true;
            this.Can_Borrow_DateBox.Size = new System.Drawing.Size(244, 26);
            this.Can_Borrow_DateBox.TabIndex = 34;
            // 
            // Retrieve_BookNumeric
            // 
            this.Retrieve_BookNumeric.Location = new System.Drawing.Point(159, 148);
            this.Retrieve_BookNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Retrieve_BookNumeric.Name = "Retrieve_BookNumeric";
            this.Retrieve_BookNumeric.Size = new System.Drawing.Size(180, 26);
            this.Retrieve_BookNumeric.TabIndex = 35;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.BackColor = System.Drawing.Color.Transparent;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ForeColor = System.Drawing.Color.White;
            this.Category.Location = new System.Drawing.Point(30, 358);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(91, 22);
            this.Category.TabIndex = 36;
            this.Category.Text = "Category";
            // 
            // CategoryBox
            // 
            this.CategoryBox.BackColor = System.Drawing.Color.White;
            this.CategoryBox.Location = new System.Drawing.Point(159, 360);
            this.CategoryBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.ReadOnly = true;
            this.CategoryBox.Size = new System.Drawing.Size(244, 26);
            this.CategoryBox.TabIndex = 37;
            // 
            // BooksSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Retrieve_BookNumeric);
            this.Controls.Add(this.Can_Borrow_DateBox);
            this.Controls.Add(this.Can_Borrow_Date);
            this.Controls.Add(this.AuthorBox);
            this.Controls.Add(this.publisherBox);
            this.Controls.Add(this.Number_BorrowedBox);
            this.Controls.Add(this.Total_QuantityBox);
            this.Controls.Add(this.EditionBox);
            this.Controls.Add(this.Book_NameBox);
            this.Controls.Add(this.Number_Borrowed);
            this.Controls.Add(this.Total_Quantity);
            this.Controls.Add(this.Edition);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Book_Name);
            this.Controls.Add(this.Book_ID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Retrieve_Book);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BooksSearch";
            this.Text = "BooksSearch";
            ((System.ComponentModel.ISupportInitialize)(this.Retrieve_BookNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AuthorBox;
        private System.Windows.Forms.TextBox publisherBox;
        private System.Windows.Forms.TextBox Number_BorrowedBox;
        private System.Windows.Forms.TextBox Total_QuantityBox;
        private System.Windows.Forms.TextBox EditionBox;
        private System.Windows.Forms.TextBox Book_NameBox;
        private System.Windows.Forms.Label Number_Borrowed;
        private System.Windows.Forms.Label Total_Quantity;
        private System.Windows.Forms.Label Edition;
        private System.Windows.Forms.Label Publisher;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Book_Name;
        private System.Windows.Forms.Label Book_ID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Retrieve_Book;
        private System.Windows.Forms.Label Can_Borrow_Date;
        private System.Windows.Forms.TextBox Can_Borrow_DateBox;
        private System.Windows.Forms.NumericUpDown Retrieve_BookNumeric;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.TextBox CategoryBox;
    }
}