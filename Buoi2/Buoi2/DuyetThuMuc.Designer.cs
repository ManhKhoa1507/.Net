namespace Buoi2
{
    partial class DuyetThuMuc
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
            this.DirectoryInfoClick = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Extented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DirectoryInfoClick
            // 
            this.DirectoryInfoClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryInfoClick.Location = new System.Drawing.Point(240, 387);
            this.DirectoryInfoClick.Name = "DirectoryInfoClick";
            this.DirectoryInfoClick.Size = new System.Drawing.Size(252, 51);
            this.DirectoryInfoClick.TabIndex = 0;
            this.DirectoryInfoClick.Text = "Chọn đường dẫn";
            this.DirectoryInfoClick.UseVisualStyleBackColor = true;
            this.DirectoryInfoClick.Click += new System.EventHandler(this.DirectoryInfoClick_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Size,
            this.Extented,
            this.Date});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(799, 369);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // FileName
            // 
            this.FileName.Text = "Tên File";
            // 
            // Size
            // 
            this.Size.Text = "Kích thước";
            // 
            // Extented
            // 
            this.Extented.Text = "Đuôi mở rộng";
            // 
            // Date
            // 
            this.Date.Text = "Ngày tạo";
            // 
            // DuyetThuMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DirectoryInfoClick);
            this.Name = "DuyetThuMuc";
            this.Text = "DuyetThuMuc";
            this.Load += new System.EventHandler(this.DuyetThuMuc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DirectoryInfoClick;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader FileName;
        public System.Windows.Forms.ColumnHeader Size;
        public System.Windows.Forms.ColumnHeader Extented;
        public System.Windows.Forms.ColumnHeader Date;
    }
}