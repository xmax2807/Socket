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

        public Form1()
        {
            InitializeComponent();
            active = connect_toHost1;
            SignUp();
            SignIn();
            ConnectHost();
        }
        public void ConnectHost()
        {
            this.connect_toHost1.connect += (IP, port) => client.connect(IP, port);
            client.OnShow += s => MessageBox.Show(s);
        }
        public void SignUp()
        {
            SignUpBox.OnSignup += (u) => client.sign_up(u.UserName, u.Password);
        }
        public void SignIn()
        {
            SignUpBox.SignIn += (u) => client.sign_in(u.UserName, u.Password);
        }
        private void Search_box_focus(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Equals("Type here to search"))
            {
                this.textBox1.Text = "";
            }
            this.textBox1.ForeColor = Color.Black;
        }

        private void Search_box_defocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                this.textBox1.Text = "Type here to search";
                this.textBox1.ForeColor = Color.Gray;
            }

        }

        // exit
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //disconnect first

            //
            Application.Exit();
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
        //search
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void label2_TextChanged(object sender, EventArgs e)
        {
            this.label2.Text = this.listBox1.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label2.Text = this.listBox1.SelectedItem.ToString();
            this.listBox1.Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if(listBox1.Visible == false)
                this.listBox1.Visible = true;
            else
                this.listBox1.Visible = false;

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Search
                button1.Click += new System.EventHandler(button1_Click);
            }
        }


     
        private void HideAll(object sender)
        {
            if(active.Visible)
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
            HideAll(sender);
            active = this.SignUpBox;
            active.Visible = true;
            
        }

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
            HideAll(sender);
            active = this.connect_toHost1;
            active.Visible = true;
            
        }

        private void Got_info(object sender, EventArgs e)
        {

        }
        //

        //Back
        private void Show_Back(object sender)
        {
        }
        public void Back_Click(object sender, EventArgs e)
        {
            if (this.SignUpBox.Visible)
            {
                this.SignUpBox.Visible = false;
            }
            Show_Back(sender);
        }
        
    }
}
