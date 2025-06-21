using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;


namespace WindowsFormsApp1.Controllers
{
    public class TimetableController
    {
        private readonly string _connectionString;

        public TimetableController(string connectionString)
        {
            _connectionString = connectionString;
        }

        // ✅ Add a new timetable entry
        public void AddTimetable(Timetable timetable)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Timetables (SubjectID, TimeSlot, RoomID) 
                                 VALUES (@SubjectID, @TimeSlot, @RoomID)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@RoomID", timetable.RoomID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ✅ Get all timetable entries
        public List<Timetable> GetAllTimetables()
        {
            var timetables = new List<Timetable>();

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT TimetableID, SubjectID, TimeSlot, RoomID FROM Timetables";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        timetables.Add(new Timetable
                        {
                            Id = Convert.ToInt32(reader["TimetableID"]),
                            SubjectID = Convert.ToInt32(reader["SubjectID"]),
                            TimeSlot = reader["TimeSlot"].ToString(),
                            RoomID = Convert.ToInt32(reader["RoomID"])
                        });
                    }
                }
            }

            return timetables;
        }

        // ✅ Update a timetable entry
        public void UpdateTimetable(Timetable timetable)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = @"UPDATE Timetables 
                                 SET SubjectID = @SubjectID, TimeSlot = @TimeSlot, RoomID = @RoomID
                                 WHERE TimetableID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@RoomID", timetable.RoomID);
                    cmd.Parameters.AddWithValue("@Id", timetable.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ✅ Delete a timetable entry
        public void DeleteTimetable(int id)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Timetables WHERE TimetableID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
