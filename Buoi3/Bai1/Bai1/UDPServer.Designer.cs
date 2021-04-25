namespace Bai1
{
    partial class UDPServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.MessageBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Listen
            // 
            this.Listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.Listen.Location = new System.Drawing.Point(506, 51);
            this.Listen.Name = "Listen";
            this.Listen.Size = new System.Drawing.Size(183, 49);
            this.Listen.TabIndex = 0;
            this.Listen.Text = "Listen";
            this.Listen.UseVisualStyleBackColor = true;
            this.Listen.Click += new System.EventHandler(this.Listen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // PortBox
            // 
            this.PortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PortBox.Location = new System.Drawing.Point(17, 51);
            this.PortBox.Multiline = true;
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(281, 56);
            this.PortBox.TabIndex = 2;
            // 
            // MessageBox
            // 
            this.MessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.MessageBox.Location = new System.Drawing.Point(17, 150);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(754, 274);
            this.MessageBox.TabIndex = 3;
            this.MessageBox.Text = "";
            // 
            // UDPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Listen);
            this.Name = "UDPServer";
            this.Text = "UDPServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Listen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.RichTextBox MessageBox;
    }
}