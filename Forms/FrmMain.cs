using PRG262_Bob_s_Gym.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG262_Bob_s_Gym.Forms
{
    public partial class FrmMain : Form
    {
        private readonly string currentUser;

        public FrmMain(string username)
        {
            InitializeComponent();
            currentUser = username;
            SetupDash();
            ApplyTheme();
        }

        private void SetupDash()
        {
            this.Text = "Bob's Gym - Management Dashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.WindowState = FormWindowState.Maximized;


            // Welcome message
            LblUsername.Text = currentUser;
            
        }
        private void ApplyTheme()
        {
            this.ForeColor = GymTheme.BackgroundDark;
            this.ForeColor = GymTheme.TextPrimary;

            if(DashHeaderPanel != null)
            {
                DashHeaderPanel.BackColor = GymTheme.AccentRed;
                DashHeaderPanel.Height = 80;
            }

            
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberForm membersForm = new MemberForm();
            membersForm.ShowDialog();
            this.Show();
        }

        private void btnManageClasses_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FrmClasses classes = new FrmClasses();
            //FrmClasses.ShowDialog();
            this.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            //FrmReports reports = new FrmReports();
            //MessageBox.Show
        }

        private void btnAdminTools_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminUnlock adminUnlock = new FrmAdminUnlock();
            adminUnlock.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirmMessage = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirmMessage == DialogResult.Yes)
            {
                this.Close();
                loginFrm frm = new loginFrm();
                frm.Show();
            }
        }
    }
}
