using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers
{
    internal class StudentController
    {
        private readonly string connectionString;

        public StudentController(string connectionString)
        {
            this.connectionString = connectionString; // Fixed assignment
        }

        // Add a new student
        public async Task AddStudentAsync(Models.Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));
            if (string.IsNullOrWhiteSpace(student.Name))
                throw new ArgumentException("Name cannot be empty.");
            if (string.IsNullOrWhiteSpace(student.Address))
                throw new ArgumentException("Address cannot be empty.");

            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();

                string sql = "INSERT INTO Students (Name, Address) VALUES (@Name, @Address)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        // Get all students
        public async Task<List<Models.Student>> GetAllStudentsAsync()
        {
            var students = new List<Models.Student>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();

                string sql = "SELECT Id, Name, Address FROM Students";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var student = new Models.Student
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Address = reader["Address"].ToString()
                        };
                        students.Add(student);
                    }
                }
            }

            return students;
        }

        // Get student by Id
        public async Task<Models.Student> GetStudentByIdAsync(int id)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();

                string sql = "SELECT Id, Name, Address FROM Students WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new Models.Student
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Address = reader["Address"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        // Update student
        public async Task UpdateStudentAsync(Models.Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));
            if (string.IsNullOrWhiteSpace(student.Name))
                throw new ArgumentException("Name cannot be empty.");
            if (string.IsNullOrWhiteSpace(student.Address))
                throw new ArgumentException("Address cannot be empty.");

            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();

                string sql = "UPDATE Students SET Name = @Name, Address = @Address WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@Id", student.Id);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        // Delete student by Id
        public async Task DeleteStudentAsync(int id)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();

                string sql = "DELETE FROM Students WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
