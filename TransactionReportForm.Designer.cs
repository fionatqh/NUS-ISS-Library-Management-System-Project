namespace SA_Team10bCAProject
{
    partial class TransactionReportForm
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
            this.TransactionReportCRViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // TransactionReportCRViewer
            // 
            this.TransactionReportCRViewer.ActiveViewIndex = -1;
            this.TransactionReportCRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransactionReportCRViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.TransactionReportCRViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionReportCRViewer.Location = new System.Drawing.Point(0, 0);
            this.TransactionReportCRViewer.Name = "TransactionReportCRViewer";
            this.TransactionReportCRViewer.Size = new System.Drawing.Size(800, 450);
            this.TransactionReportCRViewer.TabIndex = 0;
            // 
            // TransactionReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TransactionReportCRViewer);
            this.Name = "TransactionReportForm";
            this.Text = "Transaction Report (Issue - Return)";
            this.Load += new System.EventHandler(this.TransactionReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer TransactionReportCRViewer;
    }
}