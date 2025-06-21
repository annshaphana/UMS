using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;



namespace WindowsFormsApp1.Controllers
    {
        internal class SubjectController
        {
            private readonly string _connectionString;

            public SubjectController(string connectionString)
            {
                _connectionString = connectionString;
            }

            // Add a new subject
            public void AddSubject(Subject subject)
            {
                using (var conn = new SQLiteConnection(_connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Subjects (SubjectName, CourseID) VALUES (@Name, @CourseID)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", subject.Name);
                        cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            // Get all subjects
            public List<Subject> GetAllSubjects()
            {
                var subjects = new List<Subject>();

                using (var conn = new SQLiteConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT SubjectID, SubjectName, CourseID FROM Subjects";
                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(new Subject
                            {
                                Id = Convert.ToInt32(reader["SubjectID"]),
                                Name = reader["SubjectName"].ToString(),
                                CourseID = Convert.ToInt32(reader["CourseID"])
                            });
                        }
                    }
                }

                return subjects;
            }

            // Get subject by ID
            public Subject GetSubjectById(int id)
            {
                using (var conn = new SQLiteConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT SubjectID, SubjectName, CourseID FROM Subjects WHERE SubjectID = @Id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Subject
                                {
                                    Id = Convert.ToInt32(reader["SubjectID"]),
                                    Name = reader["SubjectName"].ToString(),
                                    CourseID = Convert.ToInt32(reader["CourseID"])
                                };
                            }
                        }
                    }
                }

                return null;
            }

            // Update subject
            public void UpdateSubject(Subject subject)
            {
                using (var conn = new SQLiteConnection(_connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Subjects SET SubjectName = @Name, CourseID = @CourseID WHERE SubjectID = @Id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", subject.Name);
                        cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);
                        cmd.Parameters.AddWithValue("@Id", subject.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            // Delete subject
            public void DeleteSubject(int id)
            {
                using (var conn = new SQLiteConnection(_connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Subjects WHERE SubjectID = @Id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
    