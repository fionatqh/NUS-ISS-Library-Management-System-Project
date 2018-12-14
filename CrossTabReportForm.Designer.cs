namespace SA_Team10bCAProject
{
    partial class CrossTabReportForm
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
            this.CrossTabCRViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrossTabCRViewer
            // 
            this.CrossTabCRViewer.ActiveViewIndex = -1;
            this.CrossTabCRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrossTabCRViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrossTabCRViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrossTabCRViewer.Location = new System.Drawing.Point(0, 0);
            this.CrossTabCRViewer.Name = "CrossTabCRViewer";
            this.CrossTabCRViewer.Size = new System.Drawing.Size(800, 450);
            this.CrossTabCRViewer.TabIndex = 0;
            // 
            // CrossTabReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CrossTabCRViewer);
            this.Name = "CrossTabReportForm";
            this.Text = "Publisher - Category Report";
            this.Load += new System.EventHandler(this.CrossTabReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrossTabCRViewer;
    }
}