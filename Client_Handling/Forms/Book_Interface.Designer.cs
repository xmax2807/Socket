namespace Client_Handling.Forms
{
    partial class Book_Interface
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
            this.Info_Panel = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.TableLayoutPanel();
            this.Author = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.GenreName = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.YearText = new System.Windows.Forms.Label();
            this.ContainterLabel = new System.Windows.Forms.Panel();
            this.NameBook = new System.Windows.Forms.Label();
            this.ViewButton = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.Button();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.Info_Panel.SuspendLayout();
            this.Info.SuspendLayout();
            this.ContainterLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Info_Panel
            // 
            this.Info_Panel.Controls.Add(this.Info);
            this.Info_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Info_Panel.Location = new System.Drawing.Point(122, 0);
            this.Info_Panel.Name = "Info_Panel";
            this.Info_Panel.Size = new System.Drawing.Size(677, 152);
            this.Info_Panel.TabIndex = 3;
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Info.ColumnCount = 2;
            this.Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Info.Controls.Add(this.Author, 0, 0);
            this.Info.Controls.Add(this.AuthorName, 1, 0);
            this.Info.Controls.Add(this.Genre, 0, 1);
            this.Info.Controls.Add(this.GenreName, 1, 1);
            this.Info.Controls.Add(this.Year, 0, 2);
            this.Info.Controls.Add(this.YearText, 1, 2);
            this.Info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Info.Location = new System.Drawing.Point(0, 28);
            this.Info.Name = "Info";
            this.Info.RowCount = 3;
            this.Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Info.Size = new System.Drawing.Size(677, 124);
            this.Info.TabIndex = 1;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.BackColor = System.Drawing.Color.Transparent;
            this.Author.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Author.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.ForeColor = System.Drawing.Color.Black;
            this.Author.Location = new System.Drawing.Point(3, 0);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(152, 41);
            this.Author.TabIndex = 0;
            this.Author.Text = "Author:";
            this.Author.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.BackColor = System.Drawing.Color.Transparent;
            this.AuthorName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthorName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorName.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorName.ForeColor = System.Drawing.Color.Black;
            this.AuthorName.Location = new System.Drawing.Point(161, 0);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(513, 41);
            this.AuthorName.TabIndex = 1;
            this.AuthorName.Text = "None";
            this.AuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.BackColor = System.Drawing.Color.Transparent;
            this.Genre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Genre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Genre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre.ForeColor = System.Drawing.Color.Black;
            this.Genre.Location = new System.Drawing.Point(3, 41);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(152, 41);
            this.Genre.TabIndex = 2;
            this.Genre.Text = "Genre:";
            this.Genre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenreName
            // 
            this.GenreName.AutoSize = true;
            this.GenreName.BackColor = System.Drawing.Color.Transparent;
            this.GenreName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenreName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenreName.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreName.ForeColor = System.Drawing.Color.Black;
            this.GenreName.Location = new System.Drawing.Point(161, 41);
            this.GenreName.Name = "GenreName";
            this.GenreName.Size = new System.Drawing.Size(513, 41);
            this.GenreName.TabIndex = 3;
            this.GenreName.Text = "None";
            this.GenreName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.BackColor = System.Drawing.Color.Transparent;
            this.Year.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.ForeColor = System.Drawing.Color.Black;
            this.Year.Location = new System.Drawing.Point(3, 82);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(152, 42);
            this.Year.TabIndex = 4;
            this.Year.Text = "Released Year:";
            this.Year.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YearText
            // 
            this.YearText.BackColor = System.Drawing.Color.Transparent;
            this.YearText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearText.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearText.ForeColor = System.Drawing.Color.Black;
            this.YearText.Location = new System.Drawing.Point(161, 82);
            this.YearText.Name = "YearText";
            this.YearText.Size = new System.Drawing.Size(513, 42);
            this.YearText.TabIndex = 5;
            this.YearText.Text = "None";
            this.YearText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContainterLabel
            // 
            this.ContainterLabel.Controls.Add(this.NameBook);
            this.ContainterLabel.Controls.Add(this.ViewButton);
            this.ContainterLabel.Controls.Add(this.Download);
            this.ContainterLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContainterLabel.Location = new System.Drawing.Point(122, 0);
            this.ContainterLabel.Name = "ContainterLabel";
            this.ContainterLabel.Size = new System.Drawing.Size(677, 31);
            this.ContainterLabel.TabIndex = 7;
            // 
            // NameBook
            // 
            this.NameBook.AutoSize = true;
            this.NameBook.BackColor = System.Drawing.Color.Transparent;
            this.NameBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.NameBook.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameBook.Location = new System.Drawing.Point(0, 0);
            this.NameBook.Name = "NameBook";
            this.NameBook.Size = new System.Drawing.Size(110, 34);
            this.NameBook.TabIndex = 2;
            this.NameBook.Text = "Default";
            this.NameBook.Click += new System.EventHandler(this.ChooseBook);
            this.NameBook.MouseEnter += new System.EventHandler(this.NameBook_MouseEnter);
            this.NameBook.MouseLeave += new System.EventHandler(this.NameBook_MouseLeave);
            // 
            // ViewButton
            // 
            this.ViewButton.BackgroundImage = global::Client_Handling.Properties.Resources.eyeview;
            this.ViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ViewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ViewButton.FlatAppearance.BorderSize = 0;
            this.ViewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ViewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewButton.Location = new System.Drawing.Point(595, 0);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(38, 31);
            this.ViewButton.TabIndex = 6;
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ChooseBook);
            this.ViewButton.MouseEnter += new System.EventHandler(this.View_Button_Enter);
            this.ViewButton.MouseLeave += new System.EventHandler(this.View_Button_Leave);
            // 
            // Download
            // 
            this.Download.BackgroundImage = global::Client_Handling.Properties.Resources.download_icon_vector_24;
            this.Download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Download.Dock = System.Windows.Forms.DockStyle.Right;
            this.Download.FlatAppearance.BorderSize = 0;
            this.Download.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Download.Location = new System.Drawing.Point(633, 0);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(44, 31);
            this.Download.TabIndex = 6;
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.DownloadBook);
            this.Download.MouseEnter += new System.EventHandler(this.Download_Button_Enter);
            this.Download.MouseLeave += new System.EventHandler(this.Download_Button_Leave);
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Avatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Avatar.ErrorImage = null;
            this.Avatar.Image = global::Client_Handling.Properties.Resources.book;
            this.Avatar.Location = new System.Drawing.Point(0, 0);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(122, 152);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avatar.TabIndex = 1;
            this.Avatar.TabStop = false;
            // 
            // Book_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ContainterLabel);
            this.Controls.Add(this.Info_Panel);
            this.Controls.Add(this.Avatar);
            this.Name = "Book_Interface";
            this.Size = new System.Drawing.Size(799, 152);
            this.Info_Panel.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.ContainterLabel.ResumeLayout(false);
            this.ContainterLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Panel Info_Panel;
        private System.Windows.Forms.TableLayoutPanel Info;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Label AuthorName;
        private System.Windows.Forms.Label GenreName;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label YearText;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Panel ContainterLabel;
        private System.Windows.Forms.Label NameBook;
    }
}
