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
        public event Action<string,string> connect;
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
        private bool check_input_PortOnly(string input)
        {
            return int.TryParse(input, out _);
        }

        public void Connect_enter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (check_input_IPOnly(this.IP.Text) && check_input_PortOnly(this.port.Text))
                    connect?.Invoke(this.IP.Text, this.port.Text);
                else
                {
                    this.label1.Text = "IP and port must contain number only. Please check again the IP address or port";
                }
            }
        }
    }
}
