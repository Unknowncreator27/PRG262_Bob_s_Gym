using PRG262_Bob_s_Gym.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG262_Bob_s_Gym.Themes;
using System.Windows.Forms;

namespace PRG262_Bob_s_Gym.Forms
{
    public partial class FrmAdminUnlock : Form
    {
        public FrmAdminUnlock()
        {
            InitializeComponent();
            LoadLockedAccounts();
            this.Width = 500;
            this.Height = 500;
        }

        private void ApplyTheme()
        {
            // buttons
            GymTheme.StyleButton(UnlockBtn);
            GymTheme.StyleButton(UnlockAllBtn);
            GymTheme.StyleButton(refreshBtn);
        }

        private void LoadLockedAccounts()
        {
            var lockedUsers = AdminService.GetLockedAccounts();
            dgvLockedAccounts.DataSource = lockedUsers;

            // A bit of UI improvement to improve column display
            if (dgvLockedAccounts.Columns["Password"] != null)
                dgvLockedAccounts.Columns["Password"].Visible = false;

            
        }

        private void UnlockBtn_Click(object sender, EventArgs e)
        {
            if (dgvLockedAccounts.CurrentRow == null)
            {
                MessageBox.Show("Please select an account to unlock", "No Selection");
                return;

            }

            string username = dgvLockedAccounts.CurrentRow.Cells["Username"].Value.ToString();
            if (AdminService.UnlockAccount(username))
            {
                MessageBox.Show($"Account '{username}' has been successfully unlocked.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLockedAccounts();

            }
        }

        private void UnlockAllBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to unlock all locked account?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                int unlocked = AdminService.UnlockAllAccounts();
                MessageBox.Show($"{unlocked} account(s) have been unlocked.", "Success");
                LoadLockedAccounts();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadLockedAccounts();
        }
    }
}
