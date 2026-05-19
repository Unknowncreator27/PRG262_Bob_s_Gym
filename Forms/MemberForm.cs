using PRG262_Bob_s_Gym.DataAccess;
using System;

using System.Data;
using PRG262_Bob_s_Gym.Exceptions;
using System.Windows.Forms;

namespace PRG262_Bob_s_Gym.Forms
{
    public partial class MemberForm : Form
    {
        private readonly MemberDAO memberDAO = new MemberDAO();
        public MemberForm()
        {
            InitializeComponent();
            LoadAllMembers();
        }

        private void LoadAllMembers()
        {
            try
            {
                 
                DataTable dt = memberDAO.GetAllMembers();
                dgvUsers.DataSource = dt;
            } catch(Exception ex)
            {
                MessageBox.Show($"Error loading members, {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            Member member = new Member
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                DOB = DOBPicker.Value.Date,
                Gender = cmbGender.Text,
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                TrainingProgram = txtTrainingProgram.Text.Trim(),
                MembershipStartDate = dtpStartDate.Value.Date,
                MembershipEndDate = dtpEndDate.Value.Date

            };

            try
            {
                int newID = memberDAO.AddMember(member);

                MessageBox.Show($"Member created successfully! ID: {newID}.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadAllMembers();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error creating member: {ex}.", "Create Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            LoadAllMembers();
        }

        //private void ReadAllMembers()
        //{
        //    string query = "SELECT * FROM Members";
        //    try
        //    {
        //        using (SqlConnection conn = DBHelper.CreateConnection())
        //        using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
        //        {
        //            DataTable dt = new DataTable();
        //            adapter.Fill(dt);
        //            dgvUsers.DataSource = dt;  // replace with your DataGridView name
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Read Failed",
        //                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void update_Click(object sender, EventArgs e)
        {

            if(dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a member to update", "No Selection");
                return;
            }
            if (!ValidateFields()) return;

            int memberID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["MemberID"].Value);

            var updatedMember = new Member
            {
                MemberID = memberID,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                DOB = DOBPicker.Value.Date,
                Gender = cmbGender.Text,
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                TrainingProgram = txtTrainingProgram.Text.Trim(),
                MembershipStartDate = dtpStartDate.Value.Date,
                MembershipEndDate = dtpEndDate.Value.Date
            };

            try
            {
                bool success = memberDAO.UpdateMember(updatedMember);
                if (success)
                {
                    MessageBox.Show("Member updated successfully", "Success");
                    ClearFields();
                    LoadAllMembers();
                }
            } catch (CustomExceptions.DuplicateEntryException ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch(Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a member to delete.");
                return;
            }
            int memberID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["MemberID"].Value);
            string memberName = dgvUsers.CurrentRow.Cells["FirstName"]?.Value?.ToString() ?? "this member";

            var confirm = MessageBox.Show($"Are you sure you want to delete {memberName}?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                bool success = memberDAO.DeleteMember(memberID);
                if (success)
                {
                    MessageBox.Show("Member deleted successfully", "Success");
                    ClearFields();
                    LoadAllMembers();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error deleting member, {ex.Message}.", "Delete Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                   
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

            txtMembershipID.Text = row.Cells["MemberID"].Value?.ToString();
            txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
            txtLastName.Text = row.Cells["LastName"].Value?.ToString();
            txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString();
            txtAddress.Text = row.Cells["Address"].Value?.ToString();
            txtTrainingProgram.Text = row.Cells["TrainingProgram"].Value?.ToString();

            if (row.Cells["DateOfBirth"].Value != DBNull.Value)
                DOBPicker.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);

            cmbGender.Text = row.Cells["Gender"].Value?.ToString() ?? "";

            if (row.Cells["MembershipStartDate"].Value != DBNull.Value)
                dtpStartDate.Value = Convert.ToDateTime(row.Cells["MembershipStartDate"].Value);

            if (row.Cells["MembershipEndDate"].Value != DBNull.Value)
                dtpEndDate.Value = Convert.ToDateTime(row.Cells["MembershipEndDate"].Value);
        }
    }
}
