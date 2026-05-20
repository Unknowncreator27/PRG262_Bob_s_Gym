namespace PRG262_Bob_s_Gym
{
    partial class loginFrm
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.shwPswd = new System.Windows.Forms.CheckBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.LblAccountStatus = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.gymSubLabel = new System.Windows.Forms.Label();
            this.gymNameLabel = new System.Windows.Forms.Label();
            this.btnOpenAdminUnlock = new System.Windows.Forms.Button();
            this.panelAccountLocked = new System.Windows.Forms.Panel();
            this.HeaderPanel.SuspendLayout();
            this.panelAccountLocked.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.loginBtn.Location = new System.Drawing.Point(615, 807);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(261, 72);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Sign In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginUsername
            // 
            this.loginUsername.Location = new System.Drawing.Point(593, 350);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(500, 38);
            this.loginUsername.TabIndex = 1;
            this.loginUsername.Leave += new System.EventHandler(this.loginUsername_Leave);
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(583, 612);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(500, 38);
            this.loginPassword.TabIndex = 2;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Segoe UI", 12.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.ForeColor = System.Drawing.Color.White;
            this.loginLbl.Location = new System.Drawing.Point(573, 213);
            this.loginLbl.MaximumSize = new System.Drawing.Size(800, 900);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Padding = new System.Windows.Forms.Padding(10);
            this.loginLbl.Size = new System.Drawing.Size(493, 79);
            this.loginLbl.TabIndex = 3;
            this.loginLbl.Text = "Sign in to Your acount";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(170)))));
            this.LblUsername.Location = new System.Drawing.Point(587, 293);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(173, 32);
            this.LblUsername.TabIndex = 4;
            this.LblUsername.Text = "USERNAME";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(170)))));
            this.LblPassword.Location = new System.Drawing.Point(583, 550);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(178, 32);
            this.LblPassword.TabIndex = 5;
            this.LblPassword.Text = "PASSWORD";
            // 
            // shwPswd
            // 
            this.shwPswd.AutoSize = true;
            this.shwPswd.ForeColor = System.Drawing.Color.White;
            this.shwPswd.Location = new System.Drawing.Point(591, 700);
            this.shwPswd.Name = "shwPswd";
            this.shwPswd.Size = new System.Drawing.Size(254, 36);
            this.shwPswd.TabIndex = 6;
            this.shwPswd.Text = "Show Password";
            this.shwPswd.UseVisualStyleBackColor = true;
            this.shwPswd.CheckedChanged += new System.EventHandler(this.shwPswd_CheckedChanged);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Red;
            this.HeaderPanel.Controls.Add(this.LblAccountStatus);
            this.HeaderPanel.Controls.Add(this.logoLabel);
            this.HeaderPanel.Controls.Add(this.gymSubLabel);
            this.HeaderPanel.Controls.Add(this.gymNameLabel);
            this.HeaderPanel.Location = new System.Drawing.Point(-7, -7);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1632, 135);
            this.HeaderPanel.TabIndex = 7;
            // 
            // LblAccountStatus
            // 
            this.LblAccountStatus.AutoSize = true;
            this.LblAccountStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.LblAccountStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAccountStatus.ForeColor = System.Drawing.Color.White;
            this.LblAccountStatus.Location = new System.Drawing.Point(1224, 30);
            this.LblAccountStatus.Name = "LblAccountStatus";
            this.LblAccountStatus.Size = new System.Drawing.Size(221, 46);
            this.LblAccountStatus.TabIndex = 0;
            this.LblAccountStatus.Text = "locked status";
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.BackColor = System.Drawing.Color.White;
            this.logoLabel.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.logoLabel.Location = new System.Drawing.Point(43, 30);
            this.logoLabel.Margin = new System.Windows.Forms.Padding(3);
            this.logoLabel.MaximumSize = new System.Drawing.Size(100, 100);
            this.logoLabel.MinimumSize = new System.Drawing.Size(40, 40);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Padding = new System.Windows.Forms.Padding(10, 15, 15, 15);
            this.logoLabel.Size = new System.Drawing.Size(85, 100);
            this.logoLabel.TabIndex = 8;
            this.logoLabel.Text = "BG";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gymSubLabel
            // 
            this.gymSubLabel.AutoSize = true;
            this.gymSubLabel.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymSubLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gymSubLabel.Location = new System.Drawing.Point(169, 89);
            this.gymSubLabel.Name = "gymSubLabel";
            this.gymSubLabel.Size = new System.Drawing.Size(458, 38);
            this.gymSubLabel.TabIndex = 10;
            this.gymSubLabel.Text = "Membership Management Platform";
            // 
            // gymNameLabel
            // 
            this.gymNameLabel.AutoSize = true;
            this.gymNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymNameLabel.ForeColor = System.Drawing.Color.White;
            this.gymNameLabel.Location = new System.Drawing.Point(166, 30);
            this.gymNameLabel.Name = "gymNameLabel";
            this.gymNameLabel.Size = new System.Drawing.Size(232, 59);
            this.gymNameLabel.TabIndex = 9;
            this.gymNameLabel.Text = "Bob\'s Gym";
            // 
            // btnOpenAdminUnlock
            // 
            this.btnOpenAdminUnlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnOpenAdminUnlock.Location = new System.Drawing.Point(28, 22);
            this.btnOpenAdminUnlock.Name = "btnOpenAdminUnlock";
            this.btnOpenAdminUnlock.Size = new System.Drawing.Size(169, 55);
            this.btnOpenAdminUnlock.TabIndex = 8;
            this.btnOpenAdminUnlock.Text = "Admin";
            this.btnOpenAdminUnlock.UseVisualStyleBackColor = false;
            this.btnOpenAdminUnlock.Click += new System.EventHandler(this.btnOpenAdminUnlock_Click);
            // 
            // panelAccountLocked
            // 
            this.panelAccountLocked.Controls.Add(this.btnOpenAdminUnlock);
            this.panelAccountLocked.Location = new System.Drawing.Point(1225, 293);
            this.panelAccountLocked.Name = "panelAccountLocked";
            this.panelAccountLocked.Size = new System.Drawing.Size(213, 100);
            this.panelAccountLocked.TabIndex = 9;
            // 
            // loginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1627, 1069);
            this.Controls.Add(this.panelAccountLocked);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.shwPswd);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginUsername);
            this.Controls.Add(this.loginBtn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "loginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bob\'s Gym — Login";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.panelAccountLocked.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.CheckBox shwPswd;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label gymNameLabel;
        private System.Windows.Forms.Label gymSubLabel;
        private System.Windows.Forms.Label LblAccountStatus;
        private System.Windows.Forms.Button btnOpenAdminUnlock;
        private System.Windows.Forms.Panel panelAccountLocked;
    }
}

