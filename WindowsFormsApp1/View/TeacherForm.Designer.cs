namespace WindowsFormsApp1
{
    partial class TimetableForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView viewTimetable;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.viewTimetable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewTimetable)).BeginInit();
            this.SuspendLayout();

            // txtDay
            this.txtDay.Location = new System.Drawing.Point(30, 30);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(150, 20);

            // txtSubject
            this.txtSubject.Location = new System.Drawing.Point(30, 60);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(150, 20);

            // txtTime
            this.txtTime.Location = new System.Drawing.Point(30, 90);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(150, 20);

            // txtTeacher
            this.txtTeacher.Location = new System.Drawing.Point(30, 120);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(150, 20);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(200, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "ADD";
            this.btnAdd.Size = new System.Drawing.Size(80, 25);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(200, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Size = new System.Drawing.Size(80, 25);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(200, 90);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Size = new System.Drawing.Size(80, 25);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnView
            this.btnView.Location = new System.Drawing.Point(200, 120);
            this.btnView.Name = "btnView";
            this.btnView.Text = "VIEW";
            this.btnView.Size = new System.Drawing.Size(80, 25);
            this.btnView.Click += new System.EventHandler(this.btnView_Click);

            // viewTimetable
            this.viewTimetable.Location = new System.Drawing.Point(30, 160);
            this.viewTimetable.Name = "viewTimetable";
            this.viewTimetable.Size = new System.Drawing.Size(400, 200);
            this.viewTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewTimetable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewTimetable.ReadOnly = true;
            this.viewTimetable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewTimetable_CellClick);

            // TimetableForm
            this.ClientSize = new System.Drawing.Size(480, 400);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.viewTimetable);
            this.Text = "Manage Timetable";
            ((System.ComponentModel.ISupportInitialize)(this.viewTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
