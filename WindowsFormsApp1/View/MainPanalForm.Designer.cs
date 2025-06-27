using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class MainPanelForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnTimetable = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
           // this.btnRooms = new System.Windows.Forms.Button();

            this.SuspendLayout();
            //
            // btnStudent
            //
            this.btnStudent.Location = new System.Drawing.Point(20, 20);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(100, 30);
            this.btnStudent.Text = "Student";
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            //
            // btnTeacher
            //
            this.btnTeacher.Location = new System.Drawing.Point(20, 60);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(100, 30);
            this.btnTeacher.Text = "Teacher";
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            //
            // btnExam
            //
            this.btnExam.Location = new System.Drawing.Point(20, 100);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(100, 30);
            this.btnExam.Text = "Exam";
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            //
            // btnSubject
            //
            this.btnSubject.Location = new System.Drawing.Point(20, 140);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(100, 30);
            this.btnSubject.Text = "Subject";
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            //
            // btnTimetable
            //
            //this.btnTimetable.Location = new System.Drawing.Point(20, 180);
            //this.btnTimetable.Name = "btnTimetable";
            //this.btnTimetable.Text = "Timetable";
            //this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);
            //
            // btnCourse
            //
            this.btnCourse.Location = new System.Drawing.Point(20, 220);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(100, 30);
            this.btnCourse.Text = "Course";
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            //
            // MainPanelForm
            //
            this.ClientSize = new System.Drawing.Size(300, 280);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnTimetable);
            this.Controls.Add(this.btnCourse);
            //this.Controls.Add(this.btnRooms);

            this.Name = "MainPanelForm";
            this.Text = "School Management Panel";
            this.Load += new System.EventHandler(this.MainPanelForm_Load);
            this.ResumeLayout(false);


            // 
            // btnTimetable
            // 
            this.btnTimetable = new System.Windows.Forms.Button();
            this.btnTimetable.Location = new System.Drawing.Point(50, 200);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(120, 30);
            this.btnTimetable.Text = "Timetable";
            this.btnTimetable.UseVisualStyleBackColor = true;
            this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);

            // Add to Controls
            this.Controls.Add(this.btnTimetable);

            //
            // btnRooms
            // 
            //this.btnRooms.Location = new System.Drawing.Point(50, 50);
            //this.btnRooms.Name = "btnRooms";
            //this.btnRooms.Size = new System.Drawing.Size(120, 40);
            //this.btnRooms.TabIndex = 0;
            //this.btnRooms.Text = "Manage Rooms";
            //this.btnRooms.UseVisualStyleBackColor = true;
            //this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
        }


        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Button btnCourse;
        //private System.Windows.Forms.Button btnRooms;

    }    
}
