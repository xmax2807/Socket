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
        private Socket client_socket;

        public event Action<BookList> OnShowBookList;
        public event Action<string> OnLoadBook;

        public event System.Action<string> OnShow;

        private IPEndPoint client_IP;
        public bool is_signin {get; private set;} = false;
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
            if (client_socket == null) return false;

            bool part1 = client_socket.Poll(1000, SelectMode.SelectRead);
            bool part2 = (client_socket.Available == 0);
            bool part3 = client_socket.Connected;
            if ((part1 && part2) || !part3)
                return false;
            else
                return true;
        }
        public bool connect(string IP)
        {
            try
            {
                if (SocketConnected())
                {
                    OnShow?.Invoke("Already connected"); return true;
                }
                
                client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client_socket.Connect(IPAddress.Parse(IP), 11111);
                OnShow?.Invoke("Connect sucessfully");
                return true;
            }
            catch (SocketException e)
            {
                OnShow?.Invoke(e.Message);
                return false;
            }
        }

        public void disconnect()
        {
            try
            {
                if (!SocketConnected()) return;
                client_socket.Send(Encoding.Unicode.GetBytes(TypeOfRequest.StopConnecting.ToString()));
                client_socket.Shutdown(SocketShutdown.Both);
                client_socket.Close();
                client_socket = null;

                is_signin = false;
                OnShow?.Invoke("Disconnected from server");
            }
            catch(SocketException e)
            {
                OnShow?.Invoke(e.Message);
            }
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

        public bool sign_in(string username, string pass)
        {
            var req = User_req.Serialize(new CommonResource.User(username, pass), CommonResource.TypeOfRequest.SignIn);
            try 
            {
                if (send_data(req) == "1")
                {
                    OnShow?.Invoke("Sign in sucessfully");
                    is_signin = true;
                    return true;
                }
                else
                {
                    OnShow?.Invoke("Sign in unsucessfully");
                    is_signin = false;
                    return false;
                }
            }
            catch (SocketException e)
            {
                OnShow?.Invoke(e.Message);
                is_signin = false;
                return false;
            };
        }

        public void Search_Book(string req)
        {
            string data = "";
            try
            {
                data = send_data(req);
                if (data == "NULL")
                    return;
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

        public byte[] download(string req)
        {
            try
            {
                var data = send_data_get_bytes(CommonResource.TypeOfRequest.DownloadBook.ToString() + '|' + req);
                return data;
            }
            catch
            {
                OnShow?.Invoke("Can't download");
                return null;
            }
        }


    }
}
