using CommonResource;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace ServerHandling
{
    public static class UserServerRequest
    {
        public static User DeseralizeUser(string json)
        {
            return JsonSerializer.Deserialize<User>(json);
        }
    }
}
