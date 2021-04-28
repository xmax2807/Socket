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
    public partial class ListBook_Interface : UserControl
    {
        public event EventHandler Close;
        
        public ListBook_Interface()
        {
            InitializeComponent();
            this.BookContainer.Controls.Add(new Book_Interface());
        }

        private void Back_MouseEnter(object sender, EventArgs e)
        {
            this.Back.BackgroundImage = global::Client_Handling.Properties.Resources.exit_color;
        }
        private void Back_MouseLeave(object sender, EventArgs e)
        {
            this.Back.BackgroundImage = global::Client_Handling.Properties.Resources.exit_nocolor;
        }

        private void Back_click(object sender, EventArgs e)
        {
            Close?.Invoke(sender, e);
        }

        // add books
        public void AddBook(CommonResource.Book input)
        {
            this.BookContainer.Controls.Add(new Book_Interface(input));
        }

        //Choose
        

    }
}
