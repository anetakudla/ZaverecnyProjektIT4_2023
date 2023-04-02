using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ZaverecnyProjektIT4_2023
{
    public class SqlRepository
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ZaverecnyProjekt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void RegisterUser(string username, string password)
        {
            byte[] salt;
            byte[] hash;
            HMACSHA512 hmac = new HMACSHA512();

            hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            salt = hmac.Key;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "insert into [User] (Username,PasswordHash,PasswordSalt, Role) values(@username,@hash,@salt,@role)";
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("hash", hash);
                    cmd.Parameters.AddWithValue("salt", salt);
                    cmd.Parameters.AddWithValue("role", "admin");
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }

        public User? LoginUser(string username)
        {
            User? user = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "select * from [User]f where Username=@Username";
                    cmd.Parameters.AddWithValue("Username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User((int)reader["Id"],reader["Username"].ToString(), (byte[])reader["PasswordHash"], (byte[])reader["PasswordSalt"], reader["Role"].ToString());
                        }
                    }
                }
                sqlConnection.Close();
            }
            return user;
        }
    }
}
