namespace SA_Team10bCAProject
{
    partial class BorrowRecordForm
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
            this.BorrowRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MemberNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowRecordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BorrowRecordDataGridView
            // 
            this.BorrowRecordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.BorrowRecordDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.BorrowRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowRecordDataGridView.Location = new System.Drawing.Point(14, 68);
            this.BorrowRecordDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BorrowRecordDataGridView.Name = "BorrowRecordDataGridView";
            this.BorrowRecordDataGridView.RowTemplate.Height = 24;
            this.BorrowRecordDataGridView.Size = new System.Drawing.Size(1155, 611);
            this.BorrowRecordDataGridView.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(1059, 700);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(110, 41);
            this.CancelButton.TabIndex = 26;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MemberNameLabel
            // 
            this.MemberNameLabel.AutoSize = true;
            this.MemberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNameLabel.Location = new System.Drawing.Point(14, 22);
            this.MemberNameLabel.Name = "MemberNameLabel";
            this.MemberNameLabel.Size = new System.Drawing.Size(0, 22);
            this.MemberNameLabel.TabIndex = 27;
            // 
            // BorrowRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1186, 769);
            this.Controls.Add(this.MemberNameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BorrowRecordDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BorrowRecordForm";
            this.Text = "Borrow Record Form";
            this.Load += new System.EventHandler(this.BorrowRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BorrowRecordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BorrowRecordDataGridView;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label MemberNameLabel;
    }
}