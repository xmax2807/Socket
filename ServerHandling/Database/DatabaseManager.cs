using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;

namespace ServerHandling.Database
{
    public class DatabaseManager
    {

        public static readonly System.Lazy<DatabaseManager> lazySingleton = new System.Lazy<DatabaseManager>();

        public static DatabaseManager Init => lazySingleton.Value;

        private readonly string sqlConnectionString = @"Data Source = NHATLINH\SQLPROJECT;User ID = sa; Password=********;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private readonly SqlConnection sqlConnection;

        public bool InsertNewUser(CommonResource.User user)
        {
            //Hash password to byte[16] by MD5 algorithm
            using (var md5 = MD5.Create())
            {
                var ePassword = md5.ComputeHash(Encoding.ASCII.GetBytes(user.Password));
                return InsertNewUserToDatabase(user.UserName, ePassword);
            }

        }

        public bool CheckLogin(CommonResource.User user)
        {
            using (var md5 = MD5.Create())
            {
                var ePassword = md5.ComputeHash(Encoding.ASCII.GetBytes(user.Password));
                return sqlManager.CheckUserLogin(user.UserName, ePassword);
            }
        }
        private bool InsertNewUserToDatabase(string userName, byte[] password)
        {
            try
            {
                sqlConnection.Open();

                using (var command = new SqlCommand
                {
                    CommandText = "ADDNEWUSER",
                    Connection = sqlConnection,
                    //Use stored procedure
                    CommandType = System.Data.CommandType.StoredProcedure
                })
                {
                    //Add values to parameters
                    command.Parameters.AddWithValue("@user_name", userName);
                    command.Parameters.AddWithValue("@pass_word", password);

                    //Excute the command
                    command.ExecuteNonQuery();
                }

                sqlConnection.Close();

                return true;
            }//If a user exist already or run into an error
            catch (SqlException)
            {
                sqlConnection.Close();
                return false;
            }
        }

        public bool CheckUserLogin(string userName, byte[] password)
        {
            try
            {
                sqlConnection.Open();

                using (var command = new SqlCommand
                {
                    CommandText = "CHECKUSER",
                    Connection = sqlConnection,
                    //Use stored procedure
                    CommandType = System.Data.CommandType.StoredProcedure
                })
                {
                    //Add values to parameters
                    command.Parameters.AddWithValue("@user_name", userName);
                    command.Parameters.AddWithValue("@pass_word", password);

                    //Excute the command
                    //Check user exists
                    var result = command.ExecuteScalar();

                    sqlConnection.Close();

                    if (result != null)
                        return true;
                    return false;
                }
            }//If a user exist already or run into an error
            catch (SqlException)
            {
                sqlConnection.Close();
                return false;
            }
        }
}
