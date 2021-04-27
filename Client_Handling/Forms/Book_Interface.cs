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
    public partial class Book_Interface : UserControl
    {
        public Book_Interface()
        {
            InitializeComponent();
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Visible = true;
        }

        public Book_Interface(CommonResource.Book input)
        {
            InitializeComponent();

            this.NameBook.Text = input.Name;
            this.AuthorName.Text = input.Author;
            this.GenreName.Text = input.Type;
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Visible = true;
        }
    }
}
