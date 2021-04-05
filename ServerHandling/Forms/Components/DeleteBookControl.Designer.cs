namespace ServerHandling.Forms
{
    partial class DeleteBookControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label addBookNameButton;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.TextBox textBox1;
            this.deleteBookNameBox = new System.Windows.Forms.TextBox();
            this.deleteBookFindButton = new System.Windows.Forms.Button();
            this.deleteBookFoundBookView = new System.Windows.Forms.DataGridView();
            this.deleteBookIdBox = new System.Windows.Forms.TextBox();
            this.deleteBookFindBookToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.deleteBookReleasedYearBox = new System.Windows.Forms.DateTimePicker();
            this.deleteBookTypeBookBox = new System.Windows.Forms.ComboBox();
            this.deleteBookName = new System.Windows.Forms.TextBox();
            this.deleteBookConfirmButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            addBookNameButton = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBookFoundBookView)).BeginInit();
            this.panel1.SuspendLayout();
            panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBookNameButton
            // 
            addBookNameButton.AutoSize = true;
            addBookNameButton.Enabled = false;
            addBookNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addBookNameButton.Location = new System.Drawing.Point(30, 151);
            addBookNameButton.Name = "addBookNameButton";
            addBookNameButton.Size = new System.Drawing.Size(101, 20);
            addBookNameButton.TabIndex = 9;
            addBookNameButton.Text = "Tên Tác Giả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(30, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 20);
            label1.TabIndex = 13;
            label1.Text = "ID Sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(30, 211);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 20);
            label2.TabIndex = 15;
            label2.Text = "Năm Xuất Bản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(30, 277);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(74, 20);
            label4.TabIndex = 19;
            label4.Text = "Thể Loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(30, 87);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(80, 20);
            label3.TabIndex = 24;
            label3.Text = "Tên Sách";
            // 
            // deleteBookNameBox
            // 
            this.deleteBookNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBookNameBox.Location = new System.Drawing.Point(34, 174);
            this.deleteBookNameBox.Name = "deleteBookNameBox";
            this.deleteBookNameBox.Size = new System.Drawing.Size(301, 26);
            this.deleteBookNameBox.TabIndex = 8;
            // 
            // deleteBookFindButton
            // 
            this.deleteBookFindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBookFindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBookFindButton.Location = new System.Drawing.Point(34, 350);
            this.deleteBookFindButton.Name = "deleteBookFindButton";
            this.deleteBookFindButton.Size = new System.Drawing.Size(110, 45);
            this.deleteBookFindButton.TabIndex = 10;
            this.deleteBookFindButton.Text = "Tìm Sách";
            this.deleteBookFindButton.UseVisualStyleBackColor = true;
            // 
            // deleteBookFoundBookView
            // 
            this.deleteBookFoundBookView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteBookFoundBookView.Location = new System.Drawing.Point(403, 63);
            this.deleteBookFoundBookView.Name = "deleteBookFoundBookView";
            this.deleteBookFoundBookView.RowHeadersWidth = 51;
            this.deleteBookFoundBookView.RowTemplate.Height = 24;
            this.deleteBookFoundBookView.Size = new System.Drawing.Size(397, 578);
            this.deleteBookFoundBookView.TabIndex = 11;
            // 
            // deleteBookIdBox
            // 
            this.deleteBookIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBookIdBox.Location = new System.Drawing.Point(34, 47);
            this.deleteBookIdBox.Name = "deleteBookIdBox";
            this.deleteBookIdBox.Size = new System.Drawing.Size(301, 26);
            this.deleteBookIdBox.TabIndex = 12;
            // 
            // deleteBookReleasedYearBox
            // 
            this.deleteBookReleasedYearBox.CustomFormat = "yyyy";
            this.deleteBookReleasedYearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBookReleasedYearBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deleteBookReleasedYearBox.Location = new System.Drawing.Point(34, 237);
            this.deleteBookReleasedYearBox.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.deleteBookReleasedYearBox.Name = "deleteBookReleasedYearBox";
            this.deleteBookReleasedYearBox.ShowUpDown = true;
            this.deleteBookReleasedYearBox.Size = new System.Drawing.Size(70, 26);
            this.deleteBookReleasedYearBox.TabIndex = 20;
            // 
            // deleteBookTypeBookBox
            // 
            this.deleteBookTypeBookBox.FormattingEnabled = true;
            this.deleteBookTypeBookBox.Location = new System.Drawing.Point(34, 303);
            this.deleteBookTypeBookBox.Name = "deleteBookTypeBookBox";
            this.deleteBookTypeBookBox.Size = new System.Drawing.Size(229, 24);
            this.deleteBookTypeBookBox.TabIndex = 21;
            // 
            // deleteBookName
            // 
            this.deleteBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBookName.Location = new System.Drawing.Point(34, 110);
            this.deleteBookName.Name = "deleteBookName";
            this.deleteBookName.Size = new System.Drawing.Size(301, 26);
            this.deleteBookName.TabIndex = 23;
            // 
            // deleteBookConfirmButton
            // 
            this.deleteBookConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteBookConfirmButton.BackColor = System.Drawing.Color.Salmon;
            this.deleteBookConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBookConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBookConfirmButton.Location = new System.Drawing.Point(221, 539);
            this.deleteBookConfirmButton.Name = "deleteBookConfirmButton";
            this.deleteBookConfirmButton.Size = new System.Drawing.Size(165, 45);
            this.deleteBookConfirmButton.TabIndex = 25;
            this.deleteBookConfirmButton.Text = "Xóa Sách Đã Chọn";
            this.deleteBookConfirmButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteBookName);
            this.panel1.Controls.Add(this.deleteBookNameBox);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(addBookNameButton);
            this.panel1.Controls.Add(this.deleteBookFindButton);
            this.panel1.Controls.Add(this.deleteBookIdBox);
            this.panel1.Controls.Add(this.deleteBookTypeBookBox);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.deleteBookReleasedYearBox);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(label4);
            this.panel1.Location = new System.Drawing.Point(33, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 402);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            panel2.Controls.Add(textBox1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(800, 60);
            panel2.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            textBox1.Enabled = false;
            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox1.Location = new System.Drawing.Point(324, 21);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(126, 29);
            textBox1.TabIndex = 0;
            textBox1.Text = "Xóa Sách";
            // 
            // DeleteBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteBookConfirmButton);
            this.Controls.Add(this.deleteBookFoundBookView);
            this.Name = "DeleteBookControl";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.deleteBookFoundBookView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox deleteBookNameBox;
        private System.Windows.Forms.Button deleteBookFindButton;
        private System.Windows.Forms.DataGridView deleteBookFoundBookView;
        private System.Windows.Forms.TextBox deleteBookIdBox;
        private System.Windows.Forms.ToolTip deleteBookFindBookToolTip;
        private System.Windows.Forms.DateTimePicker deleteBookReleasedYearBox;
        private System.Windows.Forms.ComboBox deleteBookTypeBookBox;
        private System.Windows.Forms.TextBox deleteBookName;
        private System.Windows.Forms.Button deleteBookConfirmButton;
        private System.Windows.Forms.Panel panel1;
    }
}
