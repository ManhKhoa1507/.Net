namespace Buoi2
{
    partial class ThongTinFile
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
            this.Read = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.RichTextBox();
            this.URL = new System.Windows.Forms.RichTextBox();
            this.Lines = new System.Windows.Forms.RichTextBox();
            this.Words = new System.Windows.Forms.RichTextBox();
            this.Characters = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Read
            // 
            this.Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Read.Location = new System.Drawing.Point(32, 31);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(218, 65);
            this.Read.TabIndex = 1;
            this.Read.Text = "Đọc";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.richTextBox1.Location = new System.Drawing.Point(294, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(480, 377);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(12, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số dòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(12, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số kí tự";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(100, 120);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(170, 34);
            this.FileName.TabIndex = 8;
            this.FileName.Text = "";
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(100, 173);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(170, 34);
            this.URL.TabIndex = 9;
            this.URL.Text = "";
            // 
            // Lines
            // 
            this.Lines.Location = new System.Drawing.Point(100, 227);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(170, 34);
            this.Lines.TabIndex = 10;
            this.Lines.Text = "";
            // 
            // Words
            // 
            this.Words.Location = new System.Drawing.Point(100, 282);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(170, 34);
            this.Words.TabIndex = 11;
            this.Words.Text = "";
            // 
            // Characters
            // 
            this.Characters.Location = new System.Drawing.Point(100, 341);
            this.Characters.Name = "Characters";
            this.Characters.Size = new System.Drawing.Size(170, 34);
            this.Characters.TabIndex = 12;
            this.Characters.Text = "";
            // 
            // ThongTinFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Characters);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.Lines);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Read);
            this.Name = "ThongTinFile";
            this.Text = "ThongTinFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox FileName;
        private System.Windows.Forms.RichTextBox URL;
        private System.Windows.Forms.RichTextBox Lines;
        private System.Windows.Forms.RichTextBox Words;
        private System.Windows.Forms.RichTextBox Characters;
    }
}