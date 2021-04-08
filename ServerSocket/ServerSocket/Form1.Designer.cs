namespace ServerSocket
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
            this.UDPServer = new System.Windows.Forms.Button();
            this.TCPServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UDPServer
            // 
            this.UDPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.UDPServer.Location = new System.Drawing.Point(53, 118);
            this.UDPServer.Name = "UDPServer";
            this.UDPServer.Size = new System.Drawing.Size(226, 102);
            this.UDPServer.TabIndex = 1;
            this.UDPServer.Text = "UDP Server";
            this.UDPServer.UseVisualStyleBackColor = true;
            this.UDPServer.Click += new System.EventHandler(this.UDPServer_Click);
            // 
            // TCPServer
            // 
            this.TCPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.TCPServer.Location = new System.Drawing.Point(444, 118);
            this.TCPServer.Name = "TCPServer";
            this.TCPServer.Size = new System.Drawing.Size(226, 102);
            this.TCPServer.TabIndex = 2;
            this.TCPServer.Text = "TCP Server";
            this.TCPServer.UseVisualStyleBackColor = true;
            this.TCPServer.Click += new System.EventHandler(this.TCPServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TCPServer);
            this.Controls.Add(this.UDPServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UDPServer;
        private System.Windows.Forms.Button TCPServer;
    }
}

