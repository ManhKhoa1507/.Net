namespace Bai1
{
    partial class UDPClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IPText = new System.Windows.Forms.TextBox();
            this.PortText = new System.Windows.Forms.TextBox();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(529, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // IPText
            // 
            this.IPText.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.IPText.Location = new System.Drawing.Point(21, 55);
            this.IPText.Multiline = true;
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(367, 34);
            this.IPText.TabIndex = 2;
            // 
            // PortText
            // 
            this.PortText.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.PortText.Location = new System.Drawing.Point(534, 55);
            this.PortText.Multiline = true;
            this.PortText.Name = "PortText";
            this.PortText.Size = new System.Drawing.Size(200, 34);
            this.PortText.TabIndex = 3;
            // 
            // MessageText
            // 
            this.MessageText.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.MessageText.Location = new System.Drawing.Point(21, 130);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(713, 222);
            this.MessageText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message";
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("Times New Roman", 26F);
            this.Send.Location = new System.Drawing.Point(21, 369);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(294, 40);
            this.Send.TabIndex = 7;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // UDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 421);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.PortText);
            this.Controls.Add(this.IPText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UDPClient";
            this.Text = "UDPClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IPText;
        private System.Windows.Forms.TextBox PortText;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Send;
    }
}