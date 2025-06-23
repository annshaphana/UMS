using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models;



namespace WindowsFormsApp1.Controllers
{
    public class StudentController
    {
        private readonly string connectionString;

        public StudentController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            var students = new List<Student>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();
                var query = "SELECT * FROM Students";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        students.Add(new Student
                        {
                            StudentID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2)
                        });
                    }
                }
            }

            return students;
        }

        public async Task AddStudentAsync(Student student)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();
                var query = "INSERT INTO Students (Name, Address) VALUES (@Name, @Address)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateStudentAsync(Student student)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();
                var query = "UPDATE Students SET Name = @Name, Address = @Address WHERE StudentID = @StudentID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteStudentAsync(int studentId)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();
                var query = "DELETE FROM Students WHERE StudentID = @StudentID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}

