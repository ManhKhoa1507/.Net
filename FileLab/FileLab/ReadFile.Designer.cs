namespace FileLab
{
    partial class ReadFile
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnFileStream = new System.Windows.Forms.Button();
            this.btnStreamReader = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFileReadAsync = new System.Windows.Forms.Button();
            this.btnStreamReadSync = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 11);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(507, 328);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnFileStream
            // 
            this.btnFileStream.Location = new System.Drawing.Point(542, 15);
            this.btnFileStream.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFileStream.Name = "btnFileStream";
            this.btnFileStream.Size = new System.Drawing.Size(106, 38);
            this.btnFileStream.TabIndex = 1;
            this.btnFileStream.Text = "FileStream";
            this.btnFileStream.UseVisualStyleBackColor = true;
            this.btnFileStream.Click += new System.EventHandler(this.btnFileStream_Click);
            // 
            // btnStreamReader
            // 
            this.btnStreamReader.Location = new System.Drawing.Point(542, 70);
            this.btnStreamReader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStreamReader.Name = "btnStreamReader";
            this.btnStreamReader.Size = new System.Drawing.Size(105, 40);
            this.btnStreamReader.TabIndex = 2;
            this.btnStreamReader.Text = "Stream Reader";
            this.btnStreamReader.UseVisualStyleBackColor = true;
            this.btnStreamReader.Click += new System.EventHandler(this.btnStreamReader_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(544, 242);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFileReadAsync
            // 
            this.btnFileReadAsync.Location = new System.Drawing.Point(544, 129);
            this.btnFileReadAsync.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFileReadAsync.Name = "btnFileReadAsync";
            this.btnFileReadAsync.Size = new System.Drawing.Size(103, 37);
            this.btnFileReadAsync.TabIndex = 4;
            this.btnFileReadAsync.Text = "FileReadAsync";
            this.btnFileReadAsync.UseVisualStyleBackColor = true;
            this.btnFileReadAsync.Click += new System.EventHandler(this.btnFileReadAsync_Click);
            // 
            // btnStreamReadSync
            // 
            this.btnStreamReadSync.Location = new System.Drawing.Point(544, 187);
            this.btnStreamReadSync.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStreamReadSync.Name = "btnStreamReadSync";
            this.btnStreamReadSync.Size = new System.Drawing.Size(103, 36);
            this.btnStreamReadSync.TabIndex = 5;
            this.btnStreamReadSync.Text = "StreamReadAsync";
            this.btnStreamReadSync.UseVisualStyleBackColor = true;
            this.btnStreamReadSync.Click += new System.EventHandler(this.btnStreamReadAsync_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 291);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Connect to DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ReadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStreamReadSync);
            this.Controls.Add(this.btnFileReadAsync);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStreamReader);
            this.Controls.Add(this.btnFileStream);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReadFile";
            this.Text = "ReadFile";
            this.Load += new System.EventHandler(this.ReadFile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnFileStream;
        private System.Windows.Forms.Button btnStreamReader;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFileReadAsync;
        private System.Windows.Forms.Button btnStreamReadSync;
        private System.Windows.Forms.Button button1;
    }
}