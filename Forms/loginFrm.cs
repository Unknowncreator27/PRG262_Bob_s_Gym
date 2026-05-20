using PRG262_Bob_s_Gym.Forms;
using PRG262_Bob_s_Gym.Models;
using PRG262_Bob_s_Gym.Themes;
using PRG262_Bob_s_Gym.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;
using Utilities;

namespace PRG262_Bob_s_Gym
{
    public partial class loginFrm : Form
    {
        private readonly FileHandler fileHandler = new FileHandler();
        private User currentCheckedUser = null;

        public loginFrm()
        {
            InitializeComponent();
            SetupForm();
            ApplyTheme();
            FileHandler handler = new FileHandler();
            handler.UnlockAccount("admin");
        }

        private void SetupForm()
        {
            
            loginBtn.Enabled = false;

            // Default hidden
            LblAccountStatus.Visible = false;
            panelAccountLocked.Visible = false;
            btnOpenAdminUnlock.Visible = false;

            // Events
            loginUsername.TextChanged += LoginUsername_TextChanged;
            loginPassword.TextChanged += TextFields_TextChanged;
            loginPassword.KeyDown += loginPassword_KeyDown;
            shwPswd.CheckedChanged += shwPswd_CheckedChanged;

            loginUsername.Leave += loginUsername_Leave;
        }

        private void ApplyTheme()
        {
            this.Height = 500;
            this.Width = 600;

            GymTheme.StyleTextBox(loginUsername);
            GymTheme.StyleTextBox(loginPassword);
            GymTheme.styleCheckBox(shwPswd);
            GymTheme.StyleButton(loginBtn);

            //loginBtn.Text = "SIGN IN";
            //loginBtn.Height = 48;
        }

        private void TextFields_TextChanged(object sender, EventArgs e)
        {
            loginBtn.Enabled = !string.IsNullOrWhiteSpace(loginUsername.Text) &&
                               !string.IsNullOrWhiteSpace(loginPassword.Text);
        }

        private void LoginUsername_TextChanged(object sender, EventArgs e)
        {
            TextFields_TextChanged(sender, e);
            ResetStatusIndicator();
        }

        private void loginUsername_Leave(object sender, EventArgs e)
        {
            CheckAccountStatus();
        }

        private void CheckAccountStatus()
        {
            string username = loginUsername.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                ResetStatusIndicator();
                return;
            }

            try
            {
                var users = FileHandler.GetAllUsers(@"users.txt");
                currentCheckedUser = users.Find(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

                if (currentCheckedUser?.IsLocked == true)
                {
                    ShowLockedStatus();
                }
                else if (currentCheckedUser != null)
                {
                    ShowUnlockedStatus();
                }
                else
                {
                    ResetStatusIndicator();
                }
            }
            catch (Exception ex)
            {
                ResetStatusIndicator();
                Console.WriteLine($"CheckAccountStatus Error: {ex.Message}");
            }
        }

        private void ShowLockedStatus()
        {
            LblAccountStatus.Text = "● LOCKED";
            LblAccountStatus.ForeColor = Color.Red;
            LblAccountStatus.Visible = true;

            btnOpenAdminUnlock.Visible = true;
            panelAccountLocked.Visible = true;   // Make sure panel is visible
        }

        private void ShowUnlockedStatus()
        {
            LblAccountStatus.Text = "● UNLOCKED";
            LblAccountStatus.ForeColor = Color.LimeGreen;
            LblAccountStatus.Visible = true;

            btnOpenAdminUnlock.Visible = false;
            panelAccountLocked.Visible = false;
        }

        private void ResetStatusIndicator()
        {
            LblAccountStatus.Visible = false;
            panelAccountLocked.Visible = false;
            btnOpenAdminUnlock.Visible = false;
        }

        // ================== LOGIN BUTTON ==================
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = loginUsername.Text.Trim();
            string password = loginPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User loginUser = new User { Username = username, Password = password };
                string result = fileHandler.ValidateLogin(loginUser);

                // ... (your switch statement is fine, keeping it as is)
                switch (result)
                {
                    case "success":
                        MessageBox.Show($"Welcome back, {username}!", "Login Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        FrmMain dash = new FrmMain(username);
                        dash.ShowDialog();
                        this.Close();
                        break;

                    case "locked":
                        MessageBox.Show("This account has been locked.\nPlease contact the administrator.",
                            "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    default:
                        if (int.TryParse(result, out int attemptsLeft) && attemptsLeft > 0)
                        {
                            MessageBox.Show($"Invalid password. {attemptsLeft} attempt(s) remaining.",
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        loginPassword.Clear();
                        loginPassword.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Keep your other methods (KeyDown, Show Password, Admin Unlock)
        private void loginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && loginBtn.Enabled)
            {
                e.SuppressKeyPress = true;
                loginBtn_Click(sender, e);
            }
        }

        private void shwPswd_CheckedChanged(object sender, EventArgs e)
        {
            loginPassword.UseSystemPasswordChar = !shwPswd.Checked;
        }

        private void btnOpenAdminUnlock_Click(object sender, EventArgs e)
        {
            using (var passwordPrompt = new FrmAdminPasswordPrompt())
            {
                if (passwordPrompt.ShowDialog() == DialogResult.OK)
                {
                    this.Hide();
                    FrmAdminUnlock adminFrm = new FrmAdminUnlock();
                    adminFrm.ShowDialog();
                    this.Show();
                }
            }
        }
    }
}