using PRG262_Bob_s_Gym.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG262_Bob_s_Gym
{
    public partial class Form1 : Form
    {

        public DateTime dtp => DOBPicker.Value;

        //This is to save user details
        string savedUsername;
        string savedPassword;
        public Form1()
        {
            InitializeComponent();
        }

        private void DOBPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            if(username =="admin" && password =="gym123")
            {
                MessageBox.Show("Login Success");
                new MemberForm().Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Login failed");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
<<<<<<< Updated upstream
=======

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            if(username == "admin" && password =="gym123")
            {
                MessageBox.Show("Login Success");
                new MemberForm().Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Login failed");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
>>>>>>> Stashed changes
    }
}
