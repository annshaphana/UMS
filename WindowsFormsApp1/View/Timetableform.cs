using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class TimetableForm : Form
    {
        private readonly TimetableController timetableController;

        public TimetableForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=SchoolDb.db;Version=3;";
            timetableController = new TimetableController(connectionString);
            _ = LoadDataAsync(); // auto-load
        }

            // ... rest of your methods unchanged



        private async Task LoadDataAsync()
        {
            var list = await timetableController.GetAllTimetablesAsync();
            viewTimetable.DataSource = list;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var t = new Timetable
            {
                Day = txtDay.Text,
                Subject = txtSubject.Text,
                Time = txtTime.Text,
                Teacher = txtTeacher.Text
            };

            await timetableController.AddTimetableAsync(t);
            await LoadDataAsync();
            MessageBox.Show("Added!");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (viewTimetable.CurrentRow != null)
            {
                int id = Convert.ToInt32(viewTimetable.CurrentRow.Cells["Id"].Value);
                await timetableController.DeleteTimetableAsync(id);
                await LoadDataAsync();
                MessageBox.Show("Deleted!");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (viewTimetable.CurrentRow != null)
            {
                int id = Convert.ToInt32(viewTimetable.CurrentRow.Cells["Id"].Value);

                var t = new Timetable
                {
                    Id = id,
                    Day = txtDay.Text,
                    Subject = txtSubject.Text,
                    Time = txtTime.Text,
                    Teacher = txtTeacher.Text
                };

                await timetableController.UpdateTimetableAsync(t);
                await LoadDataAsync();
                MessageBox.Show("Updated!");
            }
        }

        private async void btnView_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private void viewTimetable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = viewTimetable.Rows[e.RowIndex];
                txtDay.Text = row.Cells["Day"].Value.ToString();
                txtSubject.Text = row.Cells["Subject"].Value.ToString();
                txtTime.Text = row.Cells["Time"].Value.ToString();
                txtTeacher.Text = row.Cells["Teacher"].Value.ToString();
            }
        }
    }
}
