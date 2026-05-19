namespace PRG262_Bob_s_Gym.Forms
{
    partial class FrmMain
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
            this.DashHeaderPanel = new System.Windows.Forms.Panel();
            this.LblUsername = new System.Windows.Forms.Label();
            this.welcomeLblTop = new System.Windows.Forms.Label();
            this.btnManageMembers = new System.Windows.Forms.Button();
            this.btnManageClasses = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.DashHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashHeaderPanel
            // 
            this.DashHeaderPanel.BackColor = System.Drawing.Color.Red;
            this.DashHeaderPanel.Controls.Add(this.LblUsername);
            this.DashHeaderPanel.Controls.Add(this.welcomeLblTop);
            this.DashHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.DashHeaderPanel.Name = "DashHeaderPanel";
            this.DashHeaderPanel.Size = new System.Drawing.Size(1864, 135);
            this.DashHeaderPanel.TabIndex = 8;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.Color.White;
            this.LblUsername.Location = new System.Drawing.Point(73, 62);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(122, 62);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "User";
            // 
            // welcomeLblTop
            // 
            this.welcomeLblTop.AutoSize = true;
            this.welcomeLblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLblTop.ForeColor = System.Drawing.Color.White;
            this.welcomeLblTop.Location = new System.Drawing.Point(77, 21);
            this.welcomeLblTop.Name = "welcomeLblTop";
            this.welcomeLblTop.Size = new System.Drawing.Size(225, 41);
            this.welcomeLblTop.TabIndex = 0;
            this.welcomeLblTop.Text = "Welcome back,";
            // 
            // btnManageMembers
            // 
            this.btnManageMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnManageMembers.Location = new System.Drawing.Point(486, 162);
            this.btnManageMembers.Name = "btnManageMembers";
            this.btnManageMembers.Size = new System.Drawing.Size(293, 69);
            this.btnManageMembers.TabIndex = 9;
            this.btnManageMembers.Text = "Manage Members";
            this.btnManageMembers.UseVisualStyleBackColor = false;
            this.btnManageMembers.Click += new System.EventHandler(this.btnManageMembers_Click);
            // 
            // btnManageClasses
            // 
            this.btnManageClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnManageClasses.Location = new System.Drawing.Point(828, 162);
            this.btnManageClasses.Name = "btnManageClasses";
            this.btnManageClasses.Size = new System.Drawing.Size(293, 69);
            this.btnManageClasses.TabIndex = 10;
            this.btnManageClasses.Text = "Manage Classes";
            this.btnManageClasses.UseVisualStyleBackColor = false;
            this.btnManageClasses.Click += new System.EventHandler(this.btnManageClasses_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnLogout.Location = new System.Drawing.Point(1173, 162);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(293, 69);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1865, 671);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageClasses);
            this.Controls.Add(this.btnManageMembers);
            this.Controls.Add(this.DashHeaderPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.DashHeaderPanel.ResumeLayout(false);
            this.DashHeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DashHeaderPanel;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label welcomeLblTop;
        private System.Windows.Forms.Button btnManageMembers;
        private System.Windows.Forms.Button btnManageClasses;
        private System.Windows.Forms.Button btnLogout;
    }
}