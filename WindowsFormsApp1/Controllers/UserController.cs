using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;



internal class UserController
{
    private string connectionString = "Data Source=users.db;Version=3;";

    public void AddUser(User user)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Users (Username, Password, Role, IsActive) VALUES (@Username, @Password, @Role, @IsActive)";

            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@IsActive", user.IsActive ? 1 : 0);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public List<User> GetAllUsers()
    {
        var users = new List<User>();

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Users";

            using (var cmd = new SQLiteCommand(query, connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString(),
                            IsActive = Convert.ToInt32(reader["IsActive"]) == 1
                        });
                    }
                }
            }
        }

        return users;
    }
}
