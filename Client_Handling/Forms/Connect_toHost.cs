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
    public partial class Connect_toHost : UserControl
    {
        public event Action<string> connect;
        public event EventHandler Close;
        public Connect_toHost()
        {
            InitializeComponent();
            
        }

        private bool check_input_IPOnly(string input)
        {
            string[] partitions;
            partitions = input.Split('.');
            foreach (var part in partitions)
            {
                if (part.Length > 3)
                    return false;
                bool isNumberic = int.TryParse(part, out _);
                if (!isNumberic) return false;
            }
            return true;
        }

        public void Connect_enter(object sender, KeyEventArgs e)
        {
            Auto_Hide();
            if(e.KeyCode == Keys.Enter)
            {
                if (check_input_IPOnly(this.IP.Text))
                    connect?.Invoke(this.IP.Text);
                else
                {
                    this.label1.Text = "IP must contain number only. Please check again the IP address";
                }
            }
        }

        private void Auto_Hide()
        {
            if (this.IP.Focused)
            {
                this.label1.Text = "";
            }
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            this.Exit.BackgroundImage = global::Client_Handling.Properties.Resources.exit_color;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            this.Exit.BackgroundImage = global::Client_Handling.Properties.Resources.exit_nocolor;
        }

        private void Exit_click(object sender, EventArgs e)
        {
            Close?.Invoke(sender, e);
        }
    }
}
