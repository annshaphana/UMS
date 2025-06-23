using System;
using System.Collections.Generic;
using WindowsFormsApp1.Controllers;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using System.Security.Cryptography.X509Certificates;



namespace WindowsFormsApp1.Controllers
{

    public class AdminController
    {
        private static string connectionString = "Data Source=SchoolDb.db;Version=3;";
        private const string AdminUsername = "admin";
        private const string AdminPassword = "*";
        public bool Login(string username, string password) 
        {
            return username == AdminUsername && password == AdminPassword;
        }
        public static void AddAdmin(Models.Admin admin)
        {
            using (var conn = new SQLiteConnection(connectionString)) 
            {
                conn.Open();

                string query = @"INSERT INTO Admin (Name, Email, Phone, UserID)
                         VALUES (@Name, @Email, @Phone, @UserID)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", admin.Name);
                    cmd.Parameters.AddWithValue("@Email", admin.Email);
                    cmd.Parameters.AddWithValue("@Phone", admin.Phone);
                    cmd.Parameters.AddWithValue("@UserID", admin.UserID);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public List<Admin> GetAllAdmins()
        {
            var admins = new List<Admin>();


            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Admin";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            admins.Add(new Admin
                            {
                                AdminID = Convert.ToInt32(reader["AdminID"]),
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                UserID = Convert.ToInt32(reader["UserID"])
                            });
                        }
                    }
                }
            }

            return admins;
            
        }
        public void LoadAdmins() 
        {
            
        }
    }
}
