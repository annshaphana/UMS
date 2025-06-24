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
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.View
{
    public partial class RoomForm : Form
    {
        private RoomController roomController;
        private int selectedRoomId;

        public RoomForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=SchoolDb.db;Version=3;";
            roomController = new RoomController(connectionString);
            LoadRooms();
        }

        private void LoadRooms()
        {
            var rooms = roomController.GetAllRooms();
            dgvRooms.DataSource = rooms;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            var rooms = roomController.GetAllRooms();
            dgvRooms.DataSource = rooms;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var room = new Room
            {
                RoomName = txtRoomName.Text,
                RoomType = txtRoomType.Text
            };

            roomController.AddRoom(room);
            ClearInputs();
            LoadRooms();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                return;
            }

            var room = new Room
            {
                Id = selectedRoomId,
                RoomName = txtRoomName.Text,
                RoomType = txtRoomType.Text
            };

            roomController.UpdateRoom(room);
            ClearInputs();
            LoadRooms();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1) return;

            roomController.DeleteRoom(selectedRoomId);
            ClearInputs();
            LoadRooms();
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvRooms.Rows[e.RowIndex];
                selectedRoomId = Convert.ToInt32(row.Cells["Id"].Value);
                txtRoomName.Text = row.Cells["RoomName"].Value.ToString();
                txtRoomType.Text = row.Cells["RoomType"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtRoomName.Text = "";
            txtRoomType.Text = "";
            selectedRoomId = -1;
        }
    }
}
