namespace Client_Handling
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categories = new System.Windows.Forms.Panel();
            this.categories_pic = new System.Windows.Forms.PictureBox();
            this.button_categories = new System.Windows.Forms.Button();
            this.Discription_categories = new System.Windows.Forms.Label();
            this.Main_option = new System.Windows.Forms.Panel();
            this.BacK_childForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.categories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categories_pic)).BeginInit();
            this.Main_option.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 130);
            this.panel1.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(561, 42);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(60, 31);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            this.Login.MouseEnter += new System.EventHandler(this.Login_MouseEnter);
            this.Login.MouseLeave += new System.EventHandler(this.Login_MouseLeave);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "ID",
            "Title",
            "Author",
            "Genre"});
            this.listBox1.Location = new System.Drawing.Point(938, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(107, 45);
            this.listBox1.TabIndex = 1;
            this.listBox1.TabStop = false;
            this.listBox1.UseTabStops = false;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(626, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 49);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(312, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 38);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Client_Handling.Properties.Resources.Filter;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(106, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 38);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            this.label2.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(3, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Type here to search";
            this.textBox1.GotFocus += new System.EventHandler(this.Search_box_focus);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.LostFocus += new System.EventHandler(this.Search_box_defocus);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImage = global::Client_Handling.Properties.Resources.search_icon_rounded_squares_button_vector_4527540;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(450, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 49);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = global::Client_Handling.Properties.Resources.exit_nocolor;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.Location = new System.Drawing.Point(1171, 31);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(50, 50);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 1;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.pictureBox1_Click);
            this.exit.MouseEnter += new System.EventHandler(this.pictureBox1_MouseHover);
            this.exit.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Wolf in the City Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Library";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categories
            // 
            this.categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categories.BackgroundImage = global::Client_Handling.Properties.Resources.genre_cloud;
            this.categories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.categories.Controls.Add(this.categories_pic);
            this.categories.Controls.Add(this.button_categories);
            this.categories.Controls.Add(this.Discription_categories);
            this.categories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categories.Dock = System.Windows.Forms.DockStyle.Right;
            this.categories.Location = new System.Drawing.Point(892, 130);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(388, 590);
            this.categories.TabIndex = 1;
            this.categories.MouseEnter += new System.EventHandler(this.categories_MouseEnter);
            this.categories.MouseLeave += new System.EventHandler(this.categories_MouseLeave);
            // 
            // categories_pic
            // 
            this.categories_pic.BackColor = System.Drawing.Color.Transparent;
            this.categories_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.categories_pic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categories_pic.Image = global::Client_Handling.Properties.Resources.icon_category_5;
            this.categories_pic.Location = new System.Drawing.Point(0, 202);
            this.categories_pic.Name = "categories_pic";
            this.categories_pic.Size = new System.Drawing.Size(388, 132);
            this.categories_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.categories_pic.TabIndex = 4;
            this.categories_pic.TabStop = false;
            this.categories_pic.MouseEnter += new System.EventHandler(this.categories_MouseEnter);
            this.categories_pic.MouseLeave += new System.EventHandler(this.categories_MouseLeave);
            // 
            // button_categories
            // 
            this.button_categories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_categories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.button_categories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_categories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.button_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_categories.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_categories.Location = new System.Drawing.Point(0, 334);
            this.button_categories.Name = "button_categories";
            this.button_categories.Size = new System.Drawing.Size(388, 96);
            this.button_categories.TabIndex = 3;
            this.button_categories.Text = "Categories";
            this.button_categories.UseVisualStyleBackColor = true;
            this.button_categories.MouseEnter += new System.EventHandler(this.categories_MouseEnter);
            this.button_categories.MouseLeave += new System.EventHandler(this.categories_MouseLeave);
            // 
            // Discription_categories
            // 
            this.Discription_categories.BackColor = System.Drawing.Color.Transparent;
            this.Discription_categories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Discription_categories.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discription_categories.Location = new System.Drawing.Point(0, 430);
            this.Discription_categories.Name = "Discription_categories";
            this.Discription_categories.Size = new System.Drawing.Size(388, 160);
            this.Discription_categories.TabIndex = 2;
            this.Discription_categories.Text = "Find your favorite type of book";
            this.Discription_categories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Discription_categories.MouseEnter += new System.EventHandler(this.categories_MouseEnter);
            this.Discription_categories.MouseLeave += new System.EventHandler(this.categories_MouseLeave);
            // 
            // Main_option
            // 
            this.Main_option.Controls.Add(this.BacK_childForm);
            this.Main_option.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_option.Location = new System.Drawing.Point(0, 130);
            this.Main_option.Name = "Main_option";
            this.Main_option.Size = new System.Drawing.Size(892, 590);
            this.Main_option.TabIndex = 2;
            // 
            // BacK_childForm
            // 
            this.BacK_childForm.BackColor = System.Drawing.Color.Transparent;
            this.BacK_childForm.BackgroundImage = global::Client_Handling.Properties.Resources.exit_nocolor;
            this.BacK_childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BacK_childForm.FlatAppearance.BorderSize = 0;
            this.BacK_childForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BacK_childForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BacK_childForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BacK_childForm.Location = new System.Drawing.Point(5, 5);
            this.BacK_childForm.Name = "BacK_childForm";
            this.BacK_childForm.Size = new System.Drawing.Size(40, 40);
            this.BacK_childForm.TabIndex = 0;
            this.BacK_childForm.UseVisualStyleBackColor = false;
            this.BacK_childForm.Click += new System.EventHandler(this.Back_Click);
            this.BacK_childForm.MouseEnter += new System.EventHandler(this.Back_MouseEnter);
            this.BacK_childForm.MouseLeave += new System.EventHandler(this.Back_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client_Handling.Properties.Resources.wallpaperflare_com_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Main_option);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Online Library";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.categories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categories_pic)).EndInit();
            this.Main_option.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel categories;
        private System.Windows.Forms.Button button_categories;
        private System.Windows.Forms.Label Discription_categories;
        private System.Windows.Forms.PictureBox categories_pic;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Panel Main_option;
        private System.Windows.Forms.Button BacK_childForm;

    }
}

