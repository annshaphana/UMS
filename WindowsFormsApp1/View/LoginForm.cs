using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.View;


namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "admin" && password == "1234")
            {

            }

            string role = await LoginController.AuthenticateAsync(username, password);

            if (role == "Admin")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                this.Close();

            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SchoolDb.db;Version=3;";
            Migration.CreateTables(connectionString);
        }
    }
}

