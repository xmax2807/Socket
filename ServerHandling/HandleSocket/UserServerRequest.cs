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
            {TypeOfRequest.SignIn, typeof(User) }
            //{TypeOfRequest.SearchBooksByID, typeof(Book) },
            //{TypeOfRequest.SearchBooksByName, typeof(Book) },
            //{TypeOfRequest.SearchBooksByAuthor, typeof(Book) },
            //{TypeOfRequest.SearchBookByType, typeof(Book) }
        };

        //Return after deseralizing json string => a type object
        private static object DeseralizeRequest(string json, Type type)
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

        public static string SeralizeMessage(object infor)
        {
            try
            {
                return JsonSerializer.Serialize(infor);
            }
            catch (JsonException)
            {
                return string.Empty;
            }
        }

        //Handle request as a combination of request enum and json string
        //Return an struct containing information of request
        public static RequestInformation HandleRequest(string request)
        {
            var parts = request.Split('|'); //Format request rq|json

            //Catch ordinary exceptions
            //Can't get from dictionary
            //Out of range of array
            //Can't convert enum
            try
            {
                var inforPart = parts[1]; //Json string or information

                var rq = TranslateRequest.GetRequestType(parts[0]);

                if (RequestTypesToInforTypes.TryGetValue(rq, out var type))
                    return new RequestInformation(rq, DeseralizeRequest(inforPart, type));

                //Not a json string
                //Return itself
                return new RequestInformation(rq, inforPart);
            }
            catch (Exception)
            {
                return new RequestInformation(TypeOfRequest.Error, null);
            }
        }
    }

    public struct RequestInformation
    {
        public TypeOfRequest Type { get; }
        public object Information { get; }

        public RequestInformation(TypeOfRequest type, object information)
        {
            this.Type = type;
            this.Information = information;
        }

        //Indicate this is a valid request
        public bool IsValid => Type != TypeOfRequest.Error && Information != null;
    }
}
