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
        private void LoginForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SchoolDb.db;Version=3;";
            Migration.CreateTables(connectionString);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "admin" && password == "*")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenNextForm(new MainPanelForm());
            }

            else
            {
                MessageBox.Show("Invalid credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenNextForm(Form nextForm)
        {
            this.Hide(); // Hide login
            nextForm.FormClosed += (s, args) => this.Close(); // Close login after main form is closed
            nextForm.Show(); // Show MainPanelForm

        }
    }
}

