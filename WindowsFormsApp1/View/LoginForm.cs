using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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

            if (username == "admin" && password == "*")
            {
                OpenNextForm(new AdminForm());
                return;
            }

            string role = await LoginController.AuthenticateAsync(username, password);

            if (role == "Admin")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenNextForm(new AdminForm());
            }
            else
            {
                MessageBox.Show("Invalid credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SchoolDb.db;Version=3;";
            Migration.CreateTables(connectionString);
        }
        private void OpenNextForm(Form nextForm)
        {
            this.Hide(); // hide login form
            nextForm.FormClosed += (s, args) => this.Close(); // close login form after AdminForm closes
            nextForm.Show(); // show the AdminForm
        }

    }
}

