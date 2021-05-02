namespace Bai1
{
    partial class MultiTCP
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
            this.Client = new System.Windows.Forms.Button();
            this.Server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Client
            // 
            this.Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.Client.Location = new System.Drawing.Point(93, 67);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(597, 92);
            this.Client.TabIndex = 0;
            this.Client.Text = "Client";
            this.Client.UseVisualStyleBackColor = true;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Server
            // 
            this.Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.Server.Location = new System.Drawing.Point(93, 259);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(597, 92);
            this.Server.TabIndex = 1;
            this.Server.Text = "Server";
            this.Server.UseVisualStyleBackColor = true;
            this.Server.Click += new System.EventHandler(this.Server_Click);
            // 
            // MultiTCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.Client);
            this.Name = "MultiTCP";
            this.Text = "MultiTCP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Client;
        private System.Windows.Forms.Button Server;
    }
}