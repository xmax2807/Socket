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
            System.Windows.Forms.Panel mainPanel;
            this.openAddBookButton = new System.Windows.Forms.Button();
            this.openDeleteBookButton = new System.Windows.Forms.Button();
            this.openUserInformationButton = new System.Windows.Forms.Button();
            this.openServerInformationButton = new System.Windows.Forms.Button();
            this.serverInformationControl = new ServerHandling.Controls.ServerInformationControl();
            this.deleteBookControl = new ServerHandling.Controls.DeleteBookControl();
            this.addBookControl = new ServerHandling.Controls.AddBookControl();
            this.userInformationControl = new ServerHandling.Controls.UserInformationControl();
            this.newBook = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameOfCurrentFunctionBox = new System.Windows.Forms.TextBox();
            this.hideProgramButton = new System.Windows.Forms.Button();
            this.closeProgramButton = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            mainPanel = new System.Windows.Forms.Panel();
            flowLayoutPanel1.SuspendLayout();
            mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.MediumBlue;
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Enabled = false;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(200, 60);
            panel3.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            flowLayoutPanel1.Controls.Add(this.openAddBookButton);
            flowLayoutPanel1.Controls.Add(this.openDeleteBookButton);
            flowLayoutPanel1.Controls.Add(this.openUserInformationButton);
            flowLayoutPanel1.Controls.Add(this.openServerInformationButton);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            flowLayoutPanel1.Size = new System.Drawing.Size(200, 500);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // openAddBookButton
            // 
            this.openAddBookButton.BackColor = System.Drawing.Color.Transparent;
            this.openAddBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openAddBookButton.FlatAppearance.BorderSize = 0;
            this.openAddBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openAddBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAddBookButton.Location = new System.Drawing.Point(3, 53);
            this.openAddBookButton.Name = "openAddBookButton";
            this.openAddBookButton.Size = new System.Drawing.Size(197, 60);
            this.openAddBookButton.TabIndex = 0;
            this.openAddBookButton.Text = "Thêm Sách";
            this.openAddBookButton.UseVisualStyleBackColor = false;
            this.openAddBookButton.Click += new System.EventHandler(this.OpenAddBookPanelButton_Click);
            // 
            // openDeleteBookButton
            // 
            this.openDeleteBookButton.BackColor = System.Drawing.Color.Transparent;
            this.openDeleteBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openDeleteBookButton.FlatAppearance.BorderSize = 0;
            this.openDeleteBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openDeleteBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openDeleteBookButton.Location = new System.Drawing.Point(3, 119);
            this.openDeleteBookButton.Name = "openDeleteBookButton";
            this.openDeleteBookButton.Size = new System.Drawing.Size(197, 60);
            this.openDeleteBookButton.TabIndex = 1;
            this.openDeleteBookButton.Text = "Xóa Sách";
            this.openDeleteBookButton.UseVisualStyleBackColor = false;
            this.openDeleteBookButton.Click += new System.EventHandler(this.OpenDeleteBookButton_Click);
            // 
            // openUserInformationButton
            // 
            this.openUserInformationButton.BackColor = System.Drawing.Color.Transparent;
            this.openUserInformationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openUserInformationButton.FlatAppearance.BorderSize = 0;
            this.openUserInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openUserInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openUserInformationButton.Location = new System.Drawing.Point(3, 185);
            this.openUserInformationButton.Name = "openUserInformationButton";
            this.openUserInformationButton.Size = new System.Drawing.Size(197, 60);
            this.openUserInformationButton.TabIndex = 2;
            this.openUserInformationButton.Text = "Thông Tin Người Dùng";
            this.openUserInformationButton.UseVisualStyleBackColor = false;
            this.openUserInformationButton.Click += new System.EventHandler(this.OpenUserInformationButton_Click);
            // 
            // openServerInformationButton
            // 
            this.openServerInformationButton.BackColor = System.Drawing.Color.Transparent;
            this.openServerInformationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openServerInformationButton.FlatAppearance.BorderSize = 0;
            this.openServerInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openServerInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openServerInformationButton.Location = new System.Drawing.Point(3, 251);
            this.openServerInformationButton.Name = "openServerInformationButton";
            this.openServerInformationButton.Size = new System.Drawing.Size(197, 60);
            this.openServerInformationButton.TabIndex = 3;
            this.openServerInformationButton.Text = "Thông Tin Server";
            this.openServerInformationButton.UseVisualStyleBackColor = false;
            this.openServerInformationButton.Click += new System.EventHandler(this.OpenServerInformationButton_Click);
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(this.serverInformationControl);
            mainPanel.Controls.Add(this.deleteBookControl);
            mainPanel.Controls.Add(this.addBookControl);
            mainPanel.Controls.Add(this.userInformationControl);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            mainPanel.Location = new System.Drawing.Point(200, 60);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(800, 500);
            mainPanel.TabIndex = 14;
            // 
            // serverInformationControl
            // 
            this.serverInformationControl.BackColor = System.Drawing.Color.White;
            this.serverInformationControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.serverInformationControl.Location = new System.Drawing.Point(0, 0);
            this.serverInformationControl.Name = "serverInformationControl";
            this.serverInformationControl.Size = new System.Drawing.Size(800, 500);
            this.serverInformationControl.TabIndex = 2;
            // 
            // deleteBookControl
            // 
            this.deleteBookControl.BackColor = System.Drawing.Color.White;
            this.deleteBookControl.Location = new System.Drawing.Point(0, 0);
            this.deleteBookControl.Name = "deleteBookControl";
            this.deleteBookControl.Size = new System.Drawing.Size(800, 500);
            this.deleteBookControl.TabIndex = 1;
            // 
            // addBookControl
            // 
            this.addBookControl.BackColor = System.Drawing.Color.White;
            this.addBookControl.Location = new System.Drawing.Point(0, 0);
            this.addBookControl.Name = "addBookControl";
            this.addBookControl.Size = new System.Drawing.Size(800, 500);
            this.addBookControl.TabIndex = 0;
            // 
            // userInformationControl
            // 
            this.userInformationControl.BackColor = System.Drawing.Color.White;
            this.userInformationControl.Location = new System.Drawing.Point(0, 0);
            this.userInformationControl.Name = "userInformationControl";
            this.userInformationControl.Size = new System.Drawing.Size(800, 500);
            this.userInformationControl.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.nameOfCurrentFunctionBox);
            this.panel1.Controls.Add(this.hideProgramButton);
            this.panel1.Controls.Add(panel3);
            this.panel1.Controls.Add(this.closeProgramButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 60);
            this.panel1.TabIndex = 9;
            // 
            // nameOfCurrentFunctionBox
            // 
            this.nameOfCurrentFunctionBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.nameOfCurrentFunctionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOfCurrentFunctionBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameOfCurrentFunctionBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameOfCurrentFunctionBox.Enabled = false;
            this.nameOfCurrentFunctionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfCurrentFunctionBox.Location = new System.Drawing.Point(200, 31);
            this.nameOfCurrentFunctionBox.Name = "nameOfCurrentFunctionBox";
            this.nameOfCurrentFunctionBox.Size = new System.Drawing.Size(800, 29);
            this.nameOfCurrentFunctionBox.TabIndex = 14;
            this.nameOfCurrentFunctionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hideProgramButton
            // 
            this.hideProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hideProgramButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hideProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideProgramButton.Location = new System.Drawing.Point(900, 0);
            this.hideProgramButton.Name = "hideProgramButton";
            this.hideProgramButton.Size = new System.Drawing.Size(50, 35);
            this.hideProgramButton.TabIndex = 1;
            this.hideProgramButton.Text = "-";
            this.hideProgramButton.UseVisualStyleBackColor = false;
            this.hideProgramButton.Click += new System.EventHandler(this.HideProgramButton_Click);
            // 
            // closeProgramButton
            // 
            this.closeProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeProgramButton.BackColor = System.Drawing.Color.Red;
            this.closeProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeProgramButton.Location = new System.Drawing.Point(950, 0);
            this.closeProgramButton.Name = "closeProgramButton";
            this.closeProgramButton.Size = new System.Drawing.Size(50, 35);
            this.closeProgramButton.TabIndex = 0;
            this.closeProgramButton.Text = "X";
            this.closeProgramButton.UseVisualStyleBackColor = false;
            this.closeProgramButton.Click += new System.EventHandler(this.CloseProgramButton_Click);
            // 
            // ServerInterface
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Controls.Add(flowLayoutPanel1);
            this.Controls.Add(mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 560);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 560);
            this.Name = "ServerInterface";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            flowLayoutPanel1.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog newBook;
        private System.Windows.Forms.Button openAddBookButton;
        private System.Windows.Forms.Button openDeleteBookButton;
        private System.Windows.Forms.Button openUserInformationButton;
        private System.Windows.Forms.Button openServerInformationButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button hideProgramButton;
        private System.Windows.Forms.Button closeProgramButton;
        private System.Windows.Forms.TextBox nameOfCurrentFunctionBox;
        private Controls.UserInformationControl userInformationControl;
        private Controls.ServerInformationControl serverInformationControl;
        private Controls.DeleteBookControl deleteBookControl;
        private Controls.AddBookControl addBookControl;
    }
}

