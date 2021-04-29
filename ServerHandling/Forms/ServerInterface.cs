using System;
using CommonResource;
using System.Windows.Forms;
using ServerHandling.Controls;
using System.IO;

namespace ServerHandling
{
    public partial class ServerInterface : Form
    {
        private readonly HandleSocket.ServerSocketManager serverSocketManager;

        public ServerInterface()
        {
            serverSocketManager = new HandleSocket.ServerSocketManager();
            Application.ApplicationExit += (o, e) => ExitProgram();
            InitializeComponent();
            SetupServerInformationComponent();
        }
      
        public void ExitProgram()
        {
            DisconnectServer();
            Application.Exit();
        }

    

        private void SetupServerInformationComponent()
        {
            //Let control call back to set up server
            serverInformationControl.OnConnectButtonClick += SetupConnectingServer;
            serverInformationControl.OnDisconnectButtonClick += DisconnectServer;
            serverSocketManager.OnPrintMessage += serverInformationControl.SetNewTask;
        }


        public ServerState SetupConnectingServer()
        {
            return serverSocketManager.SetupServer();
        }

        public void DisconnectServer()
        {
            serverSocketManager.DisconnectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Database.DatabaseManager.Init.GetPathOfBook(4));
        }
    }
}
