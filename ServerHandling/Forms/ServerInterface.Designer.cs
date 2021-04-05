namespace ServerHandling
{
    partial class ServerInterface
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
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panel3;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            this.addBookButton = new System.Windows.Forms.Button();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.userInformationButton = new System.Windows.Forms.Button();
            this.serverInformationButton = new System.Windows.Forms.Button();
            this.newBook = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.serverInformationControl = new ServerHandling.Forms.ServerInformationControl();
            panel3 = new System.Windows.Forms.Panel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.MediumBlue;
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Enabled = false;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(227, 100);
            panel3.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            flowLayoutPanel1.Controls.Add(this.addBookButton);
            flowLayoutPanel1.Controls.Add(this.deleteBookButton);
            flowLayoutPanel1.Controls.Add(this.userInformationButton);
            flowLayoutPanel1.Controls.Add(this.serverInformationButton);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            flowLayoutPanel1.Size = new System.Drawing.Size(227, 541);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.Color.Transparent;
            this.addBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookButton.FlatAppearance.BorderSize = 0;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.Location = new System.Drawing.Point(3, 53);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(215, 60);
            this.addBookButton.TabIndex = 0;
            this.addBookButton.Text = "Thêm Sách";
            this.addBookButton.UseVisualStyleBackColor = false;
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBookButton.FlatAppearance.BorderSize = 0;
            this.deleteBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBookButton.Location = new System.Drawing.Point(3, 119);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(215, 60);
            this.deleteBookButton.TabIndex = 1;
            this.deleteBookButton.Text = "Xóa Sách";
            this.deleteBookButton.UseVisualStyleBackColor = false;
            // 
            // userInformationButton
            // 
            this.userInformationButton.BackColor = System.Drawing.Color.Transparent;
            this.userInformationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userInformationButton.FlatAppearance.BorderSize = 0;
            this.userInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInformationButton.Location = new System.Drawing.Point(3, 185);
            this.userInformationButton.Name = "userInformationButton";
            this.userInformationButton.Size = new System.Drawing.Size(215, 60);
            this.userInformationButton.TabIndex = 2;
            this.userInformationButton.Text = "Thông Tin Người Dùng";
            this.userInformationButton.UseVisualStyleBackColor = false;
            // 
            // serverInformationButton
            // 
            this.serverInformationButton.BackColor = System.Drawing.Color.Gray;
            this.serverInformationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serverInformationButton.FlatAppearance.BorderSize = 0;
            this.serverInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverInformationButton.Location = new System.Drawing.Point(3, 251);
            this.serverInformationButton.Name = "serverInformationButton";
            this.serverInformationButton.Size = new System.Drawing.Size(224, 60);
            this.serverInformationButton.TabIndex = 3;
            this.serverInformationButton.Text = "Thông Tin Server";
            this.serverInformationButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(flowLayoutPanel1);
            this.panel2.Controls.Add(panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 641);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(227, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 41);
            this.panel1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(649, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(724, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // serverInformationControl
            // 
            this.serverInformationControl.BackColor = System.Drawing.Color.White;
            this.serverInformationControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.serverInformationControl.Location = new System.Drawing.Point(226, 41);
            this.serverInformationControl.Name = "serverInformationControl";
            this.serverInformationControl.Size = new System.Drawing.Size(800, 600);
            this.serverInformationControl.TabIndex = 10;
            // 
            // ServerInterface
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 641);
            this.Controls.Add(this.serverInformationControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1026, 641);
            this.MinimumSize = new System.Drawing.Size(1026, 641);
            this.Name = "ServerInterface";
            this.ShowIcon = false;
            this.Text = "Server";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog newBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.Button userInformationButton;
        private System.Windows.Forms.Button serverInformationButton;
        private System.Windows.Forms.Panel panel1;
        private Forms.ServerInformationControl serverInformationControl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

