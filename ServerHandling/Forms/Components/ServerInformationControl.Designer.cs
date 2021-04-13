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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.serverStateBox = new System.Windows.Forms.TextBox();
            this.serverIPBox = new System.Windows.Forms.TextBox();
            this.serverPortBox = new System.Windows.Forms.MaskedTextBox();
            this.openConnectionButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 500);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xử Lý Gần Đây";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(786, 461);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "ng đã đăng nhập vào lúc 11h";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xem Người Dùng Đang Kết Nối";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(this.serverPortBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(this.serverIPBox);
            panel1.Controls.Add(this.serverStateBox);
            panel1.Controls.Add(label3);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Enabled = false;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(786, 107);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new System.Drawing.Point(3, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "Trạng Thái";
            // 
            // serverStateBox
            // 
            this.serverStateBox.Location = new System.Drawing.Point(103, 73);
            this.serverStateBox.Name = "serverStateBox";
            this.serverStateBox.Size = new System.Drawing.Size(450, 26);
            this.serverStateBox.TabIndex = 2;
            // 
            // serverIPBox
            // 
            this.serverIPBox.Location = new System.Drawing.Point(103, 6);
            this.serverIPBox.Name = "serverIPBox";
            this.serverIPBox.Size = new System.Drawing.Size(450, 26);
            this.serverIPBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new System.Drawing.Point(3, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 20);
            label2.TabIndex = 4;
            label2.Text = "Server Port";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new System.Drawing.Point(3, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 20);
            label1.TabIndex = 3;
            label1.Text = "Server IP";
            // 
            // serverPortBox
            // 
            this.serverPortBox.Location = new System.Drawing.Point(103, 41);
            this.serverPortBox.Name = "serverPortBox";
            this.serverPortBox.Size = new System.Drawing.Size(450, 26);
            this.serverPortBox.TabIndex = 1;
            // 
            // openConnectionButton
            // 
            this.openConnectionButton.Location = new System.Drawing.Point(3, 116);
            this.openConnectionButton.Name = "openConnectionButton";
            this.openConnectionButton.Size = new System.Drawing.Size(170, 64);
            this.openConnectionButton.TabIndex = 7;
            this.openConnectionButton.Text = "Mở Kết Nối Server";
            this.openConnectionButton.UseVisualStyleBackColor = true;
            this.openConnectionButton.Click += new System.EventHandler(this.OpenConnectionButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(179, 116);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(170, 64);
            this.disconnectButton.TabIndex = 8;
            this.disconnectButton.Text = "Ngắt Kết Nối Server";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.disconnectButton);
            this.tabPage1.Controls.Add(this.openConnectionButton);
            this.tabPage1.Controls.Add(panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông Tin Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ServerInformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "ServerInformationControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button openConnectionButton;
        private System.Windows.Forms.MaskedTextBox serverPortBox;
        private System.Windows.Forms.TextBox serverIPBox;
        private System.Windows.Forms.TextBox serverStateBox;
    }
}
