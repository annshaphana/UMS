using System;

namespace WindowsFormsApp1.View
{
    partial class TimetableForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTimetables;
        private EventHandler btnUpdate_ClickAsync;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelDay = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTimetables = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetables)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(20, 20);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(26, 13);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "Day";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(100, 17);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(200, 20);
            this.txtDay.TabIndex = 1;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(20, 50);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(43, 13);
            this.labelSubject.TabIndex = 2;
            this.labelSubject.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(100, 47);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(200, 20);
            this.txtSubject.TabIndex = 3;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(20, 80);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(30, 13);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Time";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(100, 77);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(200, 20);
            this.txtTime.TabIndex = 5;
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(20, 110);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(47, 13);
            this.labelTeacher.TabIndex = 6;
            this.labelTeacher.Text = "Teacher";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(100, 107);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(200, 20);
            this.txtTeacher.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(320, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_ClickAsync);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(320, 47);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_ClickAsync);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(320, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_ClickAsync);
            // 
            // dgvTimetables
            // 
            this.dgvTimetables.AllowUserToAddRows = false;
            this.dgvTimetables.AllowUserToDeleteRows = false;
            this.dgvTimetables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetables.Location = new System.Drawing.Point(20, 150);
            this.dgvTimetables.Name = "dgvTimetables";
            this.dgvTimetables.ReadOnly = true;
            this.dgvTimetables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimetables.Size = new System.Drawing.Size(560, 200);
            this.dgvTimetables.TabIndex = 11;
            this.dgvTimetables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimetables_CellContentClick);
            this.dgvTimetables.SelectionChanged += new System.EventHandler(this.dgvTimetables_SelectionChanged);
            // 
            // TimetableForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvTimetables);
            this.Name = "TimetableForm";
            this.Text = "Timetable Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnDelete_ClickAsync(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAdd_ClickAsync(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
