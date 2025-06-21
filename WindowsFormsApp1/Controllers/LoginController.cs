using System.Data.SQLite;
using System.Threading.Tasks;



namespace WindowsFormsApp1.Controllers
{
    public class LoginController
    {
        private const string connectionString = "Data Source=SchoolDb.db;Version=3";

        public static async Task<string> AuthenticateAsync(string username, string password)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();
                string query = "SELECT Role FROM Users WHERE Username = @username AND Password = @password AND Role='Admin'";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    var result = await cmd.ExecuteScalarAsync();
                    return result?.ToString();
                }
            }
        }
    }
}
