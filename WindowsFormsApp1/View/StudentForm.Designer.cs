namespace WindowsFormsApp1
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.viewstudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1 (Name)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.Text = "Name:";
            // 
            // label2 (Address)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.Text = "Address:";
            // 
            // name TextBox
            // 
            this.name.Location = new System.Drawing.Point(120, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 20);
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // txtAddress TextBox
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 67);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(30, 110);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 30);
            this.btn_view.Text = "VIEW";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(120, 110);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 30);
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(210, 110);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 30);
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(300, 110);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 30);
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // viewstudent DataGridView
            // 
            this.viewstudent.AllowUserToAddRows = false;
            this.viewstudent.AllowUserToDeleteRows = false;
            this.viewstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewstudent.Location = new System.Drawing.Point(30, 160);
            this.viewstudent.Name = "viewstudent";
            this.viewstudent.ReadOnly = true;
            this.viewstudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewstudent.Size = new System.Drawing.Size(500, 200);
            this.viewstudent.TabIndex = 9;
            this.viewstudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewstudent_CellContentClick);
            // 
            // StudentForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 391);
            this.Controls.Add(this.viewstudent);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "Manage Students";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView viewstudent;
    }
}
