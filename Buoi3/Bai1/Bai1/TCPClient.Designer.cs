namespace Bai1
{
    partial class TCPClient
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
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.send.Location = new System.Drawing.Point(135, 143);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(509, 115);
            this.send.TabIndex = 0;
            this.send.Text = "Send message";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // TCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.send);
            this.Name = "TCPClient";
            this.Text = "TCPClient";
            this.Load += new System.EventHandler(this.TCPClient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button send;
    }
}