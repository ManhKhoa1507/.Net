namespace Buoi2
{
    partial class Tinh
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
            this.Calculate = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Write = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Calculate.Location = new System.Drawing.Point(290, 12);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(173, 62);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Tính";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Read
            // 
            this.Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Read.Location = new System.Drawing.Point(60, 12);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(173, 62);
            this.Read.TabIndex = 1;
            this.Read.Text = "Đọc";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Write
            // 
            this.Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Write.Location = new System.Drawing.Point(515, 12);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(173, 62);
            this.Write.TabIndex = 2;
            this.Write.Text = "Ghi";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.richTextBox1.Location = new System.Drawing.Point(14, 105);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(374, 333);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.richTextBox2.Location = new System.Drawing.Point(394, 105);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(374, 333);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // Tinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Write);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Calculate);
            this.Name = "Tinh";
            this.Text = "Tinh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}