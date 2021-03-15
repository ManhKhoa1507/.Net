namespace Lab1
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
            this.Bai1 = new System.Windows.Forms.Button();
            this.Bai2 = new System.Windows.Forms.Button();
            this.Bai3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bai1
            // 
            this.Bai1.Location = new System.Drawing.Point(50, 34);
            this.Bai1.Name = "Bai1";
            this.Bai1.Size = new System.Drawing.Size(202, 74);
            this.Bai1.TabIndex = 0;
            this.Bai1.Text = "Bài 1";
            this.Bai1.UseVisualStyleBackColor = true;
            this.Bai1.Click += new System.EventHandler(this.Bai1_Click);
            // 
            // Bai2
            // 
            this.Bai2.Location = new System.Drawing.Point(470, 34);
            this.Bai2.Name = "Bai2";
            this.Bai2.Size = new System.Drawing.Size(202, 74);
            this.Bai2.TabIndex = 1;
            this.Bai2.Text = "Bài 2";
            this.Bai2.UseVisualStyleBackColor = true;
            this.Bai2.Click += new System.EventHandler(this.Bai2_Click);
            // 
            // Bai3
            // 
            this.Bai3.Location = new System.Drawing.Point(50, 161);
            this.Bai3.Name = "Bai3";
            this.Bai3.Size = new System.Drawing.Size(202, 74);
            this.Bai3.TabIndex = 2;
            this.Bai3.Text = "Bài 3";
            this.Bai3.UseVisualStyleBackColor = true;
            this.Bai3.Click += new System.EventHandler(this.Bai3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bai3);
            this.Controls.Add(this.Bai2);
            this.Controls.Add(this.Bai1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bai1;
        private System.Windows.Forms.Button Bai2;
        private System.Windows.Forms.Button Bai3;
    }
}

