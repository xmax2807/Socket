namespace ServerHandling.Forms
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
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.TextBox textBox1;
            System.Windows.Forms.Panel panel1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.serverIPBox = new System.Windows.Forms.TextBox();
            this.serverPortBox = new System.Windows.Forms.MaskedTextBox();
            this.serverStateBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.openConnectionButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            panel2 = new System.Windows.Forms.Panel();
            textBox1 = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            panel2.Controls.Add(textBox1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(800, 60);
            panel2.TabIndex = 36;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox1.Location = new System.Drawing.Point(291, 21);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(218, 29);
            textBox1.TabIndex = 0;
            textBox1.Text = "Thông Tin Server";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 534);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.disconnectButton);
            this.tabPage1.Controls.Add(this.openConnectionButton);
            this.tabPage1.Controls.Add(panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông Tin Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server IP";
            // 
            // serverIPBox
            // 
            this.serverIPBox.Location = new System.Drawing.Point(103, 6);
            this.serverIPBox.Name = "serverIPBox";
            this.serverIPBox.Size = new System.Drawing.Size(450, 26);
            this.serverIPBox.TabIndex = 0;
            // 
            // serverPortBox
            // 
            this.serverPortBox.Location = new System.Drawing.Point(103, 41);
            this.serverPortBox.Name = "serverPortBox";
            this.serverPortBox.Size = new System.Drawing.Size(450, 26);
            this.serverPortBox.TabIndex = 1;
            // 
            // serverStateBox
            // 
            this.serverStateBox.Location = new System.Drawing.Point(103, 73);
            this.serverStateBox.Name = "serverStateBox";
            this.serverStateBox.Size = new System.Drawing.Size(450, 26);
            this.serverStateBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trạng Thái";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xử Lý Gần Đây";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 520);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xem Người Dùng Đang Kết Nối";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(this.serverPortBox);
            panel1.Controls.Add(this.label1);
            panel1.Controls.Add(this.label2);
            panel1.Controls.Add(this.serverIPBox);
            panel1.Controls.Add(this.serverStateBox);
            panel1.Controls.Add(this.label3);
            panel1.Enabled = false;
            panel1.Location = new System.Drawing.Point(86, 46);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(570, 113);
            panel1.TabIndex = 6;
            // 
            // openConnectionButton
            // 
            this.openConnectionButton.Location = new System.Drawing.Point(86, 180);
            this.openConnectionButton.Name = "openConnectionButton";
            this.openConnectionButton.Size = new System.Drawing.Size(170, 64);
            this.openConnectionButton.TabIndex = 7;
            this.openConnectionButton.Text = "Mở Kết Nối Server";
            this.openConnectionButton.UseVisualStyleBackColor = true;
            this.openConnectionButton.Click += new System.EventHandler(this.OpenConnectionButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(86, 270);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(170, 64);
            this.disconnectButton.TabIndex = 8;
            this.disconnectButton.Text = "Ngắt Kết Nối Server";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(786, 514);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "ng đã đăng nhập vào lúc 11h";
            // 
            // ServerInformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(panel2);
            this.Controls.Add(this.tabControl1);
            this.Name = "ServerInformationControl";
            this.Size = new System.Drawing.Size(800, 600);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MaskedTextBox serverPortBox;
        private System.Windows.Forms.TextBox serverIPBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverStateBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button openConnectionButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
