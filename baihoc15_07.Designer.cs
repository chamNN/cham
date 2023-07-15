namespace baiHoc_15_07
{
    partial class baihoc15_07
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
            this.lbl_maLop = new System.Windows.Forms.Label();
            this.txt_maLop = new System.Windows.Forms.TextBox();
            this.txt_tenLop = new System.Windows.Forms.TextBox();
            this.lbl_tenLop = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.cmb_lop = new System.Windows.Forms.ComboBox();
            this.lbl_lop = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(287, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "quản lí lớp";
            // 
            // lbl_maLop
            // 
            this.lbl_maLop.AutoSize = true;
            this.lbl_maLop.Location = new System.Drawing.Point(161, 139);
            this.lbl_maLop.Name = "lbl_maLop";
            this.lbl_maLop.Size = new System.Drawing.Size(55, 16);
            this.lbl_maLop.TabIndex = 1;
            this.lbl_maLop.Text = "Mã Lớp:";
            // 
            // txt_maLop
            // 
            this.txt_maLop.Location = new System.Drawing.Point(263, 139);
            this.txt_maLop.Name = "txt_maLop";
            this.txt_maLop.Size = new System.Drawing.Size(252, 22);
            this.txt_maLop.TabIndex = 2;
            // 
            // txt_tenLop
            // 
            this.txt_tenLop.Location = new System.Drawing.Point(263, 188);
            this.txt_tenLop.Name = "txt_tenLop";
            this.txt_tenLop.Size = new System.Drawing.Size(252, 22);
            this.txt_tenLop.TabIndex = 4;
            // 
            // lbl_tenLop
            // 
            this.lbl_tenLop.AutoSize = true;
            this.lbl_tenLop.Location = new System.Drawing.Point(161, 188);
            this.lbl_tenLop.Name = "lbl_tenLop";
            this.lbl_tenLop.Size = new System.Drawing.Size(60, 16);
            this.lbl_tenLop.TabIndex = 3;
            this.lbl_tenLop.Text = "Tên Lớp:";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(568, 164);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // cmb_lop
            // 
            this.cmb_lop.FormattingEnabled = true;
            this.cmb_lop.Location = new System.Drawing.Point(263, 75);
            this.cmb_lop.Name = "cmb_lop";
            this.cmb_lop.Size = new System.Drawing.Size(121, 24);
            this.cmb_lop.TabIndex = 6;
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            this.lbl_lop.Location = new System.Drawing.Point(166, 75);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(67, 16);
            this.lbl_lop.TabIndex = 7;
            this.lbl_lop.Text = "Chọn Lớp:";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(568, 208);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // baihoc15_07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.lbl_lop);
            this.Controls.Add(this.cmb_lop);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_tenLop);
            this.Controls.Add(this.lbl_tenLop);
            this.Controls.Add(this.txt_maLop);
            this.Controls.Add(this.lbl_maLop);
            this.Controls.Add(this.label1);
            this.Name = "baihoc15_07";
            this.Text = "File Bài Học 15/07/2023";
            this.Load += new System.EventHandler(this.baihoc15_07_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_maLop;
        private System.Windows.Forms.TextBox txt_maLop;
        private System.Windows.Forms.TextBox txt_tenLop;
        private System.Windows.Forms.Label lbl_tenLop;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cmb_lop;
        private System.Windows.Forms.Label lbl_lop;
        private System.Windows.Forms.Button btn_xoa;
    }
}

