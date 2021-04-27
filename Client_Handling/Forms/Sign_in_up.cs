using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonResource;

namespace Client_Handling.Forms
{
    public partial class Sign_in_up : UserControl
    {
        public event Action<User> OnSignup;
        public event Action<User> SignIn;
        public event EventHandler Close;
        const int MaxAnsiCode = 255;

        public Sign_in_up()
        {
            InitializeComponent();
        }

        private bool check_input(string user, string pass)
        {
            if (user.Length == 0 || pass.Length == 0)
            {
                this.MessageError.Text = "Please fill all above information";
                this.MessageError.Visible = true;
                return false;
            }
            if (!check_character(user) || !check_character(pass))
            {
                this.MessageError.Text = "No Unicode is allowed here, please type your info with only ASCII character";
                this.MessageError.Visible = true;
                return false;
            }
            return true;
        }
        private bool check_character(string input)
        { 
            return input.All(c => c <= MaxAnsiCode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!check_input(this.username.Text, this.password.Text)) return;
            OnSignup?.Invoke(new User(this.username.Text, this.password.Text));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!check_input(this.username.Text, this.password.Text)) return;
            SignIn?.Invoke(new User(this.username.Text, this.password.Text));
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            this.Exit.BackgroundImage = global::Client_Handling.Properties.Resources.exit_color;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            this.Exit.BackgroundImage = global::Client_Handling.Properties.Resources.exit_nocolor;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close?.Invoke(sender, e);
        }

        private void Auto_hideMessage(object sender, EventArgs e)
        {
            if (this.username.Focused || this.password.Focused)
            {
                this.MessageError.Text = "";
            }

        }
    }
}
