using System;
using System.IO;
using CommonResource;
using System.Net;
using System.Windows.Forms;
using ServerHandling.Controls;

namespace ServerHandling
{
    public partial class ServerInterface : Form
    {
        private readonly Database.DatabaseManager databaseManager;

        private readonly ServerSocketManager serverSocketManager;


        public ServerInterface()
        {
            databaseManager = new Database.DatabaseManager();
            serverSocketManager = new ServerSocketManager(databaseManager);
            InitializeComponent();
            SetupReferences();
        }

        private void SetupReferences()
        {
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

        #region MAIN_MENU_BUTTONS
        //Open add book panel
        private void OpenAddBookPanelButton_Click(object sender, EventArgs e)
        {
            ModifyNameOption("Thêm Sách Mới");
            addBookControl.BringToFront();
        }

        //Open delete books panel
        private void OpenDeleteBookButton_Click(object sender, EventArgs e)
        {
            ModifyNameOption("Xóa Sách");
            deleteBookControl.BringToFront();
        }

        //Open user information panel
        private void OpenUserInformationButton_Click(object sender, EventArgs e)
        {
            ModifyNameOption("Thông Tin Người Dùng");
            userInformationControl.BringToFront();
        }

        private void OpenServerInformationButton_Click(object sender, EventArgs e)
        {
            ModifyNameOption("Thông Tin Server");
            serverInformationControl.BringToFront();
        }

        private void ModifyNameOption(string newName)
        {
            nameOfCurrentFunctionBox.Text = newName;
        }

        private void CloseProgramButton_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void HideProgramButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region SERVER_INFORMATION
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
