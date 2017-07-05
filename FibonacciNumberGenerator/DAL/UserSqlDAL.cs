using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FibonacciNumberGenerator.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace FibonacciNumberGenerator.DAL
{
    public class UserSqlDAL : IUserDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["FibonacciTest"].ConnectionString;
        private const string SQL_InsertUserInformation = "INSERT into user_information VALUES (@InputNumber, @IPAddress);";
        private const string SQL_DisplayUserInformation = "SELECT TOP 10 * FROM user_information ORDER BY user_id DESC;";


        public bool SaveUserInput(long inputNumber, string ipAddress)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_InsertUserInformation, conn);
                    cmd.Parameters.AddWithValue("@InputNumber", inputNumber);
                    cmd.Parameters.AddWithValue("@IPAddress", ipAddress);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }
            }
            catch (SqlException e)
            {
                throw;
            }

            return false;
        }


        public List<User> DisplayUsers()
        {
            List<User> users = new List<User>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_DisplayUserInformation, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        User user = new User();
                        user.InputNumber = Convert.ToInt32(reader["InputNumber"]);
                        user.IPAddress = Convert.ToString(reader["IPAddress"]);
                        users.Add(user);
                    }
                }
            }
            catch (SqlException e)
            {
                throw;
            }
            return users;
        }
    }
}