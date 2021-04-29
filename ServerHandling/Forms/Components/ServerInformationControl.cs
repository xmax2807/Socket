using System;
using System.Net;
using System.Windows.Forms;

namespace ServerHandling.Controls
{
    public partial class ServerInformationControl : UserControl
    {
        public event Func<ServerState> OnConnectButtonClick;

        public event Action OnDisconnectButtonClick;

        delegate void SetTextCallback(string text);

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

            if (serverState.State)
            {
                serverIPBox.Text = serverState.EndPoint.Address.ToString();
                serverPortBox.Text = serverState.EndPoint.Port.ToString();
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


        public void SetNewTask(string newTask)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.serverRecentTasks.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetNewTask);
                this.Invoke(d, new object[] { newTask });
            }
            else
                this.serverRecentTasks.AppendText(newTask + " (" + DateTime.Now + ")\n");
        }

    }

    public struct ServerState
    {
        public IPEndPoint EndPoint { get; }
        public bool State { get; }

        public ServerState(IPEndPoint endPoint, bool state)
        {
            this.EndPoint = endPoint;
            this.State = state;
        }
    }
}
