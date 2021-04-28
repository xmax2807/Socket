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
            this.newBook = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hideProgramButton = new System.Windows.Forms.Button();
            this.closeProgramButton = new System.Windows.Forms.Button();
            this.serverInformationControl = new ServerHandling.Controls.ServerInformationControl();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.hideProgramButton);
            this.panel1.Controls.Add(this.closeProgramButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 67);
            this.panel1.TabIndex = 9;
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
            // serverInformationControl
            // 
            this.serverInformationControl.BackColor = System.Drawing.Color.White;
            this.serverInformationControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.serverInformationControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.serverInformationControl.Location = new System.Drawing.Point(0, 67);
            this.serverInformationControl.Name = "serverInformationControl";
            this.serverInformationControl.Size = new System.Drawing.Size(1000, 493);
            this.serverInformationControl.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServerInterface
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.serverInformationControl);
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog newBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button hideProgramButton;
        private System.Windows.Forms.Button closeProgramButton;
        private Controls.ServerInformationControl serverInformationControl;
        private System.Windows.Forms.Button button1;
    }
}

