using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models;



namespace WindowsFormsApp1.View
{
    public partial class CourseForm : Form
    {
        private readonly CourseController _courseController;

        public CourseForm()
        {
            InitializeComponent();

            // Change this connection string as per your database location
            string connectionString = "Data Source=your_database.db;Version=3;";
            _courseController = new CourseController(connectionString);

            LoadCourses();

            // Optional: Hide CourseId textbox if you don't want user to edit it
            txtCourseId.ReadOnly = true;
        }

        private void LoadCourses()
        {
            List<Course> courses = _courseController.GetAllCourses();
            dataGridCourses.DataSource = courses;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var course = new Course
                {
                    Name = txtCourseName.Text.Trim(),
                    Department = txtDepartment.Text.Trim()
                };
                _courseController.AddCourse(course);
                MessageBox.Show("Course added successfully.");
                ClearForm();
                LoadCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding course: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int courseId;
                if (!int.TryParse(txtCourseId.Text, out courseId))
                {
                    MessageBox.Show("Select a course to update.");
                    return;
                }

                var course = new Course
                {
                    Id = courseId,
                    Name = txtCourseName.Text.Trim(),
                    Department = txtDepartment.Text.Trim()
                };

                _courseController.UpdateCourse(course);
                MessageBox.Show("Course updated successfully.");
                ClearForm();
                LoadCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating course: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int courseId;
                if (!int.TryParse(txtCourseId.Text, out courseId))
                {
                    MessageBox.Show("Select a course to delete.");
                    return;
                }

                var confirm = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    _courseController.DeleteCourse(courseId);
                    MessageBox.Show("Course deleted successfully.");
                    ClearForm();
                    LoadCourses();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting course: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtCourseId.Text = "";
            txtCourseName.Text = "";
            txtDepartment.Text = "";
        }

        private void dataGridCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridCourses.Rows[e.RowIndex];
                txtCourseId.Text = row.Cells["Id"].Value.ToString();
                txtCourseName.Text = row.Cells["Name"].Value.ToString();
                txtDepartment.Text = row.Cells["Department"].Value.ToString();
            }
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }
        
        

        
    }
}

    

