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
        public Action<string> OnRead;
        public Func<string, byte[]> OnDownload;
        private string id;
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
            this.YearText.Text = input.Year;
            id = input.ID.ToString();
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Visible = true;
        }

        //Choose
        public void ChooseBook(object sender, EventArgs e)
        {
            OnRead?.Invoke(id);
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

        private void Download_Button_Enter(object sender, EventArgs e)
        {
            this.Download.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void Download_Button_Leave(object sender, EventArgs e)
        {
            this.Download.Cursor = System.Windows.Forms.Cursors.Default;
        }
        public void DownloadBook(object sender, EventArgs e)
        {

            var fileContent = OnDownload?.Invoke(id);

            if (fileContent == null) return;

            //browse file
            SaveFileDialog path = new SaveFileDialog();
            path.Title = "Save file";
            path.InitialDirectory = @"C:\";
            path.DefaultExt = "txt";
            path.Filter = "txt files (*.txt)|*.txt";
            path.CheckPathExists = true;

            if (path.ShowDialog() == DialogResult.OK)
            {
                System.IO.Stream strm = path.OpenFile(); 
                if (strm != null)
                {
                    strm.Write(fileContent, 0, fileContent.Length);
                    MessageBox.Show("Download sucessfully");
                    strm.Close();
                }
            }
        }


        private void View_Button_Enter(object sender, EventArgs e)
        {
            this.ViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewButton.BackgroundImage = Client_Handling.Properties.Resources.eyeviewColored;

        }
        private void View_Button_Leave(object sender, EventArgs e)
        {
            this.ViewButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewButton.BackgroundImage = Client_Handling.Properties.Resources.eyeview;
        }


    }
}
