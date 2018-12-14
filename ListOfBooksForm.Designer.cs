namespace SA_Team10bCAProject
{
    partial class ListOfBooksForm
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
            this.ListOfBookCRViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ListOfBookCRViewer
            // 
            this.ListOfBookCRViewer.ActiveViewIndex = -1;
            this.ListOfBookCRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListOfBookCRViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListOfBookCRViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOfBookCRViewer.Location = new System.Drawing.Point(0, 0);
            this.ListOfBookCRViewer.Name = "ListOfBookCRViewer";
            this.ListOfBookCRViewer.Size = new System.Drawing.Size(800, 450);
            this.ListOfBookCRViewer.TabIndex = 0;
            // 
            // ListOfBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListOfBookCRViewer);
            this.Name = "ListOfBooksForm";
            this.Text = "List Of Books";
            this.Load += new System.EventHandler(this.ListOfBooksForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ListOfBookCRViewer;
    }
}