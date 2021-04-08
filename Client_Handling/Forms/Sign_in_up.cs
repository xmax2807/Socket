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
    }
}
