namespace Buoi2
{
    partial class ThongTinSinhVien
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
            this.Write = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.GetInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GetLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Write
            // 
            this.Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Write.Location = new System.Drawing.Point(12, 22);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(179, 68);
            this.Write.TabIndex = 1;
            this.Write.Text = "Nhập";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Save.Location = new System.Drawing.Point(12, 131);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(179, 68);
            this.Save.TabIndex = 2;
            this.Save.Text = "Lưu";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // GetInfo
            // 
            this.GetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.GetInfo.Location = new System.Drawing.Point(12, 225);
            this.GetInfo.Name = "GetInfo";
            this.GetInfo.Size = new System.Drawing.Size(179, 93);
            this.GetInfo.TabIndex = 3;
            this.GetInfo.Text = "Hiển thị thông tin";
            this.GetInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GetInfo.UseVisualStyleBackColor = true;
            this.GetInfo.Click += new System.EventHandler(this.GetInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 402);
            this.dataGridView1.TabIndex = 4;
            // 
            // GetLocation
            // 
            this.GetLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.GetLocation.Location = new System.Drawing.Point(12, 331);
            this.GetLocation.Name = "GetLocation";
            this.GetLocation.Size = new System.Drawing.Size(179, 93);
            this.GetLocation.TabIndex = 5;
            this.GetLocation.Text = "Chọn nơi lưu trữ";
            this.GetLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GetLocation.UseVisualStyleBackColor = true;
            this.GetLocation.Click += new System.EventHandler(this.GetLocation_Click);
            // 
            // ThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetLocation);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GetInfo);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Write);
            this.Name = "ThongTinSinhVien";
            this.Text = "ThongTinSinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button GetInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GetLocation;
    }
}