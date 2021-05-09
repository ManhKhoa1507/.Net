namespace Buoi4
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
            this.Bai01 = new System.Windows.Forms.Button();
            this.Bai02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bai01
            // 
            this.Bai01.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.Bai01.Location = new System.Drawing.Point(59, 52);
            this.Bai01.Name = "Bai01";
            this.Bai01.Size = new System.Drawing.Size(238, 80);
            this.Bai01.TabIndex = 0;
            this.Bai01.Text = "Bai 1";
            this.Bai01.UseVisualStyleBackColor = true;
            this.Bai01.Click += new System.EventHandler(this.Bai01_Click);
            // 
            // Bai02
            // 
            this.Bai02.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.Bai02.Location = new System.Drawing.Point(492, 52);
            this.Bai02.Name = "Bai02";
            this.Bai02.Size = new System.Drawing.Size(238, 80);
            this.Bai02.TabIndex = 1;
            this.Bai02.Text = "Bai 2";
            this.Bai02.UseVisualStyleBackColor = true;
            this.Bai02.Click += new System.EventHandler(this.Bai02_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bai02);
            this.Controls.Add(this.Bai01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bai01;
        private System.Windows.Forms.Button Bai02;
    }
}

