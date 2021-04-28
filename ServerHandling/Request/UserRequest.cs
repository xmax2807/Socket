using System;
using System.Collections.Generic;

namespace CommonResource
{
    [Serializable]
    public class User
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;

        }
    }

    [Serializable]
    public class Book
    {
        public int ID { get; set; } = 0;
        public string Name { get; }
        public string Author { get; }
        public string Type { get; }
        public string Year { get; }

        public Book(int id, string name, string author, string type, string year)
        {
            this.ID = id;
            this.Name = name;
            this.Author = author;
            this.Type = type;
            this.Year = year;   
        }
    }

    [Serializable]
    public class BookList
    {
        public List<Book> Books { get; }

        public BookList(List<Book> books)
        {
            Books = books;
        }
    }

    public enum TypeOfRequest
    {
        SignUp, SignIn, SearchBooksByID, SearchBooksByName, SearchBooksByAuthor, SearchBookByType,
        ReadBook, DownloadBook, StopConnecting, Error
    }

    public static class TranslateRequest
    {
        public static TypeOfRequest GetRequestType(string request)
        {
            return (TypeOfRequest)Enum.Parse(typeof(TypeOfRequest), request);
        }
    }
}
