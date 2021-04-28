using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Handling
{
    public partial class Form1 : Form
    {
        private Time_Client_Manager client = new Time_Client_Manager();
        UserControl active;
        string get_function;

        public Form1()
        {
            InitializeComponent();
            active = connect_toHost1;
            active.Visible = true;

            client.OnShow += s => MessageBox.Show(s);
            client.OnShowBookList += Display_listBook;
            SignUp();
            SignIn();

            ConnectHost();
            client.OnLoadBook += Display_Book;
        }

        public void ConnectHost()
        {
            this.connect_toHost1.connect += (IP) => client.connect(IP);
        }
        public void SignUp()
        {
            SignUpBox.OnSignup += (u) => client.sign_up(u.UserName, u.Password);
        }
        public void SignIn()
        {
            SignUpBox.SignIn += (u) => client.sign_in(u.UserName, u.Password);
        }

        public void Switch_Function()
        {
            string typereq = "";

            switch (get_function)
            {
                case "ID":
                    {
                        typereq = CommonResource.TypeOfRequest.SearchBooksByID.ToString();
                        break;
                    }
                case "Title":
                    {
                        typereq = CommonResource.TypeOfRequest.SearchBooksByName.ToString();
                        break;
                    }
                case "Author":
                    {
                        typereq = CommonResource.TypeOfRequest.SearchBooksByAuthor.ToString();
                        break;
                    }
                case "Genre":
                    {
                        typereq = CommonResource.TypeOfRequest.SearchBookByType.ToString();
                        break;
                    }
                case "Year":
                    {
                        typereq = CommonResource.TypeOfRequest.SearchBooksByAuthor.ToString();// Year;
                        break;
                    }
            }
            client.Search_Book(typereq + "|" + this.SearchBar.Text);
        }

        private void Display_listBook(CommonResource.BookList list)
        {
            //int size_list = client.bookList.Books.Count;
            listBook_Interface1.AddBook(list, client.Read_Book,client.download);
            //for(int i = 0; i < size_list; i++)
            //{
              //  this.listBook_Interface1.AddBook(client.bookList.Books[i]);
            //}
        }

        private void Display_Book(string Data)
        {
            this.bookDisplay1.Visible = true;
            this.bookDisplay1.get_data(Data);
            this.bookDisplay1.BringToFront();
        }



        //Interface + Interaction
        private void Search_box_focus(object sender, EventArgs e)
        {
            if (this.SearchBar.Text.Equals("Type here to search"))
            {
                this.SearchBar.Text = "";
            }
            this.SearchBar.ForeColor = Color.Black;
        }

        private void Search_box_defocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.SearchBar.Text))
            {
                this.SearchBar.Text = "Type here to search";
                this.SearchBar.ForeColor = Color.Gray;
            }

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            exit.BackgroundImage = global::Client_Handling.Properties.Resources.exit_color;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            exit.BackgroundImage = global::Client_Handling.Properties.Resources.exit_nocolor;
        }
        //
        //search-----------------------------------
        private void search_Click(object sender, EventArgs e)
        {
            if (!client.SocketConnected())
            {
                MessageBox.Show("Can't connect to server");
                return;
            }
            HideAll();
            Switch_Function();
            active = this.listBook_Interface1;
            active.Visible = true;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Search
                search_button.Click += new System.EventHandler(search_Click);
            }
        }
        //

        // some fx in text box
        private void label2_TextChanged(object sender, EventArgs e)
        {
            this.label2.Text = this.listBox1.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label2.Text = this.listBox1.SelectedItem.ToString();
            get_function = this.label2.Text;
            this.listBox1.Visible = false;
        }
        //

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if(listBox1.Visible == false)
                this.listBox1.Visible = true;
            else
                this.listBox1.Visible = false;

        }

        private void HideAll()
        {
            active.Visible = false;
        }
        // login
        private void Login_MouseEnter(object sender, EventArgs e)
        {
            this.Login.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }
        private void Login_MouseLeave(object sender, EventArgs e)
        {
            this.Login.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (!client.SocketConnected())
            {
                MessageBox.Show("Please connect the server first");
                return;
            }
            HideAll();
            active = this.SignUpBox;
            active.Visible = true;
            
        }
        //
        // Connect
        private void Connect_MouseEnter(object sender, EventArgs e)
        {
            this.Connect.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void Connect_MouseLeave(object sender, EventArgs e)
        {
            this.Connect.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            HideAll();
            active = this.connect_toHost1;
            active.Visible = true;
            
        }
        //

        //Back
        private void Show_Back(object sender)
        {
        }
        public void Back_Click(object sender, EventArgs e)
        {
            if (active.Visible)
            {
                this.active.Visible = false;
            }
            Show_Back(sender);
        }


        // exit
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //disconnect first

            //
            Application.Exit();
        }

        // Window moving
        private bool isHolding = false;
        private Point Current_Mouse = Point.Empty;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            Current_Mouse = e.Location;
            isHolding = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isHolding = false;
        }
       
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isHolding)
            {
                
                this.Location = new Point(e.X + this.Location.X  - Current_Mouse.X,
                                           e.Y + this.Location.Y - Current_Mouse.Y);
                
            }
        }
    }
}
