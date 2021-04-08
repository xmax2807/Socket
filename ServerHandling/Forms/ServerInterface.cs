using System;
using System.IO;
using CommonResource;
using System.Net;
using System.Windows.Forms;

namespace ServerHandling
{
    public partial class ServerInterface : Form
    {
        private readonly Database.DatabaseManager databaseManager = new Database.DatabaseManager();

        private readonly ServerSocketManager serverSocketManager = new ServerSocketManager();


        public ServerInterface()
        {
            InitializeComponent();
            SetupReferences();
        }

        private void SetupReferences()
        {
            SetupServerInformationComponent();
        }


        #region ServerInformation
        private void SetupServerInformationComponent()
        {
            //Let control call back to set up server
            serverInformationControl.OnConnectButtonClick += SetupConnectingServer;
            serverInformationControl.OnDisconnectButtonClick += DisconnectServer;
            serverSocketManager.OnConnected += (me) => MessageBox.Show(me);
        }
        public IPEndPoint SetupConnectingServer()
        {
            MessageBoxIcon icon;

            var state = serverSocketManager.SetupServer(out var m, out var endPoint);

            if (state)
                icon = MessageBoxIcon.Information;
            else
                icon = MessageBoxIcon.Error;

            MessageBox.Show(m, "Connect Result", MessageBoxButtons.OK, icon);

            
            //Return to set endpoint to UI
            return endPoint;
        }

        public void DisconnectServer()
        {
            serverSocketManager.DisconnectServer();
        }
        #endregion

        #region BOOK
        private void SetupAddBookComponent()
        {
            
        }

        public void AddNewBook(Database.Book book)
        {
            databaseManager.InsertNewBook(book);
        }
        #endregion

        #region USER
        public void AddUser(User user)
        {
        }


        #endregion
    }
}
