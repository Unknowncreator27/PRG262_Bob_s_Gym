namespace PRG262_Bob_s_Gym.Forms
{
    partial class FrmAdminUnlock
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
            this.dgvLockedAccounts = new System.Windows.Forms.DataGridView();
            this.UnlockBtn = new System.Windows.Forms.Button();
            this.UnlockAllBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLockedAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLockedAccounts
            // 
            this.dgvLockedAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvLockedAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLockedAccounts.Location = new System.Drawing.Point(557, 24);
            this.dgvLockedAccounts.Name = "dgvLockedAccounts";
            this.dgvLockedAccounts.RowHeadersWidth = 102;
            this.dgvLockedAccounts.RowTemplate.Height = 40;
            this.dgvLockedAccounts.Size = new System.Drawing.Size(788, 524);
            this.dgvLockedAccounts.TabIndex = 0;
            // 
            // UnlockBtn
            // 
            this.UnlockBtn.Location = new System.Drawing.Point(557, 611);
            this.UnlockBtn.Name = "UnlockBtn";
            this.UnlockBtn.Size = new System.Drawing.Size(275, 82);
            this.UnlockBtn.TabIndex = 2;
            this.UnlockBtn.Text = "Unlock";
            this.UnlockBtn.UseVisualStyleBackColor = true;
            this.UnlockBtn.Click += new System.EventHandler(this.UnlockBtn_Click);
            // 
            // UnlockAllBtn
            // 
            this.UnlockAllBtn.Location = new System.Drawing.Point(1070, 611);
            this.UnlockAllBtn.Name = "UnlockAllBtn";
            this.UnlockAllBtn.Size = new System.Drawing.Size(275, 82);
            this.UnlockAllBtn.TabIndex = 3;
            this.UnlockAllBtn.Text = "Unlock All";
            this.UnlockAllBtn.UseVisualStyleBackColor = true;
            this.UnlockAllBtn.Click += new System.EventHandler(this.UnlockAllBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(1394, 24);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(275, 82);
            this.refreshBtn.TabIndex = 4;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // FrmAdminUnlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1867, 1079);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.UnlockAllBtn);
            this.Controls.Add(this.UnlockBtn);
            this.Controls.Add(this.dgvLockedAccounts);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmAdminUnlock";
            this.Text = "FrmAdminUnlock";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLockedAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLockedAccounts;
        private System.Windows.Forms.Button UnlockBtn;
        private System.Windows.Forms.Button UnlockAllBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}