using System.Data.SqlClient;


namespace ServerHandling.Database
{
    public class SQLServerManager
    {
        private readonly string sqlConnectionString;

        private readonly SqlConnection sqlConnection;

        public SQLServerManager(string connectString)
        {
            sqlConnection = new SqlConnection(connectString);
        }

        public bool InsertNewBook(Book book)
        {
            try
            {
                sqlConnection.Open();

                //Create a command
                using (var command = new SqlCommand
                {
                    CommandText = "ADDNEWBOOK",
                    Connection = sqlConnection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                })
                {
                    command.Parameters.AddWithValue("@book_name", book.name);
                    command.Parameters.AddWithValue("@author_name", book.authorName);
                    command.Parameters.AddWithValue("@released_year", book.year.ToString());
                    command.Parameters.AddWithValue("@type_name", book.typeName);
                    command.Parameters.AddWithValue("@describe", book.describe);

                    //Rise the stored add procedure
                    command.ExecuteNonQuery();
                }
                sqlConnection.Close();

                return true;
            }
            catch (SqlException)
            {
                sqlConnection.Close();

                return false;
            }
        }

        public bool InsertNewUser(string userName, byte[] password)
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
    }
}
