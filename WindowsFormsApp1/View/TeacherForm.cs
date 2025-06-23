using System;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class TeacherForm : Form
    {
        private Teacher _teacher;

        public TeacherForm()
        {
            InitializeComponent();
            
        }
        public TeacherForm(Teacher teacher)
        {
            InitializeComponent();
            _teacher = teacher;

            _teacher.Name=txtName.Text;
            _teacher.Address = txtAddress.Text;
            _teacher.Phone = txtPhone.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create Teacher model object from form input
            Teacher teacher = new Teacher
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text
            };

            TeacherController teacherController = new TeacherController();
            string getMessage = teacherController.AddTeacher(teacher);

            MessageBox.Show(getMessage);

            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }

        private void bnt_view_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Teacher_Load(object sender, EventArgs e)
        {

        }

        private void T_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void t_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}