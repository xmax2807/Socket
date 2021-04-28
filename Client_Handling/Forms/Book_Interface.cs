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
        public event EventHandler Choose;
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

        //Choose
        public void ChooseBook(object sender, EventArgs e)
        {
            Choose?.Invoke(sender, e);
        }

        private void NameBook_MouseEnter(object sender, EventArgs e)
        {
            this.NameBook.Font = new Font("Maiandra GD", 16F, System.Drawing.FontStyle.Underline| System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBook.ForeColor = Color.Black;
            this.NameBook.Cursor = Cursors.Hand;
        }

        private void NameBook_MouseLeave(object sender, EventArgs e)
        {
            this.NameBook.Font = new Font("Maiandra GD", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBook.ForeColor = Color.White;
            this.NameBook.Cursor = Cursors.Default;
        }
    }
}
