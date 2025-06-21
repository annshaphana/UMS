using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;



namespace WindowsFormsApp1.Controllers
{
    internal class StudentTeacherController
    {
        private readonly string _connectionString;

        public StudentTeacherController(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(StudentTeacher st)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO StudentTeacher (StudentID, TeacherID) VALUES (@StudentID, @TeacherID)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", st.StudentID);
                    cmd.Parameters.AddWithValue("@TeacherID", st.TeacherID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<StudentTeacher> GetAll()
        {
            var list = new List<StudentTeacher>();
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT ID, StudentID, TeacherID FROM StudentTeacher";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new StudentTeacher
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            StudentID = Convert.ToInt32(reader["StudentID"]),
                            TeacherID = Convert.ToInt32(reader["TeacherID"])
                        });
                    }
                }
            }
            return list;
        }

        public void Delete(int id)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "DELETE FROM StudentTeacher WHERE ID = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
