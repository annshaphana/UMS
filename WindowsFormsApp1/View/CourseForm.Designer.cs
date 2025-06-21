namespace WindowsFormsApp1.View
{
    partial class CourseForm
    {
        private System.ComponentModel.IContainer components = null;

        // UI controls declaration
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridCourses;
        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblDepartment;

        /// <summary>
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridCourses = new System.Windows.Forms.DataGridView();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourses)).BeginInit();
            this.SuspendLayout();

            // txtCourseId
            this.txtCourseId.Location = new System.Drawing.Point(130, 20);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.ReadOnly = true;
            this.txtCourseId.Size = new System.Drawing.Size(200, 20);

            // txtCourseName
            this.txtCourseName.Location = new System.Drawing.Point(130, 50);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(200, 20);

            // txtDepartment
            this.txtDepartment.Location = new System.Drawing.Point(130, 80);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(200, 20);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(20, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(110, 120);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(200, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(290, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // dataGridCourses
            this.dataGridCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCourses.Location = new System.Drawing.Point(20, 160);
            this.dataGridCourses.Name = "dataGridCourses";
            this.dataGridCourses.Size = new System.Drawing.Size(460, 200);
            this.dataGridCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCourses_CellClick);

            // lblCourseId
            this.lblCourseId.Location = new System.Drawing.Point(20, 20);
            this.lblCourseId.Text = "Course ID:";

            // lblCourseName
            this.lblCourseName.Location = new System.Drawing.Point(20, 50);
            this.lblCourseName.Text = "Course Name:";

            // lblDepartment
            this.lblDepartment.Location = new System.Drawing.Point(20, 80);
            this.lblDepartment.Text = "Department:";

            // CourseForm
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.label1);
            this.Name = "CourseForm";
            this.Text = "Course Form";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Controls.Add(this.txtCourseId);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridCourses);
            this.Controls.Add(this.lblCourseId);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblDepartment);
            this.Name = "CourseForm";
            this.Text = "Course Management";
            this.Load += new System.EventHandler(this.CourseForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Label label1;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

    }
}
