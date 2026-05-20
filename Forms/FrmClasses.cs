using PRG262_Bob_s_Gym.Classes;
using PRG262_Bob_s_Gym.DataAccess;
using PRG262_Bob_s_Gym.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace PRG262_Bob_s_Gym.Forms
{
    public partial class FrmClasses : Form
    {
        private readonly ClassDAO classDAO = new ClassDAO();

        public FrmClasses()
        {
            InitializeComponent();
            
            LoadAllClasses();
        }
        private void LoadAllClasses()
        {
            try
            {
                DataTable dt = classDAO.GetAllClasses();
                dgvClasses.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading classes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtClassName.Text))
            {
                MessageBox.Show("Class name is required.", "Validation");
                return;
            }

            var newClass = new GymClass
            {
                ClassName = TxtClassName.Text.Trim(),
                Desc = TxtDescription.Text.Trim(),
                Instructor = TxtInstructor.Text.Trim(),
                Schedule = TxtSchedule.Text.Trim(),
                Capacity = (int)numericCapacity.Value,
                Duration = (int)numericDuration.Value
            };

            try
            {
                int newID = classDAO.AddClass(newClass);
                MessageBox.Show($"Class added successfully! ID: {newID}", "Success");
                ClearFields();
                LoadAllClasses();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding class: {ex.Message}", "Error");
            }
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow == null)
            {
                MessageBox.Show("Please select a class to update.");
                return;
            }

            int classID = Convert.ToInt32(dgvClasses.CurrentRow.Cells["ClassID"].Value);

            var updatedClass = new GymClass
            {
                ClassID = classID,
                ClassName = TxtClassName.Text.Trim(),
                Desc = TxtDescription.Text.Trim(),
                Instructor = TxtInstructor.Text.Trim(),
                Schedule = TxtSchedule.Text.Trim(),
                Capacity = (int)numericCapacity.Value,
                Duration = (int)numericDuration.Value
            };

            try
            {
                bool success = classDAO.UpdateClass(updatedClass);
                if (success)
                {
                    MessageBox.Show("Class updated successfully!", "Success");
                    ClearFields();
                    LoadAllClasses();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating class: {ex.Message}", "Error");
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow == null)
            {
                MessageBox.Show("Please select a class to delete.");
                return;
            }

            int classID = Convert.ToInt32(dgvClasses.CurrentRow.Cells["ClassID"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this class?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    bool success = classDAO.DeleteClass(classID);
                    if (success)
                    {
                        MessageBox.Show("Class deleted successfully!");
                        LoadAllClasses();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting class: {ex.Message}");
                }
            }
        }

        private void ClearFields()
        {
            TxtClassName.Clear();
            TxtDescription.Clear();
            TxtInstructor.Clear();
            TxtSchedule.Clear();
            numericCapacity.Value = 10;
            numericDuration.Value = 60;
        }

        private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvClasses.Rows[e.RowIndex];

            TxtClassName.Text = row.Cells["ClassName"].Value?.ToString() ?? "";
            TxtDescription.Text = row.Cells["Description"].Value?.ToString() ?? "";
            TxtInstructor.Text = row.Cells["Instructor"].Value?.ToString() ?? "";
            TxtSchedule.Text = row.Cells["Schedule"].Value?.ToString() ?? "";

            if (row.Cells["Capacity"].Value != DBNull.Value)
                numericCapacity.Value = Convert.ToDecimal(row.Cells["Capacity"].Value);

            if (row.Cells["Duration"].Value != DBNull.Value)
                numericDuration.Value = Convert.ToDecimal(row.Cells["Duration"].Value);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            User user = new User();
            FrmMain main = new FrmMain(user.Username);
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}