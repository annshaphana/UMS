using System.Data.SQLite;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers
{
    internal class TeacherController
    {
        public string AddTeacher(Teacher teacher)  // <-- parameter changed to Teacher model
        {
            using (var DbConn = Dbconfig.GetConnection())
            {
                string addTeacherQuery = "INSERT INTO Teachers(Name, Phone, Address) VALUES(@name, @phone, @address)";
                SQLiteCommand insertTeacherCommand = new SQLiteCommand(addTeacherQuery, DbConn);
                insertTeacherCommand.Parameters.AddWithValue("@name", teacher.Name);
                insertTeacherCommand.Parameters.AddWithValue("@phone", teacher.Phone);
                insertTeacherCommand.Parameters.AddWithValue("@address", teacher.Address);
                insertTeacherCommand.ExecuteNonQuery();
            }
            return "Teacher Added Successfully";
        }
    }
}
