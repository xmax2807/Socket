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
        private Form active_form;
        private User par;
        public Form1()
        {
            InitializeComponent();
            BacK_childForm.Visible = false;
            this.Main_option.Visible = false;
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
            client.connect();
            client.OnShow += s => this.textBox1.Text = s;
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
            this.listBox1.Visible = true;

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Search
                button1.Click += new System.EventHandler(button1_Click);
            }
        }

        //

        //categories
        private void categories_MouseEnter(object sender, EventArgs e)
        {

            this.categories.BackColor = System.Drawing.Color.FromArgb(80, System.Drawing.Color.White);
        }

        private void categories_MouseLeave(object sender, EventArgs e)
        {
            this.categories.BackColor = System.Drawing.Color.FromArgb(50, System.Drawing.Color.White);
        }

        private void buttonCategories_MouseEnter(object sender, EventArgs e)
        {
            this.categories.BackColor = System.Drawing.Color.FromArgb(80, System.Drawing.Color.White);
        }

        private void buttonCategories_MouseLeave(object sender, EventArgs e)
        {
            this.categories.BackColor = System.Drawing.Color.FromArgb(50, System.Drawing.Color.White);
            this.button_categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
        }


        // login
        private void HideAll(object sender)
        {
            this.categories.Hide();
        }
        private void Create_loginForm(Form ChildForm, object sender)
        {
            if (active_form != null)
                active_form.Close();
            this.Main_option.Visible = true;
            active_form = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            this.Main_option.Controls.Add(ChildForm);
            this.Main_option.Tag = ChildForm;
            ChildForm.Show();
            ChildForm.BringToFront();
            BacK_childForm.Visible = true;
            BacK_childForm.BringToFront();

        }
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
            //Create_loginForm(new Forms.Login(), sender);
        }

        private void Got_info(object sender, EventArgs e)
        {
            
        }
        //

        //Back
        private void Show_Back(object sender)
        {
            this.categories.Show();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            if (active_form != null)
                active_form.Close();
            Show_Back(sender);
            BacK_childForm.Visible = false;
            this.Main_option.Visible = false;
        }

        private void Back_MouseEnter(object sender, EventArgs e)
        {
            this.BacK_childForm.BackgroundImage = global::Client_Handling.Properties.Resources.exit_color;
        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {
            this.BacK_childForm.BackgroundImage = global::Client_Handling.Properties.Resources.exit_nocolor;
        }
        //
    }
}
