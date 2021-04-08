using System;
using System.Text.Json;
using System.Text.Json.Serialization;

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
    public class UserRequest
    {
        public User User { get; set; }
    }

    public interface IRequest
    {
        TypeOfRequest TypeOfRequest { get; set; }
    }

    public enum TypeOfRequest
    {
        SIGN_UP, SIGN_IN
    }
}
