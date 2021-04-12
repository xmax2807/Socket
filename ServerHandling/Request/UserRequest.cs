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
        public string Name { get; set; } = null;
        public string Author { get; set; } = null;
        public string Type { get; set; } = null;
        public int ReleasedYear { get; set; } = 0;

        public Book()
        {

        }

    }

    [Serializable]
    public class BookList
    {
        public List<Book> Books { get; set; } = new List<Book>();

        public void AddBook(Book book)
        {
            this.Books.Add(book);
        }
    }

    public enum TypeOfRequest
    {
        SignUp, SignIn, SearchBooksByID, SearchBooksByName, SearchBooksByAuthor, Error
    }
    
}
