namespace Bai1
{
    partial class telnet
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
            this.listenButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listenButton
            // 
            this.listenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listenButton.Location = new System.Drawing.Point(583, 12);
            this.listenButton.Name = "listenButton";
            this.listenButton.Size = new System.Drawing.Size(156, 69);
            this.listenButton.TabIndex = 0;
            this.listenButton.Text = "Listen";
            this.listenButton.UseVisualStyleBackColor = true;
            this.listenButton.Click += new System.EventHandler(this.listenButton_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(743, 315);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // telnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listenButton);
            this.Name = "telnet";
            this.Text = "telnet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listenButton;
        private System.Windows.Forms.ListView listView1;
    }
}