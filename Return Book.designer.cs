namespace SA_Team10bCAProject
{
    partial class Return_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return_Book));
            this.label1 = new System.Windows.Forms.Label();
            this.lab_mem_id = new System.Windows.Forms.Label();
            this.txtmemid1 = new System.Windows.Forms.TextBox();
            this.lab_book_id = new System.Windows.Forms.Label();
            this.txtbookid1 = new System.Windows.Forms.TextBox();
            this.lab_book_title = new System.Windows.Forms.Label();
            this.txtbooktile1 = new System.Windows.Forms.TextBox();
            this.lab_ret_date = new System.Windows.Forms.Label();
            this.btn_ret_book = new System.Windows.Forms.Button();
            this.btncan = new System.Windows.Forms.Button();
            this.ReturnDateTextBox = new System.Windows.Forms.TextBox();
            this.TransIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransIDnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to The Bookoholics Library";
            // 
            // lab_mem_id
            // 
            this.lab_mem_id.AutoSize = true;
            this.lab_mem_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_mem_id.Location = new System.Drawing.Point(393, 151);
            this.lab_mem_id.Name = "lab_mem_id";
            this.lab_mem_id.Size = new System.Drawing.Size(81, 18);
            this.lab_mem_id.TabIndex = 6;
            this.lab_mem_id.Text = "Member ID";
            // 
            // txtmemid1
            // 
            this.txtmemid1.Location = new System.Drawing.Point(506, 148);
            this.txtmemid1.Name = "txtmemid1";
            this.txtmemid1.ReadOnly = true;
            this.txtmemid1.Size = new System.Drawing.Size(165, 22);
            this.txtmemid1.TabIndex = 11;
            // 
            // lab_book_id
            // 
            this.lab_book_id.AutoSize = true;
            this.lab_book_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_book_id.Location = new System.Drawing.Point(413, 201);
            this.lab_book_id.Name = "lab_book_id";
            this.lab_book_id.Size = new System.Drawing.Size(62, 18);
            this.lab_book_id.TabIndex = 12;
            this.lab_book_id.Text = "Book ID";
            // 
            // txtbookid1
            // 
            this.txtbookid1.Location = new System.Drawing.Point(506, 201);
            this.txtbookid1.Name = "txtbookid1";
            this.txtbookid1.ReadOnly = true;
            this.txtbookid1.Size = new System.Drawing.Size(165, 22);
            this.txtbookid1.TabIndex = 13;
            // 
            // lab_book_title
            // 
            this.lab_book_title.AutoSize = true;
            this.lab_book_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_book_title.Location = new System.Drawing.Point(397, 256);
            this.lab_book_title.Name = "lab_book_title";
            this.lab_book_title.Size = new System.Drawing.Size(75, 18);
            this.lab_book_title.TabIndex = 14;
            this.lab_book_title.Text = "Book Title";
            // 
            // txtbooktile1
            // 
            this.txtbooktile1.Location = new System.Drawing.Point(506, 255);
            this.txtbooktile1.Name = "txtbooktile1";
            this.txtbooktile1.ReadOnly = true;
            this.txtbooktile1.Size = new System.Drawing.Size(165, 22);
            this.txtbooktile1.TabIndex = 15;
            // 
            // lab_ret_date
            // 
            this.lab_ret_date.AutoSize = true;
            this.lab_ret_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ret_date.Location = new System.Drawing.Point(387, 311);
            this.lab_ret_date.Name = "lab_ret_date";
            this.lab_ret_date.Size = new System.Drawing.Size(87, 18);
            this.lab_ret_date.TabIndex = 18;
            this.lab_ret_date.Text = "Return Date";
            // 
            // btn_ret_book
            // 
            this.btn_ret_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ret_book.Location = new System.Drawing.Point(420, 375);
            this.btn_ret_book.Name = "btn_ret_book";
            this.btn_ret_book.Size = new System.Drawing.Size(101, 30);
            this.btn_ret_book.TabIndex = 20;
            this.btn_ret_book.Text = "Return Book";
            this.btn_ret_book.UseVisualStyleBackColor = true;
            this.btn_ret_book.Click += new System.EventHandler(this.btn_ret_book_Click);
            // 
            // btncan
            // 
            this.btncan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncan.Location = new System.Drawing.Point(570, 375);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(101, 30);
            this.btncan.TabIndex = 29;
            this.btncan.Text = "Cancel";
            this.btncan.UseVisualStyleBackColor = true;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // ReturnDateTextBox
            // 
            this.ReturnDateTextBox.Location = new System.Drawing.Point(506, 311);
            this.ReturnDateTextBox.Name = "ReturnDateTextBox";
            this.ReturnDateTextBox.ReadOnly = true;
            this.ReturnDateTextBox.Size = new System.Drawing.Size(165, 22);
            this.ReturnDateTextBox.TabIndex = 30;
            // 
            // TransIDnumericUpDown
            // 
            this.TransIDnumericUpDown.Location = new System.Drawing.Point(506, 96);
            this.TransIDnumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.TransIDnumericUpDown.Name = "TransIDnumericUpDown";
            this.TransIDnumericUpDown.Size = new System.Drawing.Size(165, 22);
            this.TransIDnumericUpDown.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Transaction ID";
            // 
            // Return_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransIDnumericUpDown);
            this.Controls.Add(this.ReturnDateTextBox);
            this.Controls.Add(this.btncan);
            this.Controls.Add(this.btn_ret_book);
            this.Controls.Add(this.lab_ret_date);
            this.Controls.Add(this.txtbooktile1);
            this.Controls.Add(this.lab_book_title);
            this.Controls.Add(this.txtbookid1);
            this.Controls.Add(this.lab_book_id);
            this.Controls.Add(this.txtmemid1);
            this.Controls.Add(this.lab_mem_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Return_Book";
            this.Text = "Return Book";
            ((System.ComponentModel.ISupportInitialize)(this.TransIDnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_mem_id;
        private System.Windows.Forms.TextBox txtmemid1;
        private System.Windows.Forms.Label lab_book_id;
        private System.Windows.Forms.TextBox txtbookid1;
        private System.Windows.Forms.Label lab_book_title;
        private System.Windows.Forms.TextBox txtbooktile1;
        private System.Windows.Forms.Label lab_ret_date;
        private System.Windows.Forms.Button btn_ret_book;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.TextBox ReturnDateTextBox;
        private System.Windows.Forms.NumericUpDown TransIDnumericUpDown;
        private System.Windows.Forms.Label label2;
    }
}

