namespace Client_Handling.Forms
{
    partial class ListBook_Interface
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
            this.UpperBar = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.BookContainer = new System.Windows.Forms.Panel();
            this.UpperBar.SuspendLayout();
            this.BookContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.UpperBar.BackColor = System.Drawing.Color.Transparent;
            this.UpperBar.Controls.Add(this.Back);
            this.UpperBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperBar.Location = new System.Drawing.Point(0, 0);
            this.UpperBar.Size = new System.Drawing.Size(1257, 39);
            this.UpperBar.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackgroundImage = global::Client_Handling.Properties.Resources.exit_nocolor;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Back.Dock = System.Windows.Forms.DockStyle.Left;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(0, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(39, 39);
            this.Back.TabIndex = 0;
            this.Back.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.MouseEnter += new System.EventHandler(this.Back_MouseEnter);
            this.Back.MouseLeave += new System.EventHandler(this.Back_MouseLeave);
            this.Back.Click += new System.EventHandler(this.Back_click);
            // 
            // BookContainer
            // 
            this.BookContainer.AutoScroll = true;
            this.BookContainer.BackColor = System.Drawing.Color.Transparent;
            this.BookContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookContainer.Location = new System.Drawing.Point(0, 39);
            this.BookContainer.Size = new System.Drawing.Size(1257, 765);
            this.BookContainer.TabIndex = 1;
            //
            
            // 
            // ListBook_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BookContainer);
            this.Controls.Add(this.UpperBar);
            this.Name = "ListBook_Interface";
            this.Size = new System.Drawing.Size(1257, 804);
            this.UpperBar.ResumeLayout(false);
            this.BookContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Visible = false;

        }

        #endregion

        private System.Windows.Forms.Panel UpperBar;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel BookContainer;
    }
}
