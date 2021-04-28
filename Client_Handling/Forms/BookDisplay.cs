using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Handling.Forms
{
    public partial class BookDisplay : UserControl
    {
        public event EventHandler close;
        public BookDisplay()
        {
            InitializeComponent();
        }
        public void get_data(string input)
        {
            this.richTextBox1.Text = input;
        }

        private void Back_enter(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = global::Client_Handling.Properties.Resources.exit_color;
        }
        private void Back_leave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = global::Client_Handling.Properties.Resources.exit_nocolor;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            close?.Invoke(sender, e);
        }
    }

    
}
