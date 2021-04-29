using System;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;
using ServerHandling.Controls;

namespace ServerHandling.HandleSocket
{
    /// <summary>
    /// Use to manage listen socket of server.
    /// Create a new socket for every connection
    /// </summary>
    class ServerSocketManager
    {
        //Containing sockets communicating with clients
        private readonly List<IntermediateSocket> interSocks = new List<IntermediateSocket>();

        //A socket listening requests to connect
        private Socket listenSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //Address of listen socket
        private readonly IPEndPoint serverEndPoint;

        //Port of application
        private const int port = 11111;

        //Max number of client approved
        private const int maxClients = 20;

        private bool isOpened = false;

        public event Action<string> OnPrintMessage;

        public ServerSocketManager()
        {
            //Get ip of server
            serverEndPoint = LookupServerIP();
        }

        //Find an available address for the server
        private IPEndPoint LookupServerIP()

        {
            var addresses = Dns.GetHostAddresses(String.Empty);
            return new IPEndPoint(addresses[addresses.Length - 1], port);
        }

        //Return the server successfully set up or not
        public ServerState SetupServer()
        {
            try
            {
                //Socket is opened
                if (!isOpened)
                {
                    //Mark that server is opened
                    isOpened = true;

                    listenSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    listenSock.LingerState = new LingerOption(false, 0);

                    //Bind an endpoint for server
                    listenSock.Bind(serverEndPoint);

                    //Listen socket can accept connection
                    listenSock.Listen(maxClients);

                    //Start to accept connection
                    StartAccepting();

                    OnPrintMessage?.Invoke("Setup server successfully");
                }
                else
                    OnPrintMessage?.Invoke("try to setup server but it's already opened");


                return new ServerState(serverEndPoint, true);

            } //Catch an socket exception
            catch (SocketException)
            {
                OnPrintMessage?.Invoke("Can't open the connection of server");
                return new ServerState(null, false);
            }
        }

        //Creat a thread for accept connecting from clients
        //Calback to AcceptConnectingCallback after receving a connection
        private void StartAccepting()
        {
            try
            {
                listenSock.BeginAccept(new AsyncCallback(AcceptConnectingCallback), null);
            }
            catch (SocketException s)
            {
                OnPrintMessage?.Invoke(s.Message);
                return;
            }
        }

        public void DisconnectAll()
        {
            if (isOpened)
            {
                //Mark that the connection is closed
                isOpened = false;

                foreach (var conn in interSocks)
                    conn.Disconnect();
                interSocks.Clear();

                listenSock.Close();
                listenSock = null;

                OnPrintMessage?.Invoke("Disconnnect all client");
            }
        }

        private void AcceptConnectingCallback(IAsyncResult async)
        {
            if (listenSock != null)
            {
                //Callback to continue accepting incoming connections
                StartAccepting();

                var socket = listenSock.EndAccept(async);

                //Create an instance/new thread to handle new client
                var interSock = new IntermediateSocket(socket);


                //Add to manager
                interSocks.Add(interSock);

                OnPrintMessage?.Invoke("Connected by " + interSock.GetAddress);

                interSock.OnActivity += OnPrintMessage;

                interSock.OnDisconnected += (a) => interSocks.Remove(a);

                interSock.ReceivingData();
            }
        }
    }
}
