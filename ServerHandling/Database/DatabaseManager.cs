using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using CommonResource;

namespace ServerHandling.Database
{
    public class DatabaseManager
    {
        //Use singleton
        private static readonly System.Lazy<DatabaseManager> lazySingleton = new System.Lazy<DatabaseManager>();

        public static DatabaseManager Init => lazySingleton.Value;

        private readonly string sqlConnectionString = @"Data Source=NHATLINH\SQLPROJECT;Initial Catalog=online_library;User ID=sa;Password=1905;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private readonly SqlConnection sqlConnection;

        public DatabaseManager()
        {
            sqlConnection = new SqlConnection(sqlConnectionString);
        }

        public bool InsertNewUser(User user)
        {
            //Hash password to byte[16] by MD5 algorithm
            using (var md5 = MD5.Create())
            {
                var ePassword = md5.ComputeHash(Encoding.ASCII.GetBytes(user.Password));
                return InsertNewUserToDatabase(user.UserName, ePassword);
            }

        }

        public bool CheckLogin(User user)
        {
            //Hash password to byte[16] by MD5 algorithm
            using (var md5 = MD5.Create())
            {
                var ePassword = md5.ComputeHash(Encoding.ASCII.GetBytes(user.Password));
                return CheckUserLoginInDatabase(user.UserName, ePassword);
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
            }
            //If a user exist already or run into an error
            catch (SqlException)
            {
                sqlConnection.Close();
                return false;
            }
        }

        private bool CheckUserLoginInDatabase(string userName, byte[] password)
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

        public BookList BookListFromReader(SqlDataReader reader)
        {
            List<Book> gotBooks = new List<Book>();

            while (reader.Read())
            {
                gotBooks.Add(new Book(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3), reader.GetString(4)));
            }

            reader.Close();

            return new BookList(gotBooks);
        }

        public BookList GetBookByID(int bookId)
        {
            try
            {
                sqlConnection.Open();

                using (var command = new SqlCommand
                {
                    CommandText = "SEARCHBOXBYID",
                    Connection = sqlConnection,
                    //Use stored procedure
                    CommandType = System.Data.CommandType.StoredProcedure
                })
                {
                    //Add values to parameters
                    command.Parameters.AddWithValue("@book_id", bookId);

                    var result = BookListFromReader(command.ExecuteReader()); 

                    sqlConnection.Close();

                    return result;
                }

            }
            catch (SqlException)
            {
                sqlConnection.Close();
                return new BookList(new List<Book>());
            }
        }

        public BookList GetBookByName(string bookName)
        {
            try
            {
                sqlConnection.Open();

                using (var command = new SqlCommand
                {
                    CommandText = "SEARCHBOXBYNAME",
                    Connection = sqlConnection,
                    //Use stored procedure
                    CommandType = System.Data.CommandType.StoredProcedure
                })
                {
                    //Add values to parameters
                    command.Parameters.AddWithValue("@book_name", bookName);

                    var result = BookListFromReader(command.ExecuteReader());

                    sqlConnection.Close();

                    return result;
                }
            }
            catch (SqlException)
            {
                sqlConnection.Close();
                return new BookList(new List<Book>());
            }
        }

        public BookList GetBookByAuthor(string authorName)
        {
            try
            {
                sqlConnection.Open();

                using (var command = new SqlCommand
                {
                    CommandText = "SEARCHBOXBYAUTHOR",
                    Connection = sqlConnection,
                    //Use stored procedure
                    CommandType = System.Data.CommandType.StoredProcedure
                })
                {
                    //Add values to parameters
                    command.Parameters.AddWithValue("@author_name", authorName);

                    var result = BookListFromReader(command.ExecuteReader());

                    sqlConnection.Close();

                    return result;
                }
            }
            catch (SqlException)
            {
                sqlConnection.Close();
                return new BookList(new List<Book>());
            }
        }

        public BookList GetBookByType(string typeName)
        {
            try
            {
                sqlConnection.Open();

                using (var command = new SqlCommand
                {
                    CommandText = "SEARCHBOXBYTYPE",
                    Connection = sqlConnection,
                    //Use stored procedure
                    CommandType = System.Data.CommandType.StoredProcedure
                })
                {
                    //Add values to parameters
                    command.Parameters.AddWithValue("@book_type", typeName);

                    var result = BookListFromReader(command.ExecuteReader());

                    sqlConnection.Close();

                    return result;
                }
            }
            catch (SqlException)
            {
                sqlConnection.Close();
                return new BookList(new List<Book>());
            }
        }

        public string GetPathOfBook(int bookID)
        {
            try
            {
                sqlConnection.Open();

                using (var command = new SqlCommand
                {
                    CommandText = "GETPATHBYID",
                    Connection = sqlConnection,
                    //Use stored procedure
                    CommandType = System.Data.CommandType.StoredProcedure
                })
                {
                    //Add values to parameters
                    command.Parameters.AddWithValue("@book_id", bookID);

                    var path = command.ExecuteScalar();

                    sqlConnection.Close();

                    if (path != null)
                        return path.ToString();
                    return string.Empty;
                }
            }
            catch (SqlException)
            {
                sqlConnection.Close();

                return string.Empty;
            }
        }
    }
}
