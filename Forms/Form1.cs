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
using PRG262_Bob_s_Gym.Utilities;
using Utilities;
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

            if(String.IsNullOrEmpty(username) || String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Pease enter both username and password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FileHandler handler = new FileHandler();
            string result = handler.ValidateLogin(username, password);

            switch (result)
            {
                case "success":
                    MessageBox.Show($"Welcome back {username}!", "Login Successfull",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MemberForm memberFrm = new MemberForm();
                    memberFrm.Show();
                    this.Close();
                    break;
                case "locked":
                    MessageBox.Show("This account has been locked due to too many failed attempts, Contact the administrator.",
                        "Account locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    if(int.TryParse(result, out int attemptsLeft))
                    {
                        MessageBox.Show($"Invalid Password, {attemptsLeft} attempt(s) remaining.",
                            "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtPassword.Clear();
                    txtUsername.Clear();
                    break;
            }

            //if(username =="admin" && password =="gym123")
            //{
            //    MessageBox.Show("Login Success");
            //    new MemberForm().Show();
            //    this.Hide();
            //}
            //else 
            //{
            //    MessageBox.Show("Login failed");
            //    txtUsername.Clear();
            //    txtPassword.Clear();
            //    txtUsername.Focus();
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
