namespace SA_Team10bCAProject
{
    partial class SearchMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMemberForm));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.MemListButton = new System.Windows.Forms.Button();
            this.MemberGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QtyBorrowedTextBox = new System.Windows.Forms.TextBox();
            this.BorrowRecButton = new System.Windows.Forms.Button();
            this.MemberNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.MemberNameTextBox = new System.Windows.Forms.TextBox();
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.MemIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MemberToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MemberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemIDNumericUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(327, 54);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(318, 20);
            this.WelcomeLabel.TabIndex = 4;
            this.WelcomeLabel.Text = "Welcome to The Bookoholics Library";
            // 
            // MemListButton
            // 
            this.MemListButton.AutoSize = true;
            this.MemListButton.BackColor = System.Drawing.Color.Gainsboro;
            this.MemListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemListButton.Location = new System.Drawing.Point(787, 97);
            this.MemListButton.Name = "MemListButton";
            this.MemListButton.Size = new System.Drawing.Size(80, 33);
            this.MemListButton.TabIndex = 21;
            this.MemListButton.Text = "List";
            this.MemListButton.UseVisualStyleBackColor = false;
            this.MemListButton.Click += new System.EventHandler(this.MemListButton_Click);
            // 
            // MemberGroupBox
            // 
            this.MemberGroupBox.Controls.Add(this.label2);
            this.MemberGroupBox.Controls.Add(this.QtyBorrowedTextBox);
            this.MemberGroupBox.Controls.Add(this.BorrowRecButton);
            this.MemberGroupBox.Controls.Add(this.MemberNameLabel);
            this.MemberGroupBox.Controls.Add(this.PhoneNumLabel);
            this.MemberGroupBox.Controls.Add(this.AddressTextBox);
            this.MemberGroupBox.Controls.Add(this.AddressLabel);
            this.MemberGroupBox.Controls.Add(this.PhoneNumberTextBox);
            this.MemberGroupBox.Controls.Add(this.MemberNameTextBox);
            this.MemberGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberGroupBox.Location = new System.Drawing.Point(305, 157);
            this.MemberGroupBox.Name = "MemberGroupBox";
            this.MemberGroupBox.Size = new System.Drawing.Size(565, 362);
            this.MemberGroupBox.TabIndex = 20;
            this.MemberGroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quantity of Books Borrowed:";
            // 
            // QtyBorrowedTextBox
            // 
            this.QtyBorrowedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyBorrowedTextBox.Location = new System.Drawing.Point(253, 261);
            this.QtyBorrowedTextBox.Name = "QtyBorrowedTextBox";
            this.QtyBorrowedTextBox.ReadOnly = true;
            this.QtyBorrowedTextBox.Size = new System.Drawing.Size(262, 24);
            this.QtyBorrowedTextBox.TabIndex = 4;
            // 
            // BorrowRecButton
            // 
            this.BorrowRecButton.BackColor = System.Drawing.Color.Gainsboro;
            this.BorrowRecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowRecButton.Location = new System.Drawing.Point(365, 308);
            this.BorrowRecButton.Name = "BorrowRecButton";
            this.BorrowRecButton.Size = new System.Drawing.Size(150, 33);
            this.BorrowRecButton.TabIndex = 19;
            this.BorrowRecButton.Text = "Borrow Record";
            this.BorrowRecButton.UseVisualStyleBackColor = false;
            this.BorrowRecButton.Click += new System.EventHandler(this.BorrowRecButton_Click);
            // 
            // MemberNameLabel
            // 
            this.MemberNameLabel.AutoSize = true;
            this.MemberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNameLabel.Location = new System.Drawing.Point(16, 41);
            this.MemberNameLabel.Name = "MemberNameLabel";
            this.MemberNameLabel.Size = new System.Drawing.Size(111, 18);
            this.MemberNameLabel.TabIndex = 6;
            this.MemberNameLabel.Text = "Member Name:";
            // 
            // PhoneNumLabel
            // 
            this.PhoneNumLabel.AutoSize = true;
            this.PhoneNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumLabel.Location = new System.Drawing.Point(16, 91);
            this.PhoneNumLabel.Name = "PhoneNumLabel";
            this.PhoneNumLabel.Size = new System.Drawing.Size(112, 18);
            this.PhoneNumLabel.TabIndex = 7;
            this.PhoneNumLabel.Text = "Phone Number:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBox.Location = new System.Drawing.Point(253, 138);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.ReadOnly = true;
            this.AddressTextBox.Size = new System.Drawing.Size(262, 96);
            this.AddressTextBox.TabIndex = 3;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(16, 141);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(66, 18);
            this.AddressLabel.TabIndex = 8;
            this.AddressLabel.Text = "Address:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(253, 88);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.ReadOnly = true;
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(262, 24);
            this.PhoneNumberTextBox.TabIndex = 2;
            // 
            // MemberNameTextBox
            // 
            this.MemberNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNameTextBox.Location = new System.Drawing.Point(253, 38);
            this.MemberNameTextBox.Name = "MemberNameTextBox";
            this.MemberNameTextBox.ReadOnly = true;
            this.MemberNameTextBox.Size = new System.Drawing.Size(262, 24);
            this.MemberNameTextBox.TabIndex = 1;
            // 
            // RetrieveButton
            // 
            this.RetrieveButton.BackColor = System.Drawing.Color.Gainsboro;
            this.RetrieveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrieveButton.Location = new System.Drawing.Point(694, 97);
            this.RetrieveButton.Name = "RetrieveButton";
            this.RetrieveButton.Size = new System.Drawing.Size(80, 33);
            this.RetrieveButton.TabIndex = 19;
            this.RetrieveButton.Text = "Retrieve";
            this.RetrieveButton.UseVisualStyleBackColor = false;
            this.RetrieveButton.Click += new System.EventHandler(this.RetrieveButton_Click);
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.AutoSize = true;
            this.MemberIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDLabel.Location = new System.Drawing.Point(321, 104);
            this.MemberIDLabel.Name = "MemberIDLabel";
            this.MemberIDLabel.Size = new System.Drawing.Size(85, 18);
            this.MemberIDLabel.TabIndex = 17;
            this.MemberIDLabel.Text = "Member ID:";
            // 
            // MemIDNumericUpDown
            // 
            this.MemIDNumericUpDown.Location = new System.Drawing.Point(558, 104);
            this.MemIDNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MemIDNumericUpDown.Name = "MemIDNumericUpDown";
            this.MemIDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.MemIDNumericUpDown.TabIndex = 23;
            this.MemIDNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MemIDNumericUpDown_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MemberToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(882, 25);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MemberToolStripStatusLabel
            // 
            this.MemberToolStripStatusLabel.Name = "MemberToolStripStatusLabel";
            this.MemberToolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.MemberToolStripStatusLabel.Text = "Status";
            // 
            // SearchMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MemIDNumericUpDown);
            this.Controls.Add(this.MemListButton);
            this.Controls.Add(this.MemberGroupBox);
            this.Controls.Add(this.RetrieveButton);
            this.Controls.Add(this.MemberIDLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SearchMemberForm";
            this.Text = "Search Member";
            this.Load += new System.EventHandler(this.SearchMemberForm_Load);
            this.MemberGroupBox.ResumeLayout(false);
            this.MemberGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemIDNumericUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button MemListButton;
        private System.Windows.Forms.GroupBox MemberGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QtyBorrowedTextBox;
        private System.Windows.Forms.Button BorrowRecButton;
        private System.Windows.Forms.Label MemberNameLabel;
        private System.Windows.Forms.Label PhoneNumLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox MemberNameTextBox;
        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.Label MemberIDLabel;
        private System.Windows.Forms.NumericUpDown MemIDNumericUpDown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MemberToolStripStatusLabel;
    }
}

