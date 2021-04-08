namespace ClientSocket
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
            this.UDPClient = new System.Windows.Forms.Button();
            this.TCPClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UDPClient
            // 
            this.UDPClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.UDPClient.Location = new System.Drawing.Point(71, 133);
            this.UDPClient.Name = "UDPClient";
            this.UDPClient.Size = new System.Drawing.Size(226, 102);
            this.UDPClient.TabIndex = 0;
            this.UDPClient.Text = "UDP Client";
            this.UDPClient.UseVisualStyleBackColor = true;
            this.UDPClient.Click += new System.EventHandler(this.UDPClient_Click);
            // 
            // TCPClient
            // 
            this.TCPClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.TCPClient.Location = new System.Drawing.Point(460, 133);
            this.TCPClient.Name = "TCPClient";
            this.TCPClient.Size = new System.Drawing.Size(226, 102);
            this.TCPClient.TabIndex = 1;
            this.TCPClient.Text = "TCP Client";
            this.TCPClient.UseVisualStyleBackColor = true;
            this.TCPClient.Click += new System.EventHandler(this.TCPClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TCPClient);
            this.Controls.Add(this.UDPClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UDPClient;
        private System.Windows.Forms.Button TCPClient;
    }
}

