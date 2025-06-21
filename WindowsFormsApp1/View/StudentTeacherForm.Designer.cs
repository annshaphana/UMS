namespace WindowsFormsApp1
{
    partial class StudentTeacherForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvStudentTeacher;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblTeacherID;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvStudentTeacher = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblTeacherID = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentTeacher)).BeginInit();
            this.SuspendLayout();

            // lblID
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 20);
            this.lblID.Text = "ID:";

            // txtID
            this.txtID.Location = new System.Drawing.Point(120, 20);
            this.txtID.ReadOnly = true;

            // lblStudentID
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(30, 60);
            this.lblStudentID.Text = "Student ID:";

            // txtStudentID
            this.txtStudentID.Location = new System.Drawing.Point(120, 60);

            // lblTeacherID
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.Location = new System.Drawing.Point(30, 100);
            this.lblTeacherID.Text = "Teacher ID:";

            // txtTeacherID
            this.txtTeacherID.Location = new System.Drawing.Point(120, 100);

            // btnAdd
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(30, 140);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnDelete
            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(120, 140);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // dgvStudentTeacher
            this.dgvStudentTeacher.Location = new System.Drawing.Point(30, 190);
            this.dgvStudentTeacher.Size = new System.Drawing.Size(300, 200);
            this.dgvStudentTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentTeacher_CellClick);

            // Form
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblTeacherID);
            this.Controls.Add(this.txtTeacherID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvStudentTeacher);
            this.Text = "Student-Teacher Link";

            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

