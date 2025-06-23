using WindowsFormsApp1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1
{
    public partial class StudentForm : Form
    {
        private readonly StudentController studentController;
        

        public StudentForm()
        {
            InitializeComponent();
            // Pass the connection string here
            string connectionString = "Data Source=SchoolDb.db;Version=3;";
            studentController = new StudentController(connectionString);


            // Start loading students when form initializes
            _ = LoadStudentsAsync();  
        }

        private async Task LoadStudentsAsync()
        {
            try
            {
                var students = await studentController.GetAllStudentsAsync();
                viewstudent.DataSource = students; // assuming 'viewstudent' is your DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            var student = new Models.Student
            {
                Name = name.Text,
                Address = txtAddress.Text
            };

            try
            {
                await studentController.AddStudentAsync(student); 

                MessageBox.Show("Student added successfully!");

                // Refresh student list
                await LoadStudentsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message);

            }
        }


        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (viewstudent.CurrentRow != null)
            {
                int studentId = Convert.ToInt32(viewstudent.CurrentRow.Cells["StudentID"].Value);

                var confirmResult = MessageBox.Show("Are you sure to delete this student?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        await studentController.DeleteStudentAsync(studentId);
                        MessageBox.Show("Student deleted successfully!");
                        await LoadStudentsAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting student: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (viewstudent.CurrentRow != null)
            {
                int studentId = Convert.ToInt32(viewstudent.CurrentRow.Cells["StudentID"].Value);
                var updatedStudent = new Models.Student
                {
                    StudentID = studentId,
                    Name = name.Text,
                    Address = txtAddress.Text
                };

                try
                {
                    await studentController.UpdateStudentAsync(updatedStudent);
                    MessageBox.Show("Student updated successfully!");
                    await LoadStudentsAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating student: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }
        }

        private async void btn_view_Click(object sender, EventArgs e)
        {
            await LoadStudentsAsync();
        }

        private void viewstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = viewstudent.Rows[e.RowIndex];
                name.Text = row.Cells["Name"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }
        private void ManageStudent_Load(object sender, EventArgs e)
        {
           
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
