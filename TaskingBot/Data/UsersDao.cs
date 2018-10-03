using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TaskingBot.Resources.Database;

namespace TaskingBot.Data
{
    class UsersDao
    {

        private static string connectionString = "Data Source = SQL6006.site4now.net; Initial Catalog = DB_A3D6D6_TaskingBot; User Id = DB_A3D6D6_TaskingBot_admin; Password=LuukIsPleb123;";

        public static string SaveUser(ulong userid)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO dbo.RegisteredUsers (UserId, Register) VALUES (@paraUserId,@paraRegister)";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.Add("@paraUserId", SqlDbType.BigInt).Value = userid;
                    command.Parameters.Add("@paraRegister", SqlDbType.Bit).Value = 1;
                    try
                    {
                        sqlConnection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        return "User already exists in database";
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
                return "User has been added in the database";
            }
        }

        public static List<RegisteredUsers> GetUserList()
        {
            var userslist = new List<RegisteredUsers>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM dbo.RegisteredUsers";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            userslist.Add(new RegisteredUsers { UserId = reader.GetInt64(0), Register = reader.GetBoolean(1) });
                        }

                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            return userslist;
            }
        }
    }
}
