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
            this.serverInformationControl = new ServerHandling.Controls.ServerInformationControl();
            this.SuspendLayout();
            // 
            // serverInformationControl
            // 
            this.serverInformationControl.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.serverInformationControl.BackColor = System.Drawing.Color.White;
            this.serverInformationControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.serverInformationControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverInformationControl.Location = new System.Drawing.Point(0, 0);
            this.serverInformationControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverInformationControl.Name = "serverInformationControl";
            this.serverInformationControl.Size = new System.Drawing.Size(482, 353);
            this.serverInformationControl.TabIndex = 2;
            // 
            // ServerInterface
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.serverInformationControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 560);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ServerInterface";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.ServerInformationControl serverInformationControl;
    }
}

