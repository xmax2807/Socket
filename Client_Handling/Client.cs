using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using CommonResource;
using System.Threading;

namespace Client_Handling
{
    class Time_Client_Manager
    {
        private Socket client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public event Action<BookList> OnShowBookList;
        public event Action<string> OnLoadBook;

        public event System.Action<string> OnShow;

        private IPEndPoint client_IP;
        public Time_Client_Manager()
        {
            string host_name = Dns.GetHostName();
            client_IP = new IPEndPoint(Dns.GetHostAddresses(host_name)[0], 11111);
        }
        public void set_up_client()
        {
            client_socket.Bind(client_IP);
        }

        
        public bool SocketConnected()
        {
            bool part1 = client_socket.Poll(1000, SelectMode.SelectRead);
            bool part2 = (client_socket.Available == 0);
            bool part3 = client_socket.Connected;
            if ((part1 && part2) || !part3)
                return false;
            else
                return true;
        }
        public void connect(string IP)
        {
            try {
                if (SocketConnected()) return;
                client_socket.Connect(IPAddress.Parse(IP), 11111); 
            }
            catch (SocketException e)
            {
                OnShow?.Invoke(e.Message);
            }
        }

        public static byte[] Encode(string req)
        {
            byte[] buff = Encoding.Unicode.GetBytes(req);
            return buff;
        }
        
        public string send_data(string req)
        {
            client_socket.Send(Encoding.Unicode.GetBytes(req));
            return  Encoding.Unicode.GetString(receive_data());
        }

        public byte[] send_data_get_bytes(string req)
        {
            client_socket.Send(Encoding.Unicode.GetBytes(req));
            return receive_data();
        }

        public byte[] receive_data()
        {
            try
            {
                byte[] buffer = new byte[1024];
                int size_message = 0;

                client_socket.Receive(buffer);

                size_message = int.Parse(Encoding.Unicode.GetString(buffer));
                client_socket.Send(Encoding.Unicode.GetBytes("1"));

                var buffers = new byte[size_message];
                client_socket.Receive(buffers, 0, size_message, SocketFlags.None);

                return buffers;
            }
            catch (SocketException e)
            {
                return null;
            }
        }

        public void sign_up(string username, string pass)
        {
            var req = User_req.Serialize(new CommonResource.User(username, pass), CommonResource.TypeOfRequest.SignUp);
            try {
                if (send_data(req) == "1")
                    OnShow?.Invoke("Sign up sucessfully");
                else
                    OnShow?.Invoke("Sign up unsucessfully");
            }
            catch (SocketException e)
            {
                OnShow?.Invoke(e.Message);
            };
        }

        public void sign_in(string username, string pass)
        {
            var req = User_req.Serialize(new CommonResource.User(username, pass), CommonResource.TypeOfRequest.SignIn);
            try {
                if (send_data(req) == "1")
                    OnShow?.Invoke("Sign up sucessfully");
                else
                    OnShow?.Invoke("Sign up unsucessfully");
            }
            catch (SocketException e)
            {
                OnShow?.Invoke(e.Message);
            };
        }

        public void Search_Book(string req)
        {
            string data = "";
            try
            {
                data = send_data(req);
                OnShowBookList?.Invoke(User_req.Deserialize_list(data));
            }
            catch(SocketException e)
            {
                OnShow?.Invoke(e.Message);
            };
        }

        public void Read_Book(string req)
        {
            string data;
            try
            {
                data = send_data(CommonResource.TypeOfRequest.ReadBook.ToString() + '|' + req);
                OnLoadBook?.Invoke(data);
            }
            catch
            {
                OnLoadBook?.Invoke("Can't load book");
            };
            
        }

        public void download(string req, string path)
        {
            try
            {
                var data = send_data_get_bytes(CommonResource.TypeOfRequest.DownloadBook.ToString() + '|' + req);
                System.IO.File.WriteAllBytes(path + "test.txt", data);
                OnShow?.Invoke("Downloaded");
            }
            catch
            {
                OnShow?.Invoke("Can't download");
                return;
            }
        }


    }
}
