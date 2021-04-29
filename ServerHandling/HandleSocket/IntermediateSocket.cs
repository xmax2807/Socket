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

        public string user = String.Empty;

        public event Action<string> OnActivity;

        //Limited size of information received from client
        private const int bufferSize = 4096;

        private readonly byte[] dataBuffer = new byte[bufferSize];

        public IntermediateSocket(Socket socket)
        {
            this.interSocket = socket;
            handlerTranslator = new Dictionary<TypeOfRequest, Func<object, object>>
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
        }

        public event System.Action<IntermediateSocket> OnDisconnected;

        public const string succesMessage = "1";

        public const string failMessage = "0";

        public readonly Dictionary<TypeOfRequest, Func<object, object>> handlerTranslator;

        public string GetAddress => (interSocket.RemoteEndPoint as IPEndPoint).Address.ToString();

        public bool IsConnected => interSocket.Connected;

        private readonly byte[] waitBuffer = new byte[1024];

        public void ReceivingData()
        {
            while (interSocket.Connected)
            {
                try
                {
                    //interSocket.BeginReceive(dataBuffer, 0, bufferSize, SocketFlags.None,
                    //new AsyncCallback(ReceiveDataCallback), null);
                    int msg = interSocket.Receive(dataBuffer);

                    byte[] replay = HandleRequest(Decode(dataBuffer, 0, msg));
                    if (replay != null)
                        SendingData(replay);
                }
                catch (SocketException)
                {
                    Disconnect();
                    return;
                }
            }
        }

        public static string Decode(byte[] request, int startIndex, int size)
        {
            return Encoding.Unicode.GetString(request, startIndex, size);
        }

        public static byte[] Encode(string msg)
        {
            return Encoding.Unicode.GetBytes(msg);
        }

        public void SendingData(byte[] data)
        {
            try
            {
                int length = data.Length;

                interSocket.Send(Encode(length.ToString()));

                interSocket.Receive(waitBuffer);

                interSocket.Send(data);
            }
            catch (SocketException)
            {
                Disconnect();
                return;
            }
        }

        public void Disconnect()
        {
            //Sending message to client that server is closing
            OnActivity?.Invoke(user + " disconnected");
            OnDisconnected?.Invoke(this);
            if (IsConnected)
                interSocket.Shutdown(SocketShutdown.Both);
            interSocket.Close();
        }

        public byte[] HandleRequest(string request)
        {
            var result = UserServerRequest.HandleRequest(request);

            if (result.Type == TypeOfRequest.StopConnecting)
            {
                Disconnect();
                return null;
            }

            if (handlerTranslator.TryGetValue(result.Type, out var handler))
            {
                var replay = handler?.Invoke(result.Information);
                if (replay is string)
                    return Encode(replay as string);
                return replay as byte[]; //If not string => byte array
            }

            return Encode(failMessage);
        }

        //Handle sign up request
        //Return the result back to client
        public string HandleSignUp(object user)
        {
            //Get result after inserting to sql
            var result = DatabaseManager.Init.InsertNewUser(user as User);

            //Send message back to client depending on the result
            if (result)
            {
                OnActivity?.Invoke(GetAddress + " has created a new account with user name " + (user as User).UserName);
                return succesMessage;
            }
            else
                return failMessage;
        }

        //Handle sign in request
        //Return the result back to client
        public string HandleSignIn(object user)
        {
            var result = DatabaseManager.Init.CheckLogin(user as User);

            if (result)
            {
                this.user = (user as User).UserName;
                OnActivity?.Invoke(GetAddress + " has logged in with user name " + this.user);
                return succesMessage;
            }
            else
                return failMessage;
        }

        //Handle search books by its id
        //Return a json of BookList object
        public string HandleSearchBookByID(object ID)
        {
            try
            {
                var books = DatabaseManager.Init.GetBookByID(int.Parse(ID as string));
                OnActivity?.Invoke(user + " has searched for books by id " + ID);
                return UserServerRequest.SeralizeMessage(books);
            }
            catch
            {
                return failMessage;
            }
        }


        //Handle search books by its name
        //Return a json of BookList object
        public string HandleSearchBookByName(object bookName)
        {
            try
            {
                var books = DatabaseManager.Init.GetBookByName(bookName as string);
                OnActivity?.Invoke(user + " has searched for books by name " + bookName);
                return UserServerRequest.SeralizeMessage(books);
            }
            catch
            {
                return failMessage;
            }
        }


        //Handle search books by its author
        //Return a json of BookList object
        public string HandleSearchBookByAuthor(object authorName)
        {
            try
            {
                var books = DatabaseManager.Init.GetBookByAuthor(authorName as string);
                OnActivity?.Invoke(user + " has searched for books by author " + authorName);
                return UserServerRequest.SeralizeMessage(books);
            }
            catch
            {
                return failMessage;
            }
        }

        //Handle search books by its type
        //Return a json of BookList object
        public string HandleSearchBookByType(object typeName)
        {
            try
            {
                var books = DatabaseManager.Init.GetBookByType(typeName as string);
                OnActivity?.Invoke(user + " has searched for books by genre " + typeName);
                return UserServerRequest.SeralizeMessage(books);
            }
            catch
            {
                return failMessage;
            }
        }

        public string HandleReadBook(object bookID)
        {
            try
            {
                var path = DatabaseManager.Init.GetPathOfBook(int.Parse(bookID as string));
                OnActivity?.Invoke(user + " has read a book whose id " + bookID);
                return File.ReadAllText(path);
            }
            catch (Exception)
            {
                return failMessage;
            }
        }

        public byte[] HandleDownloadBook(object bookID)
        {
            try
            {
                var path = DatabaseManager.Init.GetPathOfBook(int.Parse(bookID as string));
                OnActivity?.Invoke(user + " has downloaded a book whose id " + bookID);
                return File.ReadAllBytes(path);
            }
            catch (Exception)
            {
                return Encode(failMessage);
            }
        }

    }
}
