namespace Bai1
{
    partial class MultipleClient
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
            this.name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.name.Location = new System.Drawing.Point(12, 279);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(71, 26);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.Location = new System.Drawing.Point(98, 279);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 44);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox2.Location = new System.Drawing.Point(12, 355);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(564, 83);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message";
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.Send.Location = new System.Drawing.Point(598, 355);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(190, 83);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 261);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // MultipleClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.name);
            this.Name = "MultipleClient";
            this.Text = "MultipleClient";
            this.Load += new System.EventHandler(this.MultipleClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}