namespace WindowsFormsApp1.View
{
    partial class AdminForm
    {
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button txt_clear;
        private System.Windows.Forms.DataGridView dataGridAdmins;

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btn_admin = new System.Windows.Forms.Button();
            this.txt_clear = new System.Windows.Forms.Button();
            this.dataGridAdmins = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmins)).BeginInit();
            this.SuspendLayout();

            // txtName
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(12, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(12, 64);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);

            // txtUserID
            this.txtUserID.Location = new System.Drawing.Point(12, 90);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(200, 20);

            // btn_admin
            this.btn_admin.Location = new System.Drawing.Point(12, 116);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(75, 23);
            this.btn_admin.Text = "Add Admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);

            // txt_clear
            this.txt_clear.Location = new System.Drawing.Point(137, 116);
            this.txt_clear.Name = "txt_clear";
            this.txt_clear.Size = new System.Drawing.Size(75, 23);
            this.txt_clear.Text = "Clear";
            this.txt_clear.UseVisualStyleBackColor = true;
            this.txt_clear.Click += new System.EventHandler(this.txt_clear_Click);

            // dataGridAdmins
            this.dataGridAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdmins.Location = new System.Drawing.Point(12, 150);
            this.dataGridAdmins.Name = "dataGridAdmins";
            this.dataGridAdmins.Size = new System.Drawing.Size(600, 200);

            // AdminForm
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.txt_clear);
            this.Controls.Add(this.dataGridAdmins);
            this.Name = "AdminForm";
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.AdminForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
