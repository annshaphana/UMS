using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;



namespace WindowsFormsApp1.View
{
    public partial class ExamForm : Form
    {
        private readonly ExamController examController;

        public ExamForm()
        {
            InitializeComponent();

            // Dbconnection string உங்கள் Dbconfig-இல் இருந்து எடுத்துக்கொள்ளலாம்
            string connectionString = "Data Source=SchoolDb.db;Version=3;";

            examController = new ExamController(connectionString);

            LoadExams();
        }

        private void LoadExams()
        {
            var exams = examController.GetAllExams();
            dataGridExams.DataSource = exams;
            dataGridExams.Columns["Id"].Visible = false; // Id column மறைக்கலாம்
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Exam exam = new Exam
                {
                    ExamName = txtExamName.Text,
                    SubjectID = int.Parse(txtSubjectID.Text)
                };

                examController.AddExam(exam);
                MessageBox.Show("Exam Added Successfully.");
                ClearForm();
                LoadExams();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding exam: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridExams.CurrentRow == null)
                {
                    MessageBox.Show("Please select an exam to update.");
                    return;
                }

                Exam exam = new Exam
                {
                    Id = Convert.ToInt32(dataGridExams.CurrentRow.Cells["Id"].Value),
                    ExamName = txtExamName.Text,
                    SubjectID = int.Parse(txtSubjectID.Text)
                };

                examController.UpdateExam(exam);
                MessageBox.Show("Exam Updated Successfully.");
                ClearForm();
                LoadExams();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating exam: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridExams.CurrentRow == null)
                {
                    MessageBox.Show("Please select an exam to delete.");
                    return;
                }

                int id = Convert.ToInt32(dataGridExams.CurrentRow.Cells["Id"].Value);
                examController.DeleteExam(id);
                MessageBox.Show("Exam Deleted Successfully.");
                ClearForm();
                LoadExams();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting exam: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtExamName.Clear();
            txtSubjectID.Clear();
            dataGridExams.ClearSelection();
        }

        private void dataGridExams_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridExams.CurrentRow != null)
            {
                txtExamName.Text = dataGridExams.CurrentRow.Cells["ExamName"].Value.ToString();
                txtSubjectID.Text = dataGridExams.CurrentRow.Cells["SubjectID"].Value.ToString();
            }
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {

        }
    }
}

