using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using System.Windows.Forms;



namespace WindowsFormsApp1.Controllers
{
    public class ExamController
    {
        private readonly string _connectionString;

        public ExamController(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Add a new exam
        public void AddExam(Exam exam)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Exams (ExamName, SubjectID) VALUES (@ExamName, @SubjectID)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Get all exams
        public List<Exam> GetAllExams()
        {
            var exams = new List<Exam>();

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT ExamID, ExamName, SubjectID FROM Exams";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        exams.Add(new Exam
                        {
                            Id = Convert.ToInt32(reader["ExamID"]),
                            ExamName = reader["ExamName"].ToString(),
                            SubjectID = Convert.ToInt32(reader["SubjectID"])
                        });
                    }
                }
            }

            return exams;
        }

        // Get exam by ID
        public Exam GetExamById(int id)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT ExamID, ExamName, SubjectID FROM Exams WHERE ExamID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Exam
                            {
                                Id = Convert.ToInt32(reader["ExamID"]),
                                ExamName = reader["ExamName"].ToString(),
                                SubjectID = Convert.ToInt32(reader["SubjectID"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        // Update exam
        public void UpdateExam(Exam exam)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "UPDATE Exams SET ExamName = @ExamName, SubjectID = @SubjectID WHERE ExamID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                    cmd.Parameters.AddWithValue("@Id", exam.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete exam
        public void DeleteExam(int id)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Exams WHERE ExamID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
