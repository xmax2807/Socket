using System.Net.Sockets;
using System;
using System.Net;
using System.Text;
using CommonResource;

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
        }

        public string GetAddress => (interSocket.RemoteEndPoint as IPEndPoint).Address.ToString();

        public void StartReceivingData()
        {
            interSocket.BeginReceive(dataBuffer, 0, bufferSize, SocketFlags.None,
                new AsyncCallback(ReceiveDataCallback), null);
        }

        public void ReceiveDataCallback(IAsyncResult async)
        {
            var interSock = async.AsyncState as Socket;

            var requestSize = interSock.EndReceive(async);

            var tempBufffer = new byte[requestSize];

            Array.Copy(dataBuffer, tempBufffer, requestSize);

            string replay = HandleRequest(Encoding.ASCII.GetString(tempBufffer));
        }


        public string HandleRequest(string request)
        {
            var result = UserServerRequest.HandleRequest(request);

            if (result.IsValid)
            {
                switch (result.Type)
                {
                    case TypeOfRequest.SignUp:
                        HandleSignUp(result.Information as User);
                        break;
                    case TypeOfRequest.SignIn:
                        HandleSignIn(result.Information as User);
                        break;
                    default:
                        HandleInvalidRequest();
                        break;
                }
            }
            return HandleInvalidRequest();
        }

        public string HandleInvalidRequest()
        {
            return "Unidentified error";
        }

        //Handle sign up request
        //Return the result back to client
        public void HandleSignUp(User user)
        {
            //Get result after inserting to sql
            var result = Database.DatabaseManager.Init.InsertNewUser(user);

            //Send message back to client depending on the result
            if (result)
            {
                OnActivity?.Invoke(user.UserName + " đã đăng ký tài khoản thành công");
            }
            else
            {
                OnActivity?.Invoke(user.UserName + " đã đăng ký tài khoản thất bại");
            }
        }

        public void HandleSignIn(User user)
        {
            var result = Database.DatabaseManager.Init.CheckLogin(user);

            if (result)
            {
                OnActivity?.Invoke(user.UserName + " đã đăng nhập tài khoản thành công");
            }
            else
            {
                OnActivity?.Invoke(user.UserName + " đã đăng nhập tài khoản thất bại");
            }
        }

        public void Disconnect()
        {
            //Sending message to all client that server is closing
            interSocket.Shutdown(SocketShutdown.Both);
            interSocket.Close();
            //Show on UI
            OnActivity?.Invoke("Server has been closed");
        }
    }
}
