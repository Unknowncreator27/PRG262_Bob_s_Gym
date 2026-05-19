using PRG262_Bob_s_Gym.Classes;
using PRG262_Bob_s_Gym.DataAccess;
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
    public partial class FrmClasses : Form
    {

        private readonly ClassDAO classDAO;

        public FrmClasses()
        {
            InitializeComponent();
            classDAO = new ClassDAO();
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

        private void ClearFields()
        {
            TxtClassName.Clear();
            TxtDescription.Clear();
            TxtInstructor.Clear();
            TxtSchedule.Clear();
            numericCapacity.Value = 10;
            numericDuration.Value = 60;

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtClassName.Text))
            {
                MessageBox.Show("Class name is required for validation", "Validation");
                return;
            }

            var newClass = new GymClass
            {
                ClassName = TxtClassName.Text,
                Desc = TxtDesc.Text,
                Instructor = TxtInstructor.Text,
                Schedule = TxtSchedule.Text.Trim(),
                Capacity = (int)numericCapacity.Value,
                Duration = (int)numericDuration.Value
            };

            try
            {
                int newID = classDAO.AddClass(newClass);
                MessageBox.Show($"Class added successfully! ID {newID}", "Success");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error adding class: {ex.Message}");
            }
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            if(dgvClasses.CurrentRow == null)
            {
                MessageBox.Show("Please select a class to update.");
                return;
            }

            var newClass = new GymClass
            {
                ClassName = TxtClassName.Text,
                Desc = TxtDesc.Text,
                Instructor = TxtInstructor.Text,
                Schedule = TxtSchedule.Text.Trim(),
                Capacity = (int)numericCapacity.Value,
                Duration = (int)numericDuration.Value
            };

            try
            {
                int newID = classDAO.AddClass(newClass);
                MessageBox.Show($"Class updated successfully! ID {newID}", "Success");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error adding class: {ex.Message}");
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow == null) return;

            int classID = Convert.ToInt32(dgvClasses.CurrentRow.Cells["ClassID"].Value);

            var confirm = MessageBox.Show("Delete this class?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(confirm == DialogResult.Yes)
            {
                classDAO.DeleteClass(classID);
                LoadAllClasses();
            }

        }

        private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
        }
    }
}
