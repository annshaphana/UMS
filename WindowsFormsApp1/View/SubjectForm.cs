using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Controllers;



namespace WindowsFormsApp1
{
    public partial class SubjectForm : Form
    {
        private SubjectController subjectController;

        public SubjectForm()
        {
            InitializeComponent();

            string connectionString = "Data Source=SchoolDb.db;Version=3;";
            subjectController = new SubjectController(connectionString);

            LoadSubjects();
        }

        private void LoadSubjects()
        {
            List<Subject> subjects = subjectController.GetAllSubjects();
            dgvSubjects.DataSource = subjects;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var subject = new Subject
                {
                    Name = txtName.Text,
                    CourseID = int.Parse(txtCourseID.Text)
                };
                subjectController.AddSubject(subject);
                MessageBox.Show("Subject added successfully!");
                LoadSubjects();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var subject = new Subject
                {
                    Id = int.Parse(txtId.Text),
                    Name = txtName.Text,
                    CourseID = int.Parse(txtCourseID.Text)
                };
                subjectController.UpdateSubject(subject);
                MessageBox.Show("Subject updated successfully!");
                LoadSubjects();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                subjectController.DeleteSubject(id);
                MessageBox.Show("Subject deleted successfully!");
                LoadSubjects();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSubjects.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtCourseID.Text = row.Cells["CourseID"].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtId.Clear();
            txtName.Clear();
            txtCourseID.Clear();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            // Optional load logic
        }
    }
}
