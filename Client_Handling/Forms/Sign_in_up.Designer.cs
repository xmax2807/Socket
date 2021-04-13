namespace Client_Handling.Forms
{
    partial class Sign_in_up
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.waterMarkTextBox2 = new Client_Handling.WaterMarkTextBox();
            this.waterMarkTextBox1 = new Client_Handling.WaterMarkTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sign in";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = global::Client_Handling.Properties.Resources.exit_nocolor;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(0, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 30);
            this.Exit.TabIndex = 2;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // waterMarkTextBox2
            // 
            this.waterMarkTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.waterMarkTextBox2.Location = new System.Drawing.Point(86, 152);
            this.waterMarkTextBox2.Name = "waterMarkTextBox2";
            this.waterMarkTextBox2.Size = new System.Drawing.Size(165, 22);
            this.waterMarkTextBox2.TabIndex = 0;
            this.waterMarkTextBox2.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox2.WaterMarkText = "Water Mark";
            // 
            // waterMarkTextBox1
            // 
            this.waterMarkTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waterMarkTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.waterMarkTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.waterMarkTextBox1.Location = new System.Drawing.Point(86, 124);
            this.waterMarkTextBox1.Name = "waterMarkTextBox1";
            this.waterMarkTextBox1.Size = new System.Drawing.Size(165, 22);
            this.waterMarkTextBox1.TabIndex = 0;
            this.waterMarkTextBox1.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox1.WaterMarkText = "Water Mark";
            // 
            // Sign_in_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.waterMarkTextBox2);
            this.Controls.Add(this.waterMarkTextBox1);
            this.Name = "Sign_in_up";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WaterMarkTextBox waterMarkTextBox1;
        private WaterMarkTextBox waterMarkTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Exit;
    }
}
