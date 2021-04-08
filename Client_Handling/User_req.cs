using CommonResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Client_Handling
{

    public static class User_req
    {
        public static string Serialize(User user, TypeOfRequest req)
        {
            var json = JsonSerializer.Serialize(user);
            return req.ToString() + '_' + json;
        } 
    }
}
