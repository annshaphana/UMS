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



namespace WindowsFormsApp1
{
    public partial class StudentTeacherForm : Form
    {
        private StudentTeacherController controller;

        public StudentTeacherForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=SchoolDb.db;Version=3;";
            controller = new StudentTeacherController(connectionString);
            LoadData();
        }

        private void LoadData()
        {
            dgvStudentTeacher.DataSource = controller.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var st = new StudentTeacher
            {
                StudentID = int.Parse(txtStudentID.Text),
                TeacherID = int.Parse(txtTeacherID.Text)
            };
            controller.Add(st);
            LoadData();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                controller.Delete(id);
                LoadData();
                ClearFields();
            }
        }

        private void dgvStudentTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvStudentTeacher.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtStudentID.Text = row.Cells["StudentID"].Value.ToString();
                txtTeacherID.Text = row.Cells["TeacherID"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtStudentID.Clear();
            txtTeacherID.Clear();
        }
    }
}
