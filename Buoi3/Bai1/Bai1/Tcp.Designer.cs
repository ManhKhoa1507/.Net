namespace Bai1
{
    partial class Tcp
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
            this.client = new System.Windows.Forms.Button();
            this.server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // client
            // 
            this.client.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.client.Location = new System.Drawing.Point(30, 85);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(717, 72);
            this.client.TabIndex = 0;
            this.client.Text = "TCP Client";
            this.client.UseVisualStyleBackColor = true;
            this.client.Click += new System.EventHandler(this.client_Click);
            // 
            // server
            // 
            this.server.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.server.Location = new System.Drawing.Point(30, 269);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(717, 72);
            this.server.TabIndex = 1;
            this.server.Text = "TCP Server";
            this.server.UseVisualStyleBackColor = true;
            this.server.Click += new System.EventHandler(this.server_Click);
            // 
            // Tcp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.server);
            this.Controls.Add(this.client);
            this.Name = "Tcp";
            this.Text = "Tcp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button client;
        private System.Windows.Forms.Button server;
    }
}