using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.View
{
    public partial class AdminForm : Form
    {
        private AdminController adminController=new AdminController();

        public AdminForm()
        {
            InitializeComponent();
            
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            try
            {
                Admin admin = new Admin
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    UserID = int.Parse(txtUserID.Text)
                };

               
                MessageBox.Show("Admin added successfully.");
                ClearForm();
                LoadAdmins();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadAdmins()
        {
            List<Admin> admins = adminController.GetAllAdmins();
            dataGridAdmins.DataSource = admins;
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtUserID.Clear();
        }



        private void AdminForm_Load(object sender, EventArgs e)
        {
            
            LoadAdmins();
        }
        
       
        private void text_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_userid_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
