using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Model;



namespace WindowsFormsApp1.View
{
    public partial class TimetableForm : Form
    {
        private readonly TimetableController timetableControler;
        private TimetableController timetableController;

        public TimetableForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=SchoolDb.db;Version=3;";
            timetableController = new TimetableController(connectionString);
            _ = LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            var data = await timetableController.GetAllTimetablesAsync();
            dgvTimetables.DataSource = null;
            dgvTimetables.DataSource = data;
        }

        private void TimetableForm_Load(object sender, EventArgs e)
        {

        }

        private async Task btnAdd_Click(object sender, EventArgs e)
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
            ClearInputs();
        }

        private async Task btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTimetables.CurrentRow != null)
            {
                var t = (Timetable)dgvTimetables.CurrentRow.DataBoundItem;
                t.Day = txtDay.Text;
                t.Subject = txtSubject.Text;
                t.Time = txtTime.Text;
                t.Teacher = txtTeacher.Text;

                await timetableController.UpdateTimetableAsync(t);
                await LoadDataAsync();
                ClearInputs();
            }
        }

        private async Task btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTimetables.CurrentRow != null)
            {
                var t = (Timetable)dgvTimetables.CurrentRow.DataBoundItem;
                await timetableController.DeleteTimetableAsync(t.Id);
                await LoadDataAsync();
                ClearInputs();
            }
        }
        private void dgvTimetables_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTimetables.CurrentRow != null)
            {
                var t = (Timetable)dgvTimetables.CurrentRow.DataBoundItem;
                txtDay.Text = t.Day;
                txtSubject.Text = t.Subject;
                txtTime.Text = t.Time;
                txtTeacher.Text = t.Teacher;
            }
        }


        private void dgvTimetables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTimetables.CurrentRow.DataBoundItem is  Timetable t)
            {
                txtDay.Text = t.Day;
                txtSubject.Text = t.Subject;
                txtTime.Text = t.Time;
                txtTeacher.Text = t.Teacher;
            }
        }
        private void ClearInputs()
        {
            txtDay.Clear();
            txtSubject.Clear();
            txtTime.Clear();
            txtTeacher.Clear();
        }
    }
    
}
