namespace SA_Team10bCAProject
{
    partial class UpdateMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMemberForm));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.MemberGroupBox = new System.Windows.Forms.GroupBox();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.QtyBorrowedTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MemberNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.MemberNameTextBox = new System.Windows.Forms.TextBox();
            this.MemIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MemListButton = new System.Windows.Forms.Button();
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.MemberStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MemberToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MemberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemIDNumericUpDown)).BeginInit();
            this.MemberStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(368, 68);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(397, 25);
            this.WelcomeLabel.TabIndex = 4;
            this.WelcomeLabel.Text = "Welcome to The Bookoholics Library";
            // 
            // MemberGroupBox
            // 
            this.MemberGroupBox.Controls.Add(this.PhoneMaskedTextBox);
            this.MemberGroupBox.Controls.Add(this.QtyBorrowedTextBox);
            this.MemberGroupBox.Controls.Add(this.AddButton);
            this.MemberGroupBox.Controls.Add(this.DeleteButton);
            this.MemberGroupBox.Controls.Add(this.UpdateButton);
            this.MemberGroupBox.Controls.Add(this.label2);
            this.MemberGroupBox.Controls.Add(this.MemberNameLabel);
            this.MemberGroupBox.Controls.Add(this.PhoneNumLabel);
            this.MemberGroupBox.Controls.Add(this.AddressTextBox);
            this.MemberGroupBox.Controls.Add(this.AddressLabel);
            this.MemberGroupBox.Controls.Add(this.MemberNameTextBox);
            this.MemberGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberGroupBox.Location = new System.Drawing.Point(343, 198);
            this.MemberGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemberGroupBox.Name = "MemberGroupBox";
            this.MemberGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemberGroupBox.Size = new System.Drawing.Size(636, 452);
            this.MemberGroupBox.TabIndex = 20;
            this.MemberGroupBox.TabStop = false;
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(285, 110);
            this.PhoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneMaskedTextBox.Mask = "00000000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(294, 28);
            this.PhoneMaskedTextBox.TabIndex = 26;
            // 
            // QtyBorrowedTextBox
            // 
            this.QtyBorrowedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyBorrowedTextBox.Location = new System.Drawing.Point(285, 326);
            this.QtyBorrowedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QtyBorrowedTextBox.Name = "QtyBorrowedTextBox";
            this.QtyBorrowedTextBox.ReadOnly = true;
            this.QtyBorrowedTextBox.Size = new System.Drawing.Size(294, 28);
            this.QtyBorrowedTextBox.TabIndex = 25;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(332, 385);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 41);
            this.AddButton.TabIndex = 24;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Gainsboro;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(469, 385);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(110, 41);
            this.DeleteButton.TabIndex = 23;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Gainsboro;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(192, 385);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(110, 41);
            this.UpdateButton.TabIndex = 22;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quantity of Books Borrowed:";
            // 
            // MemberNameLabel
            // 
            this.MemberNameLabel.AutoSize = true;
            this.MemberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNameLabel.Location = new System.Drawing.Point(18, 51);
            this.MemberNameLabel.Name = "MemberNameLabel";
            this.MemberNameLabel.Size = new System.Drawing.Size(131, 22);
            this.MemberNameLabel.TabIndex = 6;
            this.MemberNameLabel.Text = "Member Name:";
            // 
            // PhoneNumLabel
            // 
            this.PhoneNumLabel.AutoSize = true;
            this.PhoneNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumLabel.Location = new System.Drawing.Point(18, 114);
            this.PhoneNumLabel.Name = "PhoneNumLabel";
            this.PhoneNumLabel.Size = new System.Drawing.Size(135, 22);
            this.PhoneNumLabel.TabIndex = 7;
            this.PhoneNumLabel.Text = "Phone Number:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBox.Location = new System.Drawing.Point(285, 172);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(294, 119);
            this.AddressTextBox.TabIndex = 3;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(18, 176);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(81, 22);
            this.AddressLabel.TabIndex = 8;
            this.AddressLabel.Text = "Address:";
            // 
            // MemberNameTextBox
            // 
            this.MemberNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNameTextBox.Location = new System.Drawing.Point(285, 48);
            this.MemberNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemberNameTextBox.Name = "MemberNameTextBox";
            this.MemberNameTextBox.Size = new System.Drawing.Size(294, 28);
            this.MemberNameTextBox.TabIndex = 1;
            // 
            // MemIDNumericUpDown
            // 
            this.MemIDNumericUpDown.Location = new System.Drawing.Point(628, 129);
            this.MemIDNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemIDNumericUpDown.Name = "MemIDNumericUpDown";
            this.MemIDNumericUpDown.Size = new System.Drawing.Size(135, 26);
            this.MemIDNumericUpDown.TabIndex = 27;
            this.MemIDNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MemIDNumericUpDown_KeyDown);
            // 
            // MemListButton
            // 
            this.MemListButton.AutoSize = true;
            this.MemListButton.BackColor = System.Drawing.Color.Gainsboro;
            this.MemListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemListButton.Location = new System.Drawing.Point(885, 120);
            this.MemListButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemListButton.Name = "MemListButton";
            this.MemListButton.Size = new System.Drawing.Size(90, 41);
            this.MemListButton.TabIndex = 26;
            this.MemListButton.Text = "List";
            this.MemListButton.UseVisualStyleBackColor = false;
            this.MemListButton.Click += new System.EventHandler(this.MemListButton_Click);
            // 
            // RetrieveButton
            // 
            this.RetrieveButton.BackColor = System.Drawing.Color.Gainsboro;
            this.RetrieveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrieveButton.Location = new System.Drawing.Point(781, 120);
            this.RetrieveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RetrieveButton.Name = "RetrieveButton";
            this.RetrieveButton.Size = new System.Drawing.Size(90, 41);
            this.RetrieveButton.TabIndex = 25;
            this.RetrieveButton.Text = "Retrieve";
            this.RetrieveButton.UseVisualStyleBackColor = false;
            this.RetrieveButton.Click += new System.EventHandler(this.RetrieveButton_Click);
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.AutoSize = true;
            this.MemberIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDLabel.Location = new System.Drawing.Point(361, 129);
            this.MemberIDLabel.Name = "MemberIDLabel";
            this.MemberIDLabel.Size = new System.Drawing.Size(101, 22);
            this.MemberIDLabel.TabIndex = 24;
            this.MemberIDLabel.Text = "Member ID:";
            // 
            // MemberStatusStrip
            // 
            this.MemberStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MemberStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MemberToolStripStatusLabel});
            this.MemberStatusStrip.Location = new System.Drawing.Point(0, 661);
            this.MemberStatusStrip.Name = "MemberStatusStrip";
            this.MemberStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.MemberStatusStrip.Size = new System.Drawing.Size(992, 30);
            this.MemberStatusStrip.TabIndex = 28;
            // 
            // MemberToolStripStatusLabel
            // 
            this.MemberToolStripStatusLabel.Name = "MemberToolStripStatusLabel";
            this.MemberToolStripStatusLabel.Size = new System.Drawing.Size(60, 25);
            this.MemberToolStripStatusLabel.Text = "Status";
            // 
            // UpdateMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 691);
            this.Controls.Add(this.MemberStatusStrip);
            this.Controls.Add(this.MemIDNumericUpDown);
            this.Controls.Add(this.MemListButton);
            this.Controls.Add(this.RetrieveButton);
            this.Controls.Add(this.MemberIDLabel);
            this.Controls.Add(this.MemberGroupBox);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "UpdateMemberForm";
            this.Text = "Update Member";
            this.Load += new System.EventHandler(this.UpdateMemberForm_Load);
            this.MemberGroupBox.ResumeLayout(false);
            this.MemberGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemIDNumericUpDown)).EndInit();
            this.MemberStatusStrip.ResumeLayout(false);
            this.MemberStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.GroupBox MemberGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MemberNameLabel;
        private System.Windows.Forms.Label PhoneNumLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox MemberNameTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.NumericUpDown MemIDNumericUpDown;
        private System.Windows.Forms.Button MemListButton;
        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.Label MemberIDLabel;
        private System.Windows.Forms.TextBox QtyBorrowedTextBox;
        private System.Windows.Forms.StatusStrip MemberStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MemberToolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
    }
}

