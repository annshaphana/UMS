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
    public partial class MarkForm : Form
    {
        private MarkController _markController;

        public MarkForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=SchoolDb.db;Version=3;";
            _markController = new MarkController(connectionString);
            LoadMarks();
        }

        private void LoadMarks()
        {
            var marks = _markController.GetAllMarks();
            dgvMarks.DataSource = marks;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var mark = new Mark
            {
                StudentID = int.Parse(txtStudentID.Text),
                ExamID = int.Parse(txtExamID.Text),
                Score = int.Parse(txtScore.Text)
            };

            _markController.AddMark(mark);
            LoadMarks();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var mark = new Mark
            {
                Id = int.Parse(txtId.Text),
                StudentID = int.Parse(txtStudentID.Text),
                ExamID = int.Parse(txtExamID.Text),
                Score = int.Parse(txtScore.Text)
            };

            _markController.UpdateMark(mark);
            LoadMarks();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            _markController.DeleteMark(id);
            LoadMarks();
            ClearFields();
        }

        private void dgvMarks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMarks.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtStudentID.Text = row.Cells["StudentID"].Value.ToString();
                txtExamID.Text = row.Cells["ExamID"].Value.ToString();
                txtScore.Text = row.Cells["Score"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtId.Clear();
            txtStudentID.Clear();
            txtExamID.Clear();
            txtScore.Clear();
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {

        }
    }

}
