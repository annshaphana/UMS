using WindowsFormsApp1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1
{
    public partial class Student : Form
    {
        private readonly StudentController studentController;
        private string Address;

        public Student()
        {
            InitializeComponent();
            // Pass the connection string here
            string connectionString = "Data Source=student.db;Version=3;";
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
                Address = address.Text
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


        private void btn_delete_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_viwe_Click(object sender, EventArgs e)
        {
            
        }

        private void viewstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
    }
}
