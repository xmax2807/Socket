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
        private readonly Socket listenSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //Address of listen socket
        private readonly IPEndPoint serverEndPoint;

        //Port of application
        private const int port = 11111;

        //Max number of client approved
        private const int maxClients = 20;

        public event Action<string> OnPrintMessage;

        private readonly StringBuilder serverActivities = new StringBuilder();

        public ServerSocketManager()
        {
            //Get instance of database
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
            try
            {
                //Bind an endpoint for server
                listenSock.Bind(serverEndPoint);

                //Listen socket can accept connection
                listenSock.Listen(maxClients);

                //Start to accept connection
                StartAccepting();

                OnPrintMessage?.Invoke("Setup server successfully");

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
            listenSock.BeginAccept(new AsyncCallback(AcceptConnectingCallback), null);
        }

        private void AcceptConnectingCallback(IAsyncResult async)
        {
            //Callback to continue accepting incoming connections
            StartAccepting();

            var socket = listenSock.EndAccept(async);

            //Create an instance/new thread to handle new client
            var interSock = new IntermediateSocket(socket);

            //Add to manager
            interSocks.Add(interSock);

            serverActivities.Append("Connected by " + interSock.GetAddress);

            interSock.OnActivity += (a) => serverActivities.Append(a);

            interSock.ReceivingData();
        }
    }
}
