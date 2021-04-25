using System;
using CommonResource;
using System.Windows.Forms;
using ServerHandling.Controls;

namespace ServerHandling
{
    public partial class ServerInterface : Form
    {
        private readonly Database.DatabaseManager databaseManager;

        private readonly HandleSocket.ServerSocketManager serverSocketManager;


        public ServerInterface()
        {
            serverSocketManager = new HandleSocket.ServerSocketManager();
            InitializeComponent();
            SetupServerInformationComponent();
        }

        public void PrintMessageFromComponent()
        {

        }

        public void ExitProgram()
        {
            DisconnectServer();
            Application.Exit();
        }

        private void CloseProgramButton_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void HideProgramButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SetupServerInformationComponent()
        {
            //Let control call back to set up server
            serverInformationControl.OnConnectButtonClick += SetupConnectingServer;
            serverInformationControl.OnDisconnectButtonClick += DisconnectServer;
            serverSocketManager.OnPrintMessage += (m) => MessageBox.Show(m);
        }

        public ServerState SetupConnectingServer()
        {
            return serverSocketManager.SetupServer();
        }

        public void DisconnectServer()
        {
        }
    }
}
