namespace Client_Handling.Forms
{
    partial class Connect_toHost
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
            this.IP = new Client_Handling.WaterMarkTextBox();
            this.port = new Client_Handling.WaterMarkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IP
            // 
            this.IP.Font = new System.Drawing.Font("Maiandra GD", 10F);
            this.IP.Location = new System.Drawing.Point(471, 272);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(307, 27);
            this.IP.TabIndex = 0;
            this.IP.WaterMarkColor = System.Drawing.Color.Gray;
            this.IP.WaterMarkText = "IP Address";
            this.IP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Connect_enter);
            // 
            // port
            // 
            this.port.Font = new System.Drawing.Font("Maiandra GD", 10F);
            this.port.Location = new System.Drawing.Point(471, 305);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(307, 27);
            this.port.TabIndex = 0;
            this.port.WaterMarkColor = System.Drawing.Color.Gray;
            this.port.WaterMarkText = "Port";
            this.port.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Connect_enter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(215, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(829, 33);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Connect_toHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port);
            this.Controls.Add(this.IP);
            this.Name = "Connect_toHost";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WaterMarkTextBox IP;
        private WaterMarkTextBox port;
        private System.Windows.Forms.Label label1;
    }
}
