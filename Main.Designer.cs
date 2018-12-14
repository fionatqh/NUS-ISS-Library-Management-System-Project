namespace SA_Team10bCAProject

{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.libAdminLinkLabel = new System.Windows.Forms.LinkLabel();
            this.guestLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(305, 111);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(318, 20);
            this.welcomeLabel.TabIndex = 4;
            this.welcomeLabel.Text = "Welcome to The Bookoholics Library";
            // 
            // libAdminLinkLabel
            // 
            this.libAdminLinkLabel.ActiveLinkColor = System.Drawing.Color.Orchid;
            this.libAdminLinkLabel.AutoSize = true;
            this.libAdminLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libAdminLinkLabel.LinkColor = System.Drawing.Color.Orchid;
            this.libAdminLinkLabel.Location = new System.Drawing.Point(443, 243);
            this.libAdminLinkLabel.Name = "libAdminLinkLabel";
            this.libAdminLinkLabel.Size = new System.Drawing.Size(239, 20);
            this.libAdminLinkLabel.TabIndex = 5;
            this.libAdminLinkLabel.TabStop = true;
            this.libAdminLinkLabel.Text = "Library Administrator Login";
            this.libAdminLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.libAdminLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // guestLinkLabel
            // 
            this.guestLinkLabel.ActiveLinkColor = System.Drawing.Color.Orchid;
            this.guestLinkLabel.AutoSize = true;
            this.guestLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestLinkLabel.LinkColor = System.Drawing.Color.Orchid;
            this.guestLinkLabel.Location = new System.Drawing.Point(250, 200);
            this.guestLinkLabel.Name = "guestLinkLabel";
            this.guestLinkLabel.Size = new System.Drawing.Size(154, 20);
            this.guestLinkLabel.TabIndex = 6;
            this.guestLinkLabel.TabStop = true;
            this.guestLinkLabel.Text = "Guest Click Here";
            this.guestLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guestLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.guestLinkLabel_LinkClicked);
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(368, 159);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(0, 20);
            this.dateTimeLabel.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 435);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.guestLinkLabel);
            this.Controls.Add(this.libAdminLinkLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.LinkLabel libAdminLinkLabel;
        private System.Windows.Forms.LinkLabel guestLinkLabel;
        private System.Windows.Forms.Label dateTimeLabel;
    }
}

