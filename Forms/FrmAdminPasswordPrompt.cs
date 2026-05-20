
using System;

using System.Windows.Forms;
using PRG262_Bob_s_Gym.Utilities;

namespace PRG262_Bob_s_Gym.Forms
{
    public partial class FrmAdminPasswordPrompt : Form
    {
        public FrmAdminPasswordPrompt()
        {
            InitializeComponent();

            txtAdminPassword.Focus();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminPassword.Text))
            {
                MessageBox.Show("Please enter the Admin Password.", "Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AdminService.ValidateAdminPassword(txtAdminPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Admin Password.", "Access Denied.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdminPassword.Clear();
                txtAdminPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtAdminPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnConfirm_Click(sender, e);
            }
        }
    }
}
