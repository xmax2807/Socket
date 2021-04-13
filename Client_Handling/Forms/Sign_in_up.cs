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
        public Sign_in_up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnSignup?.Invoke(new User(this.waterMarkTextBox1.Text, this.waterMarkTextBox2.Text));
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SignIn?.Invoke(new User(this.waterMarkTextBox1.Text, this.waterMarkTextBox2.Text));
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            this.Exit.BackgroundImage = global::Client_Handling.Properties.Resources.exit_color;
        }

        private void RePos(object sender, EventArgs e)
        {
            if (!this.Visible) return;
            
            this.waterMarkTextBox1.Location = new Point(this.Width / 2, this.Height / 2);
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            this.Exit.BackgroundImage = global::Client_Handling.Properties.Resources.exit_nocolor;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close.Invoke(sender, e);
  
        }
    }
}
