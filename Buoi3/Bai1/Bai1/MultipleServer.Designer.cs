namespace Bai1
{
    partial class MultipleServer
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
            this.Listen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Listen
            // 
            this.Listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.Listen.Location = new System.Drawing.Point(617, 28);
            this.Listen.Name = "Listen";
            this.Listen.Size = new System.Drawing.Size(162, 47);
            this.Listen.TabIndex = 0;
            this.Listen.Text = "Listen";
            this.Listen.UseVisualStyleBackColor = true;
            this.Listen.Click += new System.EventHandler(this.Listen_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.richTextBox1.Location = new System.Drawing.Point(22, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(757, 330);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // MultipleServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Listen);
            this.Name = "MultipleServer";
            this.Text = "MultipleServer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Listen;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}