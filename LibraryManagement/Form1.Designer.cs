namespace LibraryManagement
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.kiraTarihi = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRentABook = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye Adı:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı:";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitabın Alındığı Tarih:";
            this.label3.UseWaitCursor = true;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserName.Location = new System.Drawing.Point(395, 12);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(315, 49);
            this.tbxUserName.TabIndex = 3;
            this.tbxUserName.UseWaitCursor = true;
            // 
            // tbxBookName
            // 
            this.tbxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookName.Location = new System.Drawing.Point(395, 75);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(315, 49);
            this.tbxBookName.TabIndex = 4;
            this.tbxBookName.UseWaitCursor = true;
            // 
            // kiraTarihi
            // 
            this.kiraTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kiraTarihi.Location = new System.Drawing.Point(395, 143);
            this.kiraTarihi.Name = "kiraTarihi";
            this.kiraTarihi.Size = new System.Drawing.Size(315, 49);
            this.kiraTarihi.TabIndex = 5;
            this.kiraTarihi.UseWaitCursor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 243);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(925, 388);
            this.listBox1.TabIndex = 6;
            this.listBox1.UseWaitCursor = true;
            // 
            // btnRentABook
            // 
            this.btnRentABook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRentABook.Location = new System.Drawing.Point(728, 12);
            this.btnRentABook.Name = "btnRentABook";
            this.btnRentABook.Size = new System.Drawing.Size(209, 180);
            this.btnRentABook.TabIndex = 7;
            this.btnRentABook.Text = "Kitap Kirala";
            this.btnRentABook.UseVisualStyleBackColor = true;
            this.btnRentABook.UseWaitCursor = true;
            this.btnRentABook.Click += new System.EventHandler(this.btnRentABook_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(950, 243);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(785, 388);
            this.listBox2.TabIndex = 9;
            this.listBox2.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1747, 647);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnRentABook);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.kiraTarihi);
            this.Controls.Add(this.tbxBookName);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.DateTimePicker kiraTarihi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRentABook;
        private System.Windows.Forms.ListBox listBox2;
    }
}

