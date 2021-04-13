namespace ServerHandling.Controls
{
    partial class AddBookControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label addBookNameButton;
            System.Windows.Forms.Label addBookAuthorName;
            System.Windows.Forms.Label addBookReleasedYear;
            System.Windows.Forms.Label insertBookType;
            System.Windows.Forms.Label label1;
            this.insertBookNameBox = new System.Windows.Forms.TextBox();
            this.insertBookAuthorBox = new System.Windows.Forms.TextBox();
            this.insertBookChooseFileButton = new System.Windows.Forms.Button();
            this.insertBookConfirmButton = new System.Windows.Forms.Button();
            this.insertBookTypeBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.insertBookReleasedYearBox = new System.Windows.Forms.DateTimePicker();
            this.insertBookDescribeBook = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            addBookNameButton = new System.Windows.Forms.Label();
            addBookAuthorName = new System.Windows.Forms.Label();
            addBookReleasedYear = new System.Windows.Forms.Label();
            insertBookType = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBookNameButton
            // 
            addBookNameButton.AutoSize = true;
            addBookNameButton.Enabled = false;
            addBookNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addBookNameButton.Location = new System.Drawing.Point(3, 6);
            addBookNameButton.Name = "addBookNameButton";
            addBookNameButton.Size = new System.Drawing.Size(80, 20);
            addBookNameButton.TabIndex = 7;
            addBookNameButton.Text = "Tên Sách";
            // 
            // addBookAuthorName
            // 
            addBookAuthorName.AutoSize = true;
            addBookAuthorName.Enabled = false;
            addBookAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addBookAuthorName.Location = new System.Drawing.Point(3, 77);
            addBookAuthorName.Name = "addBookAuthorName";
            addBookAuthorName.Size = new System.Drawing.Size(101, 20);
            addBookAuthorName.TabIndex = 8;
            addBookAuthorName.Text = "Tên Tác Giả";
            // 
            // addBookReleasedYear
            // 
            addBookReleasedYear.AutoSize = true;
            addBookReleasedYear.Enabled = false;
            addBookReleasedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addBookReleasedYear.Location = new System.Drawing.Point(3, 129);
            addBookReleasedYear.Name = "addBookReleasedYear";
            addBookReleasedYear.Size = new System.Drawing.Size(118, 20);
            addBookReleasedYear.TabIndex = 9;
            addBookReleasedYear.Text = "Năm Xuất Bản";
            // 
            // insertBookType
            // 
            insertBookType.AutoSize = true;
            insertBookType.Enabled = false;
            insertBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            insertBookType.Location = new System.Drawing.Point(3, 195);
            insertBookType.Name = "insertBookType";
            insertBookType.Size = new System.Drawing.Size(68, 20);
            insertBookType.TabIndex = 10;
            insertBookType.Text = "Thể loại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Enabled = false;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 20);
            label1.TabIndex = 17;
            label1.Text = "Mô Tả Sách";
            // 
            // insertBookNameBox
            // 
            this.insertBookNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBookNameBox.Location = new System.Drawing.Point(7, 29);
            this.insertBookNameBox.Name = "insertBookNameBox";
            this.insertBookNameBox.Size = new System.Drawing.Size(370, 26);
            this.insertBookNameBox.TabIndex = 0;
            this.insertBookNameBox.Text = "sdad";
            // 
            // insertBookAuthorBox
            // 
            this.insertBookAuthorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBookAuthorBox.Location = new System.Drawing.Point(7, 100);
            this.insertBookAuthorBox.Name = "insertBookAuthorBox";
            this.insertBookAuthorBox.Size = new System.Drawing.Size(370, 26);
            this.insertBookAuthorBox.TabIndex = 1;
            // 
            // insertBookChooseFileButton
            // 
            this.insertBookChooseFileButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.insertBookChooseFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertBookChooseFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBookChooseFileButton.Location = new System.Drawing.Point(7, 268);
            this.insertBookChooseFileButton.Name = "insertBookChooseFileButton";
            this.insertBookChooseFileButton.Size = new System.Drawing.Size(100, 40);
            this.insertBookChooseFileButton.TabIndex = 5;
            this.insertBookChooseFileButton.Text = "Chọn File Sách";
            this.insertBookChooseFileButton.UseVisualStyleBackColor = false;
            // 
            // insertBookConfirmButton
            // 
            this.insertBookConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.insertBookConfirmButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.insertBookConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertBookConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBookConfirmButton.Location = new System.Drawing.Point(331, 405);
            this.insertBookConfirmButton.Name = "insertBookConfirmButton";
            this.insertBookConfirmButton.Size = new System.Drawing.Size(153, 73);
            this.insertBookConfirmButton.TabIndex = 6;
            this.insertBookConfirmButton.Text = "Thêm";
            this.insertBookConfirmButton.UseVisualStyleBackColor = false;
            this.insertBookConfirmButton.Click += new System.EventHandler(this.insertBookConfirmButton_Click);
            // 
            // insertBookTypeBox
            // 
            this.insertBookTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBookTypeBox.FormattingEnabled = true;
            this.insertBookTypeBox.Items.AddRange(new object[] {
            "Ẩm thực - Nấu ăn",
            "Cổ Tích - Thần Thoại",
            "Công Nghệ Thông Tin",
            "Học Ngoại Ngữ",
            "Hồi Ký - Tuỳ Bút",
            "Huyền bí - Giả Tưởng",
            "Khoa Học - Kỹ Thuật",
            "Kiếm Hiệp - Tiên Hiệp",
            "Kiến Trúc - Xây Dựng",
            "Kinh Tế - Quản Lý",
            "Lịch Sử - Chính Trị",
            "Marketing - Bán hàng",
            "Nông - Lâm - Ngư",
            "Phiêu Lưu - Mạo Hiểm",
            "Tài Liệu Học Tập",
            "Thể Thao - Nghệ Thuật",
            "Thư Viện Pháp Luật",
            "Tiểu Thuyết Phương Tây",
            "Tiểu Thuyết Trung Quốc",
            "Triết Học",
            "Trinh Thám - Hình Sự",
            "Truyện Cười - Tiếu Lâm",
            "Truyện Ma - Truyện Kinh Dị",
            "Truyện Ngắn - Ngôn Tình",
            "Truyên Teen - Tuổi Học Trò",
            "Truyện Tranh",
            "Tử Vi - Phong Thủy",
            "Văn Hóa - Tôn Giáo",
            "Văn Học Việt Nam",
            "Y Học - Sức Khỏe"});
            this.insertBookTypeBox.Location = new System.Drawing.Point(7, 218);
            this.insertBookTypeBox.Name = "insertBookTypeBox";
            this.insertBookTypeBox.Size = new System.Drawing.Size(203, 28);
            this.insertBookTypeBox.TabIndex = 11;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // insertBookReleasedYearBox
            // 
            this.insertBookReleasedYearBox.CustomFormat = "yyyy";
            this.insertBookReleasedYearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBookReleasedYearBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.insertBookReleasedYearBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.insertBookReleasedYearBox.Location = new System.Drawing.Point(7, 152);
            this.insertBookReleasedYearBox.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.insertBookReleasedYearBox.Name = "insertBookReleasedYearBox";
            this.insertBookReleasedYearBox.ShowUpDown = true;
            this.insertBookReleasedYearBox.Size = new System.Drawing.Size(76, 26);
            this.insertBookReleasedYearBox.TabIndex = 13;
            this.insertBookReleasedYearBox.Value = new System.DateTime(2021, 6, 17, 0, 0, 0, 0);
            // 
            // insertBookDescribeBook
            // 
            this.insertBookDescribeBook.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.insertBookDescribeBook.Location = new System.Drawing.Point(3, 23);
            this.insertBookDescribeBook.Name = "insertBookDescribeBook";
            this.insertBookDescribeBook.Size = new System.Drawing.Size(341, 318);
            this.insertBookDescribeBook.TabIndex = 16;
            this.insertBookDescribeBook.Text = "A book about my life";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.insertBookNameBox);
            this.panel1.Controls.Add(this.insertBookAuthorBox);
            this.panel1.Controls.Add(addBookNameButton);
            this.panel1.Controls.Add(this.insertBookReleasedYearBox);
            this.panel1.Controls.Add(addBookAuthorName);
            this.panel1.Controls.Add(this.insertBookChooseFileButton);
            this.panel1.Controls.Add(addBookReleasedYear);
            this.panel1.Controls.Add(this.insertBookTypeBox);
            this.panel1.Controls.Add(insertBookType);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 341);
            this.panel1.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel1.Controls.Add(label1);
            this.flowLayoutPanel1.Controls.Add(this.insertBookDescribeBook);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(449, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(348, 341);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // AddBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.insertBookConfirmButton);
            this.Name = "AddBookControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox insertBookNameBox;
        private System.Windows.Forms.TextBox insertBookAuthorBox;
        private System.Windows.Forms.Button insertBookChooseFileButton;
        private System.Windows.Forms.Button insertBookConfirmButton;
        private System.Windows.Forms.ComboBox insertBookTypeBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DateTimePicker insertBookReleasedYearBox;
        private System.Windows.Forms.RichTextBox insertBookDescribeBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
