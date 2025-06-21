using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;


namespace WindowsFormsApp1.Controllers
{
    internal class RoomController
    {
        private readonly string _connectionString;

        public RoomController(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Add a new room
        public void AddRoom(Room room)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Rooms (RoomName, RoomType) VALUES (@RoomName, @RoomType)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
                    cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Get all rooms
        public List<Room> GetAllRooms()
        {
            var rooms = new List<Room>();

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT RoomID, RoomName, RoomType FROM Rooms";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms.Add(new Room
                        {
                            Id = Convert.ToInt32(reader["RoomID"]),
                            RoomName = reader["RoomName"].ToString(),
                            RoomType = reader["RoomType"].ToString()
                        });
                    }
                }
            }

            return rooms;
        }

        // Get room by ID
        public Room GetRoomById(int id)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT RoomID, RoomName, RoomType FROM Rooms WHERE RoomID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Room
                            {
                                Id = Convert.ToInt32(reader["RoomID"]),
                                RoomName = reader["RoomName"].ToString(),
                                RoomType = reader["RoomType"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        // Update room
        public void UpdateRoom(Room room)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "UPDATE Rooms SET RoomName = @RoomName, RoomType = @RoomType WHERE RoomID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
                    cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                    cmd.Parameters.AddWithValue("@Id", room.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete room
        public void DeleteRoom(int id)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Rooms WHERE RoomID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
