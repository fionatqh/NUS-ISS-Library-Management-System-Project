namespace SA_Team10bCAProject
{
    partial class BookMaintain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookMaintain));
            this.label1 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.AuthorBox = new System.Windows.Forms.TextBox();
            this.publisherBox = new System.Windows.Forms.TextBox();
            this.EditionBox = new System.Windows.Forms.TextBox();
            this.Book_NameBox = new System.Windows.Forms.TextBox();
            this.Number_Borrowed = new System.Windows.Forms.Label();
            this.Total_Quantity = new System.Windows.Forms.Label();
            this.Edition = new System.Windows.Forms.Label();
            this.Publisher = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Book_Name = new System.Windows.Forms.Label();
            this.Book_ID = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Retrieve_Book = new System.Windows.Forms.Button();
            this.BookRetrieveNumeric = new System.Windows.Forms.NumericUpDown();
            this.Total_QuantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.Number_BorrowedNumeric = new System.Windows.Forms.NumericUpDown();
            this.Category = new System.Windows.Forms.Label();
            this.CategoryBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BookRetrieveNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_QuantityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number_BorrowedNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to The Bookoholics Library";
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Gainsboro;
            this.Update.Location = new System.Drawing.Point(316, 380);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(117, 28);
            this.Update.TabIndex = 38;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Gainsboro;
            this.Delete.Location = new System.Drawing.Point(625, 380);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(117, 28);
            this.Delete.TabIndex = 37;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Gainsboro;
            this.Add.Location = new System.Drawing.Point(465, 380);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(117, 28);
            this.Add.TabIndex = 36;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AuthorBox
            // 
            this.AuthorBox.Location = new System.Drawing.Point(133, 175);
            this.AuthorBox.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Size = new System.Drawing.Size(217, 22);
            this.AuthorBox.TabIndex = 35;
            // 
            // publisherBox
            // 
            this.publisherBox.Location = new System.Drawing.Point(133, 227);
            this.publisherBox.Margin = new System.Windows.Forms.Padding(4);
            this.publisherBox.Name = "publisherBox";
            this.publisherBox.Size = new System.Drawing.Size(217, 22);
            this.publisherBox.TabIndex = 34;
            // 
            // EditionBox
            // 
            this.EditionBox.Location = new System.Drawing.Point(539, 133);
            this.EditionBox.Margin = new System.Windows.Forms.Padding(4);
            this.EditionBox.Name = "EditionBox";
            this.EditionBox.Size = new System.Drawing.Size(217, 22);
            this.EditionBox.TabIndex = 31;
            // 
            // Book_NameBox
            // 
            this.Book_NameBox.Location = new System.Drawing.Point(133, 133);
            this.Book_NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.Book_NameBox.Name = "Book_NameBox";
            this.Book_NameBox.Size = new System.Drawing.Size(217, 22);
            this.Book_NameBox.TabIndex = 30;
            // 
            // Number_Borrowed
            // 
            this.Number_Borrowed.AutoSize = true;
            this.Number_Borrowed.BackColor = System.Drawing.SystemColors.Control;
            this.Number_Borrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Borrowed.Location = new System.Drawing.Point(395, 230);
            this.Number_Borrowed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Number_Borrowed.Name = "Number_Borrowed";
            this.Number_Borrowed.Size = new System.Drawing.Size(113, 18);
            this.Number_Borrowed.TabIndex = 29;
            this.Number_Borrowed.Text = "No. Borrowed";
            // 
            // Total_Quantity
            // 
            this.Total_Quantity.AutoSize = true;
            this.Total_Quantity.BackColor = System.Drawing.SystemColors.Control;
            this.Total_Quantity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Total_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Quantity.Location = new System.Drawing.Point(441, 180);
            this.Total_Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Total_Quantity.Name = "Total_Quantity";
            this.Total_Quantity.Size = new System.Drawing.Size(70, 18);
            this.Total_Quantity.TabIndex = 28;
            this.Total_Quantity.Text = "Quantity";
            // 
            // Edition
            // 
            this.Edition.AutoSize = true;
            this.Edition.BackColor = System.Drawing.SystemColors.Control;
            this.Edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edition.Location = new System.Drawing.Point(452, 138);
            this.Edition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Edition.Name = "Edition";
            this.Edition.Size = new System.Drawing.Size(60, 18);
            this.Edition.TabIndex = 27;
            this.Edition.Text = "Edition";
            // 
            // Publisher
            // 
            this.Publisher.AutoSize = true;
            this.Publisher.BackColor = System.Drawing.Color.Transparent;
            this.Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher.ForeColor = System.Drawing.Color.White;
            this.Publisher.Location = new System.Drawing.Point(43, 227);
            this.Publisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(78, 18);
            this.Publisher.TabIndex = 26;
            this.Publisher.Text = "Publisher";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.BackColor = System.Drawing.Color.Transparent;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.ForeColor = System.Drawing.Color.White;
            this.Author.Location = new System.Drawing.Point(58, 180);
            this.Author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(57, 18);
            this.Author.TabIndex = 25;
            this.Author.Text = "Author";
            // 
            // Book_Name
            // 
            this.Book_Name.AutoSize = true;
            this.Book_Name.BackColor = System.Drawing.Color.Transparent;
            this.Book_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Name.ForeColor = System.Drawing.Color.White;
            this.Book_Name.Location = new System.Drawing.Point(22, 133);
            this.Book_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Book_Name.Name = "Book_Name";
            this.Book_Name.Size = new System.Drawing.Size(85, 18);
            this.Book_Name.TabIndex = 24;
            this.Book_Name.Text = "Book Title";
            // 
            // Book_ID
            // 
            this.Book_ID.AutoSize = true;
            this.Book_ID.BackColor = System.Drawing.Color.Transparent;
            this.Book_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_ID.ForeColor = System.Drawing.Color.White;
            this.Book_ID.Location = new System.Drawing.Point(37, 81);
            this.Book_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.Size = new System.Drawing.Size(69, 18);
            this.Book_ID.TabIndex = 22;
            this.Book_ID.Text = "Book ID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(325, 77);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 28);
            this.button3.TabIndex = 21;
            this.button3.Text = "Display List";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Retrieve_Book
            // 
            this.Retrieve_Book.BackColor = System.Drawing.Color.Gainsboro;
            this.Retrieve_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retrieve_Book.Location = new System.Drawing.Point(465, 77);
            this.Retrieve_Book.Margin = new System.Windows.Forms.Padding(4);
            this.Retrieve_Book.Name = "Retrieve_Book";
            this.Retrieve_Book.Size = new System.Drawing.Size(117, 28);
            this.Retrieve_Book.TabIndex = 20;
            this.Retrieve_Book.Text = "Search";
            this.Retrieve_Book.UseVisualStyleBackColor = false;
            this.Retrieve_Book.Click += new System.EventHandler(this.Retrieve_Book_Click);
            // 
            // BookRetrieveNumeric
            // 
            this.BookRetrieveNumeric.Location = new System.Drawing.Point(133, 81);
            this.BookRetrieveNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.BookRetrieveNumeric.Name = "BookRetrieveNumeric";
            this.BookRetrieveNumeric.Size = new System.Drawing.Size(160, 22);
            this.BookRetrieveNumeric.TabIndex = 39;
            // 
            // Total_QuantityNumeric
            // 
            this.Total_QuantityNumeric.Location = new System.Drawing.Point(537, 180);
            this.Total_QuantityNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.Total_QuantityNumeric.Name = "Total_QuantityNumeric";
            this.Total_QuantityNumeric.Size = new System.Drawing.Size(219, 22);
            this.Total_QuantityNumeric.TabIndex = 40;
            // 
            // Number_BorrowedNumeric
            // 
            this.Number_BorrowedNumeric.BackColor = System.Drawing.Color.White;
            this.Number_BorrowedNumeric.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Number_BorrowedNumeric.InterceptArrowKeys = false;
            this.Number_BorrowedNumeric.Location = new System.Drawing.Point(537, 226);
            this.Number_BorrowedNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.Number_BorrowedNumeric.Name = "Number_BorrowedNumeric";
            this.Number_BorrowedNumeric.ReadOnly = true;
            this.Number_BorrowedNumeric.Size = new System.Drawing.Size(219, 22);
            this.Number_BorrowedNumeric.TabIndex = 41;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.BackColor = System.Drawing.Color.Transparent;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ForeColor = System.Drawing.Color.White;
            this.Category.Location = new System.Drawing.Point(44, 280);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(76, 18);
            this.Category.TabIndex = 42;
            this.Category.Text = "Category";
            // 
            // CategoryBox
            // 
            this.CategoryBox.Location = new System.Drawing.Point(133, 280);
            this.CategoryBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(217, 22);
            this.CategoryBox.TabIndex = 43;
            // 
            // BookMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 435);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Number_BorrowedNumeric);
            this.Controls.Add(this.Total_QuantityNumeric);
            this.Controls.Add(this.BookRetrieveNumeric);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AuthorBox);
            this.Controls.Add(this.publisherBox);
            this.Controls.Add(this.EditionBox);
            this.Controls.Add(this.Book_NameBox);
            this.Controls.Add(this.Number_Borrowed);
            this.Controls.Add(this.Total_Quantity);
            this.Controls.Add(this.Edition);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Book_Name);
            this.Controls.Add(this.Book_ID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Retrieve_Book);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookMaintain";
            this.Text = "Update Books";
            ((System.ComponentModel.ISupportInitialize)(this.BookRetrieveNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_QuantityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number_BorrowedNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox AuthorBox;
        private System.Windows.Forms.TextBox publisherBox;
        private System.Windows.Forms.TextBox EditionBox;
        private System.Windows.Forms.TextBox Book_NameBox;
        private System.Windows.Forms.Label Number_Borrowed;
        private System.Windows.Forms.Label Total_Quantity;
        private System.Windows.Forms.Label Edition;
        private System.Windows.Forms.Label Publisher;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Book_Name;
        private System.Windows.Forms.Label Book_ID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Retrieve_Book;
        private System.Windows.Forms.NumericUpDown BookRetrieveNumeric;
        private System.Windows.Forms.NumericUpDown Total_QuantityNumeric;
        private System.Windows.Forms.NumericUpDown Number_BorrowedNumeric;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.TextBox CategoryBox;
    }
}