using System;

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

    public enum TypeOfRequest
    {
        SignUp, SignIn, SearchBooksByID, SearchBooksByName, Error
    }
    
}
