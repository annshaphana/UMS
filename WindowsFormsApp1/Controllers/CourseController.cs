using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers
{
    internal class CourseController
    {
        private static string _connectionString = "Data Source=SchoolDb.db;Version=3;";

        public CourseController(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Add a new course
        public void AddCourse(Course course)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var query = "INSERT INTO Courses (CourseName, Department) VALUES (@Name, @Department)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", course.Name);
                    cmd.Parameters.AddWithValue("@Department", course.Department);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Get all courses
        public List<Course> GetAllCourses()
        {
            var courses = new List<Course>();

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var query = "SELECT CourseID, CourseName, Department FROM Courses";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new Course
                        {
                            Id = Convert.ToInt32(reader["CourseID"]),
                            Name = reader["CourseName"].ToString(),
                            Department = reader["Department"]?.ToString()
                        });
                    }
                }
            }

            return courses;
        }

        // Get a course by ID
        public Course GetCourseById(int id)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var query = "SELECT CourseID, CourseName, Department FROM Courses WHERE CourseID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Course
                            {
                                Id = Convert.ToInt32(reader["CourseID"]),
                                Name = reader["CourseName"].ToString(),
                                Department = reader["Department"]?.ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        // Update a course
        public void UpdateCourse(Course course)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var query = "UPDATE Courses SET CourseName = @Name, Department = @Department WHERE CourseID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", course.Name);
                    cmd.Parameters.AddWithValue("@Department", course.Department);
                    cmd.Parameters.AddWithValue("@Id", course.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete a course
        public void DeleteCourse(int id)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var query = "DELETE FROM Courses WHERE CourseID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
}
}