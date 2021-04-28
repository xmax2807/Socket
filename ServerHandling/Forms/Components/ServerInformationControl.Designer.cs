namespace ServerHandling.Controls
{
    partial class ServerInformationControl
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
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.serverStateBox = new System.Windows.Forms.TextBox();
            this.serverPortBox = new System.Windows.Forms.TextBox();
            this.serverIPBox = new System.Windows.Forms.TextBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.openConnectionButton = new System.Windows.Forms.Button();
            this.serverRecentTasks = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(this.panel3);
            panel1.Controls.Add(this.panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Enabled = false;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 94);
            panel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new System.Drawing.Point(3, 66);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 17);
            label3.TabIndex = 5;
            label3.Text = "State";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new System.Drawing.Point(3, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 17);
            label2.TabIndex = 4;
            label2.Text = "Server Port";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = System.Windows.Forms.Cursors.Default;
            label1.Enabled = false;
            label1.Location = new System.Drawing.Point(3, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 17);
            label1.TabIndex = 3;
            label1.Text = "Server IP";
            // 
            // serverStateBox
            // 
            this.serverStateBox.Enabled = false;
            this.serverStateBox.Location = new System.Drawing.Point(111, 66);
            this.serverStateBox.Name = "serverStateBox";
            this.serverStateBox.Size = new System.Drawing.Size(357, 22);
            this.serverStateBox.TabIndex = 2;
            // 
            // serverPortBox
            // 
            this.serverPortBox.Enabled = false;
            this.serverPortBox.Location = new System.Drawing.Point(111, 38);
            this.serverPortBox.Name = "serverPortBox";
            this.serverPortBox.Size = new System.Drawing.Size(357, 22);
            this.serverPortBox.TabIndex = 1;
            // 
            // serverIPBox
            // 
            this.serverIPBox.Enabled = false;
            this.serverIPBox.Location = new System.Drawing.Point(111, 10);
            this.serverIPBox.Name = "serverIPBox";
            this.serverIPBox.Size = new System.Drawing.Size(357, 22);
            this.serverIPBox.TabIndex = 0;
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.OrangeRed;
            this.disconnectButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.disconnectButton.Location = new System.Drawing.Point(0, 51);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(225, 43);
            this.disconnectButton.TabIndex = 11;
            this.disconnectButton.Text = "Ngắt Kết Nối Server";
            this.disconnectButton.UseVisualStyleBackColor = false;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // openConnectionButton
            // 
            this.openConnectionButton.BackColor = System.Drawing.Color.LimeGreen;
            this.openConnectionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openConnectionButton.Location = new System.Drawing.Point(0, 0);
            this.openConnectionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openConnectionButton.Name = "openConnectionButton";
            this.openConnectionButton.Size = new System.Drawing.Size(225, 47);
            this.openConnectionButton.TabIndex = 10;
            this.openConnectionButton.Text = "Mở Kết Nối Server";
            this.openConnectionButton.UseVisualStyleBackColor = false;
            this.openConnectionButton.Click += new System.EventHandler(this.OpenConnectionButton_Click);
            // 
            // serverRecentTasks
            // 
            this.serverRecentTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverRecentTasks.Enabled = false;
            this.serverRecentTasks.Location = new System.Drawing.Point(0, 94);
            this.serverRecentTasks.Name = "serverRecentTasks";
            this.serverRecentTasks.Size = new System.Drawing.Size(800, 406);
            this.serverRecentTasks.TabIndex = 12;
            this.serverRecentTasks.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(label3);
            this.panel3.Controls.Add(this.serverIPBox);
            this.panel3.Controls.Add(this.serverStateBox);
            this.panel3.Controls.Add(label2);
            this.panel3.Controls.Add(this.serverPortBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 94);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.disconnectButton);
            this.panel2.Controls.Add(this.openConnectionButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(575, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 94);
            this.panel2.TabIndex = 13;
            // 
            // ServerInformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.serverRecentTasks);
            this.Controls.Add(panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServerInformationControl";
            this.Size = new System.Drawing.Size(800, 500);
            panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox serverStateBox;
        private System.Windows.Forms.TextBox serverPortBox;
        private System.Windows.Forms.TextBox serverIPBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button openConnectionButton;
        private System.Windows.Forms.RichTextBox serverRecentTasks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}
