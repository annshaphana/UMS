using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View;
using WindowsFormsApp1.Models;



namespace WindowsFormsApp1
{
    public partial class MainPanelForm : Form
    {
        public MainPanelForm()
        {
            InitializeComponent();
        }

        private void MainPanelForm_Load(object sender, EventArgs e)
        {
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show(); 
        
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {

            TeacherForm form = new TeacherForm();

            form.Show();
        }



        private void btnExam_Click(object sender, EventArgs e)
        {
            new ExamForm().Show();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            new SubjectForm().Show();
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            TimetableFormnew timetableForm = new TimetableForm();
            timetableForm.Show(); // Show the timetable form
        }


        private void btnCourse_Click(object sender, EventArgs e)
        {
            new CourseForm().Show();
        }
        private void btnRooms_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm();
            roomForm.ShowDialog();
        }

    }
}
