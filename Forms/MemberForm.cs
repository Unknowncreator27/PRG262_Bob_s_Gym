using PRG262_Bob_s_Gym.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG262_Bob_s_Gym.Forms
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        //Read fields into a SqlCommand
        private void SetParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@MembershipID", txtMembershipID.Text.Trim());
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@DateOfBirth", DOBPicker.Value.Date);
            cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@TrainingProgram", txtTrainingProgram.Text.Trim());
            cmd.Parameters.AddWithValue("@MembershipStart", dtpStartDate.Value.Date);
            cmd.Parameters.AddWithValue("@MembershipEnd", dtpEndDate.Value.Date);
        }

        //Clear all fields
        private void ClearFields()
        {
            txtMembershipID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtTrainingProgram.Clear();
            cmbGender.SelectedIndex = -1;
            DOBPicker.Value = DateTime.Today;
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }

        //Validates the required fields
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtMembershipID.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("MembershipID, First Name and Last Name are required.",
                                "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            string query = @"INSERT INTO Members 
                        (MembershipID, FirstName, LastName, DateOfBirth, Gender,
                         PhoneNumber, Address, TrainingProgram, MembershipStart, MembershipEnd)
                        VALUES 
                        (@MembershipID, @FirstName, @LastName, @DateOfBirth, @Gender,
                         @PhoneNumber, @Address, @TrainingProgram, @MembershipStart, @MembershipEnd)";
            try
            {
                using (SqlConnection conn = DBHelper.CreateConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SetParameters(cmd);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member created successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    ReadAllMembers();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Create Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            ReadAllMembers();
        }

        private void ReadAllMembers()
        {
            string query = "SELECT * FROM Members";
            try
            {
                using (SqlConnection conn = DBHelper.CreateConnection())
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;  // replace with your DataGridView name
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Read Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            string query = @"UPDATE Members SET
                            FirstName       = @FirstName,
                            LastName        = @LastName,
                            DateOfBirth     = @DateOfBirth,
                            Gender          = @Gender,
                            PhoneNumber     = @PhoneNumber,
                            Address         = @Address,
                            TrainingProgram = @TrainingProgram,
                            MembershipStart = @MembershipStart,
                            MembershipEnd   = @MembershipEnd
                         WHERE MembershipID = @MembershipID";
            try
            {
                using (SqlConnection conn = DBHelper.CreateConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SetParameters(cmd);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Member updated successfully!", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        ReadAllMembers();
                    }
                    else
                    {
                        MessageBox.Show("No member found with that ID.", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMembershipID.Text))
            {
                MessageBox.Show("Enter a MembershipID to delete.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this member?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            string query = "DELETE FROM Members WHERE MembershipID = @MembershipID";
            try
            {
                using (SqlConnection conn = DBHelper.CreateConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MembershipID", txtMembershipID.Text.Trim());
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Member deleted successfully!", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        ReadAllMembers();
                    }
                    else
                    {
                        MessageBox.Show("No member found with that ID.", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtMembershipID.Text = row.Cells["MembershipID"].Value.ToString();
            txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
            txtLastName.Text = row.Cells["LastName"].Value.ToString();
            DOBPicker.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
            cmbGender.Text = row.Cells["Gender"].Value.ToString();
            txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
            txtTrainingProgram.Text = row.Cells["TrainingProgram"].Value.ToString();
            dtpStartDate.Value = Convert.ToDateTime(row.Cells["MembershipStart"].Value);
            dtpEndDate.Value = Convert.ToDateTime(row.Cells["MembershipEnd"].Value);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
