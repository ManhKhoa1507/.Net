namespace Lab1
{
    partial class QuanLiDiem
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GradeAverage = new System.Windows.Forms.TextBox();
            this.MaxGrade = new System.Windows.Forms.TextBox();
            this.FailedCount = new System.Windows.Forms.TextBox();
            this.Power = new System.Windows.Forms.TextBox();
            this.MinGrade = new System.Windows.Forms.TextBox();
            this.PassCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm quản lí điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh sách môn học và điểm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 40);
            this.textBox1.TabIndex = 3;
            // 
            // Run
            // 
            this.Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Run.Location = new System.Drawing.Point(521, 95);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(211, 38);
            this.Run.TabIndex = 4;
            this.Run.Text = "Xuất";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(38, 139);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(705, 144);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // GradeAverage
            // 
            this.GradeAverage.BackColor = System.Drawing.SystemColors.Control;
            this.GradeAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GradeAverage.Location = new System.Drawing.Point(38, 309);
            this.GradeAverage.Name = "GradeAverage";
            this.GradeAverage.Size = new System.Drawing.Size(145, 20);
            this.GradeAverage.TabIndex = 6;
            this.GradeAverage.TextChanged += new System.EventHandler(this.DiemTB_TextChanged);
            // 
            // MaxGrade
            // 
            this.MaxGrade.BackColor = System.Drawing.SystemColors.Control;
            this.MaxGrade.Location = new System.Drawing.Point(38, 356);
            this.MaxGrade.Name = "MaxGrade";
            this.MaxGrade.Size = new System.Drawing.Size(145, 20);
            this.MaxGrade.TabIndex = 8;
            // 
            // FailedCount
            // 
            this.FailedCount.BackColor = System.Drawing.SystemColors.Control;
            this.FailedCount.Location = new System.Drawing.Point(38, 403);
            this.FailedCount.Multiline = true;
            this.FailedCount.Name = "FailedCount";
            this.FailedCount.Size = new System.Drawing.Size(145, 20);
            this.FailedCount.TabIndex = 9;
            // 
            // Power
            // 
            this.Power.BackColor = System.Drawing.SystemColors.Control;
            this.Power.Location = new System.Drawing.Point(549, 308);
            this.Power.Multiline = true;
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(137, 20);
            this.Power.TabIndex = 10;
            // 
            // MinGrade
            // 
            this.MinGrade.BackColor = System.Drawing.SystemColors.Control;
            this.MinGrade.Location = new System.Drawing.Point(549, 356);
            this.MinGrade.Name = "MinGrade";
            this.MinGrade.Size = new System.Drawing.Size(137, 20);
            this.MinGrade.TabIndex = 11;
            // 
            // PassCount
            // 
            this.PassCount.BackColor = System.Drawing.SystemColors.Control;
            this.PassCount.Location = new System.Drawing.Point(549, 403);
            this.PassCount.Name = "PassCount";
            this.PassCount.Size = new System.Drawing.Size(137, 20);
            this.PassCount.TabIndex = 12;
            // 
            // QuanLiDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PassCount);
            this.Controls.Add(this.MinGrade);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.FailedCount);
            this.Controls.Add(this.MaxGrade);
            this.Controls.Add(this.GradeAverage);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLiDiem";
            this.Text = "QuanLiDiem";
            this.Load += new System.EventHandler(this.QuanLiDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox GradeAverage;
        private System.Windows.Forms.TextBox MaxGrade;
        private System.Windows.Forms.TextBox FailedCount;
        private System.Windows.Forms.TextBox Power;
        private System.Windows.Forms.TextBox MinGrade;
        private System.Windows.Forms.TextBox PassCount;
    }
}