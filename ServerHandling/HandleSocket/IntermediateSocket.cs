using System.Net.Sockets;
using System;
using System.Net;
using System.Text;
using CommonResource;
using ServerHandling.Database;
using System.Collections.Generic;
using System.IO;

namespace ServerHandling.HandleSocket
{
    class IntermediateSocket
    {
        private readonly Socket interSocket;

        public event Action<string> OnActivity;

        //Limited size of information received from client
        private const int bufferSize = 1024;

        private readonly byte[] dataBuffer;

        public IntermediateSocket(Socket socket)
        {
            this.interSocket = socket;
            ReceivingData();
        }

        public event System.Action OnDisconnected;

        public const string succesMessage = "1";

        public const string failMessage = "0";

        public static readonly Dictionary<TypeOfRequest, Func<object, object>> handlerTranslator = new Dictionary<TypeOfRequest, Func<object, object>>()
        {
            {TypeOfRequest.SignUp, HandleSignUp},
            {TypeOfRequest.SignIn, HandleSignIn},
            {TypeOfRequest.SearchBooksByID, HandleSearchBookByID},
            {TypeOfRequest.SearchBooksByName, HandleSearchBookByName},
            {TypeOfRequest.SearchBooksByAuthor, HandleSearchBookByAuthor},
            {TypeOfRequest.SearchBookByType, HandleSearchBookByType},
            {TypeOfRequest.ReadBook, HandleReadBook},
            {TypeOfRequest.DownloadBook, HandleDownloadBook},
        };


        public string GetAddress => (interSocket.RemoteEndPoint as IPEndPoint).Address.ToString();

        public void ReceivingData()
        {
            while (interSocket.Connected)
            {
                try
                {
                    //interSocket.BeginReceive(dataBuffer, 0, bufferSize, SocketFlags.None,
                    //new AsyncCallback(ReceiveDataCallback), null);
                    interSocket.Receive(dataBuffer);

                    byte[] replay = HandleRequest(Encoding.Unicode.GetString(dataBuffer));

                    SendingData(replay);
                }
                catch (SocketException)
                {
                    OnDisconnected?.Invoke();
                    return;
                }
            }
        }

        public void SendingData(byte[] data)
        {
            try
            {
                interSocket.Send(data);
            }
            catch (SocketException)
            {
                OnDisconnected?.Invoke();
                return;
            }
        }

        public void Disconnect()
        {
            //Sending message to client that server is closing
            interSocket.Shutdown(SocketShutdown.Both);
            interSocket.Close();
        }

        public byte[] HandleRequest(string request)
        {
            var result = UserServerRequest.HandleRequest(request);

            if (handlerTranslator.TryGetValue(result.Type, out var handler))
            {
                var replay = handler?.Invoke(result.Information);
                if (replay is string)
                    return Encoding.ASCII.GetBytes(replay as string);
                return replay as byte[]; //If not string => byte array
            }

            return Encoding.ASCII.GetBytes(failMessage);
        }

        //Handle sign up request
        //Return the result back to client
        public static string HandleSignUp(object user)
        {
            //Get result after inserting to sql
            var result = DatabaseManager.Init.InsertNewUser(user as User);

            //Send message back to client depending on the result
            if (result)
                return succesMessage;
            else
                return failMessage;
        }

        //Handle sign in request
        //Return the result back to client
        public static string HandleSignIn(object user)
        {
            var result = DatabaseManager.Init.CheckLogin(user as User);

            if (result)
                return succesMessage;
            else
                return failMessage;
        }

        //Handle search books by its id
        //Return a json of BookList object
        public static string HandleSearchBookByID(object ID)
        {
            var books = DatabaseManager.Init.GetBookByID((int)ID);
            return UserServerRequest.SeralizeMessage(books);
        }


        //Handle search books by its name
        //Return a json of BookList object
        public static string HandleSearchBookByName(object bookName)
        {
            var books = DatabaseManager.Init.GetBookByName(bookName as string);
            return UserServerRequest.SeralizeMessage(books);
        }


        //Handle search books by its author
        //Return a json of BookList object
        public static string HandleSearchBookByAuthor(object authorName)
        {
            var books = DatabaseManager.Init.GetBookByAuthor(authorName as string);
            return UserServerRequest.SeralizeMessage(books);
        }

        //Handle search books by its type
        //Return a json of BookList object
        public static string HandleSearchBookByType(object typeName)
        {
            var books = DatabaseManager.Init.GetBookByType(typeName as string);
            return UserServerRequest.SeralizeMessage(books);
        }


        public static string HandleReadBook(object bookID)
        {
            try
            {
                var path = DatabaseManager.Init.GetPathOfBook((int)bookID);
                return File.ReadAllText(path);
            }
            catch (Exception)
            {
                return failMessage;
            }
        }

        public static byte[] HandleDownloadBook(object bookID)
        {
            try
            {
                var path = DatabaseManager.Init.GetPathOfBook((int)bookID);
                return File.ReadAllBytes(path);
            }
            catch (Exception)
            {
                return Encoding.ASCII.GetBytes(failMessage);
            }
        }
    }
}
