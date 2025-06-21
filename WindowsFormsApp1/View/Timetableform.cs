using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Controllers;




namespace WindowsFormsApp1
{
    public partial class TimetableForm : Form
    {
        private TimetableController timetableController;

        public TimetableForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=SchoolDb.db;Version=3;";
            timetableController = new TimetableController(connectionString);
            LoadTimetables();
        }

        private void LoadTimetables()
        {
            List<Timetable> timetables = timetableController.GetAllTimetables();
            dgvTimetables.DataSource = timetables;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var timetable = new Timetable
            {
                SubjectID = int.Parse(txtSubjectID.Text),
                TimeSlot = txtTimeSlot.Text,
                RoomID = int.Parse(txtRoomID.Text)
            };

            timetableController.AddTimetable(timetable);
            MessageBox.Show("Added successfully!");
            LoadTimetables();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var timetable = new Timetable
            {
                Id = int.Parse(txtId.Text),
                SubjectID = int.Parse(txtSubjectID.Text),
                TimeSlot = txtTimeSlot.Text,
                RoomID = int.Parse(txtRoomID.Text)
            };

            timetableController.UpdateTimetable(timetable);
            MessageBox.Show("Updated successfully!");
            LoadTimetables();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            timetableController.DeleteTimetable(id);
            MessageBox.Show("Deleted successfully!");
            LoadTimetables();
            ClearFields();
        }

        private void dgvTimetables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTimetables.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtSubjectID.Text = row.Cells["SubjectID"].Value.ToString();
                txtTimeSlot.Text = row.Cells["TimeSlot"].Value.ToString();
                txtRoomID.Text = row.Cells["RoomID"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtId.Clear();
            txtSubjectID.Clear();
            txtTimeSlot.Clear();
            txtRoomID.Clear();
        }
    }
}
