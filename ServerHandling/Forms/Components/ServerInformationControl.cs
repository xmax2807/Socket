using System;
using System.Net;
using System.Windows.Forms;

namespace ServerHandling.Controls
{
    public partial class ServerInformationControl : UserControl
    {
        public event Func<ServerState> OnConnectButtonClick;

        public event Action OnDisconnectButtonClick;

        public ServerInformationControl()
        {
            InitializeComponent();
        }

        //Indicate that the server is being opend or not
        //Call back to main form and get the result
        private void OpenConnectionButton_Click(object sender, EventArgs e)
        {
            //Unable to click in a short time
            openConnectionButton.Enabled = false;
            disconnectButton.Enabled = false;

            var serverState = (ServerState)OnConnectButtonClick?.Invoke();

            if (serverState.state)
            {
                serverIPBox.Text = serverState.endPoint.Address.ToString();
                serverPortBox.Text = serverState.endPoint.Port.ToString();
                serverStateBox.Text = "Connected";
                
                //Can click disconnect
                disconnectButton.Enabled = true;
            }
            else
            {
                serverIPBox.Text = String.Empty;
                serverPortBox.Text = String.Empty;
                serverStateBox.Text = "Closed";

                //Can click connect
                openConnectionButton.Enabled = true;
            }

        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            //Unable to click in a short time
            openConnectionButton.Enabled = false;
            disconnectButton.Enabled = false;

            OnDisconnectButtonClick?.Invoke();

            //Can connect again
            openConnectionButton.Enabled = true;
        }
    }

    public struct ServerState
    {
        public IPEndPoint endPoint { get; }
        public bool state { get; }

        public ServerState(IPEndPoint endPoint, bool state)
        {
            this.endPoint = endPoint;
            this.state = state;
        }
    }
}
