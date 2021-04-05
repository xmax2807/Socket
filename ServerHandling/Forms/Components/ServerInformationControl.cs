using System;
using System.Net;
using System.Windows.Forms;

namespace ServerHandling.Forms
{
    public partial class ServerInformationControl : UserControl
    {
        public event Func<IPEndPoint> OnConnectButtonClick;

        public event Action OnDisconnectButtonClick;

        public ServerInformationControl()
        {
            InitializeComponent();
        }

        private void OpenConnectionButton_Click(object sender, EventArgs e)
        {
            var endPoint = OnConnectButtonClick?.Invoke();
            if (endPoint != null)
            {
                serverIPBox.Text = endPoint.Address.ToString();
                serverPortBox.Text = endPoint.Port.ToString();
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            OnDisconnectButtonClick?.Invoke();
        }
    }
}
