namespace WindowsFormsApp1
{
    partial class TeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tea_name = new System.Windows.Forms.Label();
            this.Tea_address = new System.Windows.Forms.Label();
            this.Tea_phone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tea_name
            // 
            this.Tea_name.AutoSize = true;
            this.Tea_name.Location = new System.Drawing.Point(134, 41);
            this.Tea_name.Name = "Tea_name";
            this.Tea_name.Size = new System.Drawing.Size(35, 13);
            this.Tea_name.TabIndex = 0;
            this.Tea_name.Text = "Name";
            // 
            // Tea_address
            // 
            this.Tea_address.AutoSize = true;
            this.Tea_address.Location = new System.Drawing.Point(134, 85);
            this.Tea_address.Name = "Tea_address";
            this.Tea_address.Size = new System.Drawing.Size(45, 13);
            this.Tea_address.TabIndex = 1;
            this.Tea_address.Text = "Address";
            // 
            // Tea_phone
            // 
            this.Tea_phone.AutoSize = true;
            this.Tea_phone.Location = new System.Drawing.Point(134, 135);
            this.Tea_phone.Name = "Tea_phone";
            this.Tea_phone.Size = new System.Drawing.Size(38, 13);
            this.Tea_phone.TabIndex = 2;
            this.Tea_phone.Text = "Phone";
            this.Tea_phone.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(266, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(266, 85);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextChanged += new System.EventHandler(this.t_address_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(266, 135);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.TextChanged += new System.EventHandler(this.T_phone_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(291, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Tea_phone);
            this.Controls.Add(this.Tea_address);
            this.Controls.Add(this.Tea_name);
            this.Name = "TeacherForm";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tea_name;
        private System.Windows.Forms.Label Tea_address;
        private System.Windows.Forms.Label Tea_phone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
    }
}