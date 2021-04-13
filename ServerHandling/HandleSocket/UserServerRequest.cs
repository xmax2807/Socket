using CommonResource;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace ServerHandling
{

    /// <summary>
    /// Class containing utility functions to handle requests in server
    /// </summary>
    public static class UserServerRequest
    {
        //Depend on type of request
        //Quickly get type of object returned by json string
        private static readonly Dictionary<TypeOfRequest, Type> RequestTypesToInforTypes = new Dictionary<TypeOfRequest, Type>
        {
            {TypeOfRequest.SignUp, typeof(User) },
            {TypeOfRequest.SignIn, typeof(User) },
        };

        //Return after deseralizing json string => a type object
        private static object Deseralize(string json, Type type)
        {
            try
            {
                return JsonSerializer.Deserialize(json, type);
            }
            catch (JsonException)
            {
                return null;
            }
        }

        //Handle request as a combination of request enum and json string
        //Return an struct containing information of request
        public static RequestInformation HandleRequest(string request)
        {
            var parts = request.Split('_'); //Format request rq_json

            //Catch ordinary exceptions
            //Can't get from dictionary
            //Out of range of array
            //Can't convert enum
            try
            {
                var json = parts[1]; //Json string

                var rq = (TypeOfRequest)Enum.Parse(typeof(TypeOfRequest), parts[0]);

                var type = RequestTypesToInforTypes[rq];

                return new RequestInformation(rq, Deseralize(json, type));
            }
            catch (Exception)
            {
                return new RequestInformation(TypeOfRequest.Error, null);
            }
        }

    }

    public struct RequestInformation
    {
        public TypeOfRequest type { get; }
        public object information { get; }

        public RequestInformation(TypeOfRequest type, object information)
        {
            this.type = type;
            this.information = information;
        }

        //Indicate this is a valid request
        public bool IsValid => type != TypeOfRequest.Error && information != null;
    }
}
