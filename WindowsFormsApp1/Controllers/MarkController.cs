using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;


namespace WindowsFormsApp1.Controllers
{
    internal class MarkController
    {
        private readonly string _connectionString;

        public MarkController(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Add a new mark
        public void AddMark(Mark mark)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@StudentID, @ExamID, @Score)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
                    cmd.Parameters.AddWithValue("@ExamID", mark.ExamID);
                    cmd.Parameters.AddWithValue("@Score", mark.Score);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Get all marks
        public List<Mark> GetAllMarks()
        {
            var marks = new List<Mark>();

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT MarkID, StudentID, ExamID, Score FROM Marks";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        marks.Add(new Mark
                        {
                            Id = Convert.ToInt32(reader["MarkID"]),
                            StudentID = Convert.ToInt32(reader["StudentID"]),
                            ExamID = Convert.ToInt32(reader["ExamID"]),
                            Score = Convert.ToInt32(reader["Score"])
                        });
                    }
                }
            }

            return marks;
        }

        // Get mark by ID
        public Mark GetMarkById(int id)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT MarkID, StudentID, ExamID, Score FROM Marks WHERE MarkID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Mark
                            {
                                Id = Convert.ToInt32(reader["MarkID"]),
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                ExamID = Convert.ToInt32(reader["ExamID"]),
                                Score = Convert.ToInt32(reader["Score"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        // Update mark
        public void UpdateMark(Mark mark)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "UPDATE Marks SET StudentID = @StudentID, ExamID = @ExamID, Score = @Score WHERE MarkID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
                    cmd.Parameters.AddWithValue("@ExamID", mark.ExamID);
                    cmd.Parameters.AddWithValue("@Score", mark.Score);
                    cmd.Parameters.AddWithValue("@Id", mark.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete mark
        public void DeleteMark(int id)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Marks WHERE MarkID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
