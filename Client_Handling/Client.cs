﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Client_Handling
{
    public interface Req
    {
        string Request { get; set; }
    }
    class User   {
        public string UserName { set; get; } public string Password { set; get; }
        public User(string user, string pass) { UserName = user; Password = pass; }
        
    }

    class StateObject
    {
        public Socket workSocket = null;
        // Size of receive buffer.  
        public const int BufferSize = 256;
        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];
        // Received data string.  
        public StringBuilder sb = new StringBuilder();
    }
    class Time_Client_Manager
    {
        private Socket client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public event System.Action<string> OnShow;

        private IPEndPoint client_IP;
            public Time_Client_Manager()
        {
            string host_name = Dns.GetHostName();
            client_IP = new IPEndPoint(Dns.GetHostAddresses(host_name)[0], 1234);
        }
            public void set_up_client()
        {
            client_socket.Bind(client_IP);
        }

        public void OnDataReceived(IAsyncResult asyn) {
            try
            {
                // Retrieve the state object and the client socket
                // from the asynchronous state object.  
                StateObject state = (StateObject)asyn.AsyncState;
                Socket client = state.workSocket;
                string response;
                // Read data from the remote device.  
                int bytesRead = client.EndReceive(asyn);

                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.  
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    // Get the rest of the data.  
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(OnDataReceived), state);
                }
                else
                {
                    // All the data has arrived; put it in response.  
                    if (state.sb.Length > 1)
                    {
                        response = state.sb.ToString();
                    }
                    // Signal that all bytes have been received.  
                    client.Shutdown(SocketShutdown.Both); client.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private static void Send_callback(IAsyncResult asyn)
        {
            try
            {
                Socket handler = (Socket)asyn.AsyncState;

                int byteSent = handler.EndSend(asyn);
                handler.Shutdown(SocketShutdown.Both); handler.Close();
            }catch(Exception e) {  }
        }
        public void connect()
        {
            try { client_socket.Connect(IPAddress.Parse("10.124.1.107"), 11111); } 
            catch (SocketException e) { OnShow?.Invoke(e.Message); }
        }
        public void send_data(string req)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(req);

            client_socket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(Send_callback), null);
        }
        public void receive_data()
        {
            StateObject state = new StateObject();
            state.workSocket = client_socket;
            client_socket.BeginReceive(state.buffer,0,StateObject.BufferSize, SocketFlags.None, new AsyncCallback(OnDataReceived), null);
        }

    }
}