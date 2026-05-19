using PRG262_Bob_s_Gym.Forms;
using System;
using PRG262_Bob_s_Gym.Models;
using System.Windows.Forms;

using Utilities;
namespace PRG262_Bob_s_Gym
{
    public partial class Form1 : Form
    {
        FileHandler handler = new FileHandler();

        public DateTime dtp => DOBPicker.Value;

        //This is to save user details
        string savedUsername;
        string savedPassword;
        public Form1()
        {
            InitializeComponent();
            
            handler.CreateDefaultAdminIfNotExists();
            
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


            try
            {
                User loginUser = new User()
                {
                    Username = username,
                    Password = password
                };

                string result = handler.ValidateLogin(loginUser);


                switch (result)
                {
                    case "success":
                        MessageBox.Show($"Welcome back {username}!", "Login Successfull",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        MemberForm memberFrm = new MemberForm();
                        memberFrm.Show();
                        //this.Close();
                        break;
                    case "locked":
                        MessageBox.Show("This account has been locked due to too many failed attempts, Contact the administrator.",
                            "Account locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    default:
                        if (int.TryParse(result, out int attemptsLeft))
                        {
                            MessageBox.Show($"Invalid Password, {attemptsLeft} attempt(s) remaining.",
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        txtPassword.Clear();
                        txtUsername.Clear();
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred during login: \n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                           
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
            }
        }
    }
}
