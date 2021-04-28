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

        public Action<string> Book_Chosen;
        
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
        public System.Action<string>[] AddBook(CommonResource.BookList input)
        {
            System.Action<string>[] eventLoadBooks = new Action<string>[input.Books.Count];
            for (int i = 0; i < input.Books.Count; i++)
            {
                var newShow = new Book_Interface(input.Books[i]);
                eventLoadBooks[i] = newShow.give_info;
            }
            return eventLoadBooks;
        }

        //Choose
        public string Choose()
        {
            return "";
        }
    }
}
