using System;
using System.Windows.Forms;

namespace ServerHandling.Controls
{
    public partial class AddBookControl : UserControl
    {
        public event System.Action<Database.Book> OnInsertNewBook;

        public AddBookControl()
        {
            InitializeComponent();
        }

        private void insertBookConfirmButton_Click(object sender, EventArgs e)
        {
            var name = insertBookNameBox.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Chưa điền tên sách");
                return;
            }

            var author = insertBookAuthorBox.Text.Trim();
            if (string.IsNullOrEmpty(insertBookAuthorBox.Text.Trim()))
            {
                MessageBox.Show("Chưa điền tác giả");
                return;
            }

            var releasedYear = insertBookReleasedYearBox.Value.Year;
            //if (releasedYear.)
            //{
            //    MessageBox.Show("Chưa điền năm xuất bản");
            //    return;
            //}

            var type = insertBookTypeBox.SelectedText;
            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Chưa chọn thể loại");
                return;
            }

            if (!openFileDialog.CheckFileExists)
            {
                MessageBox.Show("Chưa chọn file sách");
                return;
            }

            OnInsertNewBook?.Invoke(new Database.Book(name, author, type, releasedYear, insertBookDescribeBook.Text, openFileDialog.FileName));
        }
    }
}
