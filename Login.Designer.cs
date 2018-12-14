namespace SA_Team10bCAProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnMemberID = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cancel_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.wrongLoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMemberID
            // 
            this.btnMemberID.AutoSize = true;
            this.btnMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberID.Location = new System.Drawing.Point(326, 156);
            this.btnMemberID.Name = "btnMemberID";
            this.btnMemberID.Size = new System.Drawing.Size(90, 18);
            this.btnMemberID.TabIndex = 7;
            this.btnMemberID.Text = "Member ID";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(326, 240);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(83, 18);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDTextBox.Location = new System.Drawing.Point(485, 151);
            this.memberIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(216, 24);
            this.memberIDTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(485, 238);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(216, 24);
            this.passwordTextBox.TabIndex = 10;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(335, 74);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(318, 20);
            this.welcomeLabel.TabIndex = 11;
            this.welcomeLabel.Text = "Welcome to The Bookoholics Library";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(485, 308);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 33);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cancel_LinkLabel
            // 
            this.cancel_LinkLabel.ActiveLinkColor = System.Drawing.Color.Gainsboro;
            this.cancel_LinkLabel.AutoSize = true;
            this.cancel_LinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_LinkLabel.LinkColor = System.Drawing.Color.Black;
            this.cancel_LinkLabel.Location = new System.Drawing.Point(643, 315);
            this.cancel_LinkLabel.Name = "cancel_LinkLabel";
            this.cancel_LinkLabel.Size = new System.Drawing.Size(54, 18);
            this.cancel_LinkLabel.TabIndex = 13;
            this.cancel_LinkLabel.TabStop = true;
            this.cancel_LinkLabel.Text = "Cancel";
            this.cancel_LinkLabel.VisitedLinkColor = System.Drawing.Color.Silver;
            this.cancel_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Cancel_LinkClicked);
            // 
            // wrongLoginLabel
            // 
            this.wrongLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLoginLabel.ForeColor = System.Drawing.Color.DimGray;
            this.wrongLoginLabel.Location = new System.Drawing.Point(485, 271);
            this.wrongLoginLabel.Name = "wrongLoginLabel";
            this.wrongLoginLabel.Size = new System.Drawing.Size(216, 19);
            this.wrongLoginLabel.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 435);
            this.Controls.Add(this.wrongLoginLabel);
            this.Controls.Add(this.cancel_LinkLabel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.btnMemberID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnMemberID;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel cancel_LinkLabel;
        private System.Windows.Forms.Label wrongLoginLabel;
    }
}