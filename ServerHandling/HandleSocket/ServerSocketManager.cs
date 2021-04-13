using System;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;
using CommonResource;
using ServerHandling.Controls;

namespace ServerHandling
{
    class ServerSocketManager
    {
        private readonly List<Socket> clientSocks = new List<Socket>();

        private readonly Socket serverSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private readonly IPEndPoint serverEndPoint;

        private const int port = 11111;

        private const int bufferSize = 1024;

        private readonly byte[] buffer = new byte[bufferSize];

        public event Action<string> OnPrintMessage;

        public event Action<string> OnServerActivity;

        private readonly Database.DatabaseManager databaseManager;

        public ServerSocketManager(Database.DatabaseManager database)
        {
            //Get instance of database
            this.databaseManager = database;

            //Get ip of server
            serverEndPoint = LookupServerIP();
        }

        //Find an available address for the server
        private IPEndPoint LookupServerIP()
        
        {
            var addresses = Dns.GetHostAddresses(String.Empty);
            //Check can connect to the ip
            //System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();

            //Look the first ipv4 and can be connected
            //foreach (var address in addresses)
            //  if (address.AddressFamily == AddressFamily.InterNetwork && ping.Send(address).Status == System.Net.NetworkInformation.IPStatus.Success)
            //    return new IPEndPoint(address, 11111);
            //Can't find any available
            return new IPEndPoint(addresses[addresses.Length - 1], port);
        }

        //Return the server successfully set up or not
        public ServerState SetupServer()
        {
            //If aldready connected
            if (serverSock.Connected)
            {
                OnPrintMessage?.Invoke("Server has been opened already");

                return new ServerState(serverEndPoint, true);
            }

            try
            {
                //Bind an endpoint for server
                serverSock.Bind(serverEndPoint);

                //Can request up to 20 clients
                serverSock.Listen(20);

                //A thread for accept connecting from clients
                //Calback to AcceptConnectingCallback after receving a connection
                serverSock.BeginAccept(new AsyncCallback(AcceptConnectingCallback), null);

                OnPrintMessage?.Invoke("Setup server successfully");

                return new ServerState(serverEndPoint, true);

            } //Catch an socket exception
            catch (SocketException)
            {
                OnPrintMessage?.Invoke("Can't open the connection of server");

                return new ServerState(null, false);
            }
        }

        private void AcceptConnectingCallback(IAsyncResult async)
        {
            var interSock = serverSock.EndAccept(async);

            clientSocks.Add(interSock);

            interSock.BeginReceive(buffer, 0, bufferSize, SocketFlags.None, new AsyncCallback(ReceiveDataCallback), interSock);

            OnPrintMessage?.Invoke("Connected");

            //Continue accepting incoming connections
            serverSock.BeginAccept(new AsyncCallback(AcceptConnectingCallback), null);

        }

        public void ReceiveDataCallback(IAsyncResult async)
        {
            var interSock = async.AsyncState as Socket;

            var requestSize = interSock.EndReceive(async);

            var tempBufffer = new byte[requestSize];

            Array.Copy(buffer, tempBufffer, requestSize);

            HandleRequest(Encoding.ASCII.GetString(tempBufffer));
        }

        public void SendDataToClient()
        {

        }

        public void HandleRequest(string request)
        {
            var result = UserServerRequest.HandleRequest(request);

            if (result.IsValid)
            {
                switch (result.type)
                {
                    case TypeOfRequest.SignUp:
                        HandleSignUp(result.information as User);
                        break;
                    case TypeOfRequest.SignIn:
                        HandleSignIn(result.information as User);
                        break;
                    default:
                        HandleInvalidRequest();
                        break;
                }
            }
            else
            {
                HandleInvalidRequest();
            }
        }

        public void HandleInvalidRequest()
        {

        }

        //Handle sign up request
        //Return the result back to client
        public void HandleSignUp(User user)
        {
            //Get result after inserting to sql
            var result = databaseManager.InsertNewUser(user);

            //Send message back to client depending on the result
            if (result)
            {
                OnServerActivity?.Invoke(user.UserName + " đã đăng ký tài khoản thành công");
            }
            else
            {
                OnServerActivity?.Invoke(user.UserName + " đã đăng ký tài khoản thất bại");
            }
        }

        public void HandleSignIn(User user)
        {
            var result = databaseManager.CheckLogin(user);

            if (result)
            {
                OnServerActivity?.Invoke(user.UserName + " đã đăng nhập tài khoản thành công");
            }
            else
            {
                OnServerActivity?.Invoke(user.UserName + " đã đăng nhập tài khoản thất bại");
            }
        }

        public void DisconnectServer()
        {
            //Sending message to all client that server is closing
            serverSock.Shutdown(SocketShutdown.Both);
            serverSock.Close();

            //Show on UI
            OnPrintMessage("Server has been closed");
        }
    }
}
