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
        private readonly string connectionString;

        public TimetableController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // ✅ Add
        public async Task AddTimetableAsync(Timetable t)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();
                string query = "INSERT INTO Timetable (Day, Subject, Time, Teacher) VALUES (@Day, @Subject, @Time, @Teacher)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Day", t.Day);
                    cmd.Parameters.AddWithValue("@Subject", t.Subject);
                    cmd.Parameters.AddWithValue("@Time", t.Time);
                    cmd.Parameters.AddWithValue("@Teacher", t.Teacher);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        // ✅ Get all
        public async Task<List<Timetable>> GetAllTimetablesAsync()
        {
            var list = new List<Timetable>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();
                string query = "SELECT * FROM Timetable";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(new Timetable
                        {
                            Id = reader.GetInt32(0),
                            Day = reader.GetString(1),
                            Subject = reader.GetString(2),
                            Time = reader.GetString(3),
                            Teacher = reader.GetString(4)
                        });
                    }
                }
            }

            return list;
        }

        // ✅ Update
        public async Task UpdateTimetableAsync(Timetable t)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();
                string query = "UPDATE Timetable SET Day = @Day, Subject = @Subject, Time = @Time, Teacher = @Teacher WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Day", t.Day);
                    cmd.Parameters.AddWithValue("@Subject", t.Subject);
                    cmd.Parameters.AddWithValue("@Time", t.Time);
                    cmd.Parameters.AddWithValue("@Teacher", t.Teacher);
                    cmd.Parameters.AddWithValue("@Id", t.Id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        // ✅ Delete
        public async Task DeleteTimetableAsync(int id)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();
                string query = "DELETE FROM Timetable WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
