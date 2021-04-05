using System;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;

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

        public event System.Action<string> OnConnected;

        private readonly Database.DatabaseManager databaseManager;

        public ServerSocketManager()
        {
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
        public bool SetupServer(out string message, out IPEndPoint endPoint)
        {
            endPoint = this.serverEndPoint;
            //If aldready connected
            if (serverSock.Connected)
            {
                message = "Server has been opened already";
                return true;
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

                message = "Setup server successfully";

                return true;
            } //Catch an exception
            catch (Exception)
            {
                message = "Can't open the connection of server";

                //return a null end point if can't connect
                endPoint = null;

                return false;
            }
        }

        private void AcceptConnectingCallback(IAsyncResult async)
        {
            var interSock = serverSock.EndAccept(async);

            clientSocks.Add(interSock);

            interSock.BeginReceive(buffer, 0, bufferSize, SocketFlags.None, new AsyncCallback(ReceiveDataCallback), null);

            OnConnected?.Invoke("Connected");

            //Continue accepting incoming connections
            serverSock.BeginAccept(new AsyncCallback(AcceptConnectingCallback), null);

        }

        public void ReceiveDataCallback(IAsyncResult async)
        {
            var interSock = async as Socket;

            var requestSize = interSock.EndReceive(async);

            var tempBufffer = new byte[requestSize];

            Array.Copy(buffer, tempBufffer, requestSize);

            var request = Encoding.ASCII.GetString(tempBufffer);
        }



        public void DisconnectServer()
        {
            if (serverSock.Connected)
                serverSock.Close();
        }
    }
}
