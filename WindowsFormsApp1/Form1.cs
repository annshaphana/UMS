using WindowsFormsApp1.Models;
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


namespace WindowsFormsApp1
{
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                Name = name.Text,
                Address = address.Text,
            };
            StudentController studentController = new StudentController();
            string getMessage = studentController.AddStudent(student);

            MessageBox.Show(getMessage);

            
            //MessageBox.Show("TESTING Massage Box");
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
    }
}
