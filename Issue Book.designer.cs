namespace SA_Team10bCAProject
{
    partial class Issue_Book
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issue_Book));
            this.label1 = new System.Windows.Forms.Label();
            this.lab_mem_id = new System.Windows.Forms.Label();
            this.txtmemid = new System.Windows.Forms.TextBox();
            this.lab_book_id = new System.Windows.Forms.Label();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.lab_book_title = new System.Windows.Forms.Label();
            this.txtbooktitle = new System.Windows.Forms.TextBox();
            this.lab_iss_date = new System.Windows.Forms.Label();
            this.lab_exp_date = new System.Windows.Forms.Label();
            this.Remar = new System.Windows.Forms.Label();
            this.txtremk = new System.Windows.Forms.TextBox();
            this.btn_iss_book = new System.Windows.Forms.Button();
            this.btn_mem = new System.Windows.Forms.Button();
            this.btn_bookid = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_can = new System.Windows.Forms.Button();
            this.IssueDateTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to The Bookoholics Library";
            // 
            // lab_mem_id
            // 
            this.lab_mem_id.AutoSize = true;
            this.lab_mem_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_mem_id.Location = new System.Drawing.Point(342, 127);
            this.lab_mem_id.Name = "lab_mem_id";
            this.lab_mem_id.Size = new System.Drawing.Size(81, 18);
            this.lab_mem_id.TabIndex = 7;
            this.lab_mem_id.Text = "Member ID";
            // 
            // txtmemid
            // 
            this.txtmemid.Location = new System.Drawing.Point(448, 126);
            this.txtmemid.Name = "txtmemid";
            this.txtmemid.Size = new System.Drawing.Size(165, 22);
            this.txtmemid.TabIndex = 12;
            // 
            // lab_book_id
            // 
            this.lab_book_id.AutoSize = true;
            this.lab_book_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_book_id.Location = new System.Drawing.Point(342, 181);
            this.lab_book_id.Name = "lab_book_id";
            this.lab_book_id.Size = new System.Drawing.Size(62, 18);
            this.lab_book_id.TabIndex = 13;
            this.lab_book_id.Text = "Book ID";
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(448, 177);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(165, 22);
            this.txtbookid.TabIndex = 14;
            this.txtbookid.Leave += new System.EventHandler(this.txtbookid_Leave);
            // 
            // lab_book_title
            // 
            this.lab_book_title.AutoSize = true;
            this.lab_book_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_book_title.Location = new System.Drawing.Point(342, 240);
            this.lab_book_title.Name = "lab_book_title";
            this.lab_book_title.Size = new System.Drawing.Size(75, 18);
            this.lab_book_title.TabIndex = 15;
            this.lab_book_title.Text = "Book Title";
            // 
            // txtbooktitle
            // 
            this.txtbooktitle.Location = new System.Drawing.Point(448, 236);
            this.txtbooktitle.Name = "txtbooktitle";
            this.txtbooktitle.ReadOnly = true;
            this.txtbooktitle.Size = new System.Drawing.Size(165, 22);
            this.txtbooktitle.TabIndex = 16;
            // 
            // lab_iss_date
            // 
            this.lab_iss_date.AutoSize = true;
            this.lab_iss_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_iss_date.Location = new System.Drawing.Point(342, 298);
            this.lab_iss_date.Name = "lab_iss_date";
            this.lab_iss_date.Size = new System.Drawing.Size(78, 18);
            this.lab_iss_date.TabIndex = 19;
            this.lab_iss_date.Text = "Issue Date";
            // 
            // lab_exp_date
            // 
            this.lab_exp_date.AutoSize = true;
            this.lab_exp_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_exp_date.Location = new System.Drawing.Point(342, 349);
            this.lab_exp_date.Name = "lab_exp_date";
            this.lab_exp_date.Size = new System.Drawing.Size(83, 18);
            this.lab_exp_date.TabIndex = 21;
            this.lab_exp_date.Text = "Expiry Date";
            // 
            // Remar
            // 
            this.Remar.AutoSize = true;
            this.Remar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remar.Location = new System.Drawing.Point(342, 402);
            this.Remar.Name = "Remar";
            this.Remar.Size = new System.Drawing.Size(69, 18);
            this.Remar.TabIndex = 23;
            this.Remar.Text = "Remarks";
            // 
            // txtremk
            // 
            this.txtremk.Location = new System.Drawing.Point(448, 402);
            this.txtremk.Multiline = true;
            this.txtremk.Name = "txtremk";
            this.txtremk.Size = new System.Drawing.Size(165, 103);
            this.txtremk.TabIndex = 24;
            // 
            // btn_iss_book
            // 
            this.btn_iss_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iss_book.Location = new System.Drawing.Point(646, 478);
            this.btn_iss_book.Name = "btn_iss_book";
            this.btn_iss_book.Size = new System.Drawing.Size(97, 27);
            this.btn_iss_book.TabIndex = 25;
            this.btn_iss_book.Text = "Issue Book";
            this.btn_iss_book.UseVisualStyleBackColor = true;
            this.btn_iss_book.Click += new System.EventHandler(this.btn_iss_book_Click);
            this.btn_iss_book.MouseLeave += new System.EventHandler(this.btn_iss_book_MouseLeave);
            this.btn_iss_book.MouseHover += new System.EventHandler(this.btn_iss_book_MouseHover);
            // 
            // btn_mem
            // 
            this.btn_mem.AutoSize = true;
            this.btn_mem.Location = new System.Drawing.Point(629, 126);
            this.btn_mem.Name = "btn_mem";
            this.btn_mem.Size = new System.Drawing.Size(30, 27);
            this.btn_mem.TabIndex = 26;
            this.btn_mem.Text = "...";
            this.toolTip1.SetToolTip(this.btn_mem, "Search for Members");
            this.btn_mem.UseVisualStyleBackColor = true;
            this.btn_mem.Click += new System.EventHandler(this.btn_mem_Click);
            // 
            // btn_bookid
            // 
            this.btn_bookid.AutoSize = true;
            this.btn_bookid.Location = new System.Drawing.Point(629, 172);
            this.btn_bookid.Name = "btn_bookid";
            this.btn_bookid.Size = new System.Drawing.Size(30, 27);
            this.btn_bookid.TabIndex = 27;
            this.btn_bookid.Text = "...";
            this.toolTip2.SetToolTip(this.btn_bookid, "Search for Books");
            this.btn_bookid.UseVisualStyleBackColor = true;
            this.btn_bookid.Click += new System.EventHandler(this.btn_bookid_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Lavender;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(882, 25);
            this.statusStrip1.TabIndex = 28;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel2.Text = " ";
            // 
            // btn_can
            // 
            this.btn_can.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_can.Location = new System.Drawing.Point(763, 478);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(97, 27);
            this.btn_can.TabIndex = 29;
            this.btn_can.Text = "Cancel";
            this.btn_can.UseVisualStyleBackColor = true;
            this.btn_can.Click += new System.EventHandler(this.btn_can_Click);
            // 
            // IssueDateTextBox
            // 
            this.IssueDateTextBox.Location = new System.Drawing.Point(448, 298);
            this.IssueDateTextBox.Name = "IssueDateTextBox";
            this.IssueDateTextBox.ReadOnly = true;
            this.IssueDateTextBox.Size = new System.Drawing.Size(165, 22);
            this.IssueDateTextBox.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(448, 346);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 22);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.Value = new System.DateTime(2018, 9, 28, 15, 40, 19, 0);
            // 
            // Issue_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.IssueDateTextBox);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_bookid);
            this.Controls.Add(this.btn_mem);
            this.Controls.Add(this.btn_iss_book);
            this.Controls.Add(this.txtremk);
            this.Controls.Add(this.Remar);
            this.Controls.Add(this.lab_exp_date);
            this.Controls.Add(this.lab_iss_date);
            this.Controls.Add(this.txtbooktitle);
            this.Controls.Add(this.lab_book_title);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.lab_book_id);
            this.Controls.Add(this.txtmemid);
            this.Controls.Add(this.lab_mem_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Issue_Book";
            this.Text = "Issue Book";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_mem_id;
        private System.Windows.Forms.TextBox txtmemid;
        private System.Windows.Forms.Label lab_book_id;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.Label lab_book_title;
        private System.Windows.Forms.TextBox txtbooktitle;
        private System.Windows.Forms.Label lab_iss_date;
        private System.Windows.Forms.Label lab_exp_date;
        private System.Windows.Forms.Label Remar;
        private System.Windows.Forms.TextBox txtremk;
        private System.Windows.Forms.Button btn_iss_book;
        private System.Windows.Forms.Button btn_mem;
        private System.Windows.Forms.Button btn_bookid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.TextBox IssueDateTextBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

