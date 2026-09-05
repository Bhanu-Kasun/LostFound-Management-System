using System;
using MySql.Data.MySqlClient;

namespace Lost_And_Found_System
{
    public class DatabaseHelper
    {
        private static string connectionString = 
          "Server=127.0.0.1;Port=3307;Database=lost_found_db;Uid=root;Pwd=Bhanu12345678@;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}