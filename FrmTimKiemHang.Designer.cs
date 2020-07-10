namespace BTLCK_n1
{
    partial class FrmTimKiemHang
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtManhom = new System.Windows.Forms.TextBox();
            this.txtMachatlieu = new System.Windows.Forms.TextBox();
            this.txtMacongdung = new System.Windows.Forms.TextBox();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.btnTukhoa = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvTKhang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKhang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhóm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã chất liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(754, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã công dụng";
            // 
            // txtManhom
            // 
            this.txtManhom.Location = new System.Drawing.Point(203, 115);
            this.txtManhom.Name = "txtManhom";
            this.txtManhom.Size = new System.Drawing.Size(100, 22);
            this.txtManhom.TabIndex = 4;
            // 
            // txtMachatlieu
            // 
            this.txtMachatlieu.Location = new System.Drawing.Point(203, 188);
            this.txtMachatlieu.Name = "txtMachatlieu";
            this.txtMachatlieu.Size = new System.Drawing.Size(100, 22);
            this.txtMachatlieu.TabIndex = 5;
            // 
            // txtMacongdung
            // 
            this.txtMacongdung.Location = new System.Drawing.Point(898, 101);
            this.txtMacongdung.Name = "txtMacongdung";
            this.txtMacongdung.Size = new System.Drawing.Size(100, 22);
            this.txtMacongdung.TabIndex = 6;
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Location = new System.Drawing.Point(733, 188);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(100, 22);
            this.txtTukhoa.TabIndex = 7;
            // 
            // btnTukhoa
            // 
            this.btnTukhoa.Location = new System.Drawing.Point(898, 187);
            this.btnTukhoa.Name = "btnTukhoa";
            this.btnTukhoa.Size = new System.Drawing.Size(75, 23);
            this.btnTukhoa.TabIndex = 8;
            this.btnTukhoa.Text = "Từ khóa";
            this.btnTukhoa.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(308, 459);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 9;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnTimlai
            // 
            this.btnTimlai.Location = new System.Drawing.Point(514, 459);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(75, 23);
            this.btnTimlai.TabIndex = 10;
            this.btnTimlai.Text = "Tìm lại";
            this.btnTimlai.UseVisualStyleBackColor = true;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(733, 459);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dgvTKhang
            // 
            this.dgvTKhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKhang.Location = new System.Drawing.Point(184, 262);
            this.dgvTKhang.Name = "dgvTKhang";
            this.dgvTKhang.RowTemplate.Height = 24;
            this.dgvTKhang.Size = new System.Drawing.Size(852, 150);
            this.dgvTKhang.TabIndex = 12;
            this.dgvTKhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTKhang_CellContentClick);
            // 
            // FrmTimKiemHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 506);
            this.Controls.Add(this.dgvTKhang);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimlai);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnTukhoa);
            this.Controls.Add(this.txtTukhoa);
            this.Controls.Add(this.txtMacongdung);
            this.Controls.Add(this.txtMachatlieu);
            this.Controls.Add(this.txtManhom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTimKiemHang";
            this.Text = "FrmTimKiemHang";
            this.Load += new System.EventHandler(this.FrmTimKiemHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManhom;
        private System.Windows.Forms.TextBox txtMachatlieu;
        private System.Windows.Forms.TextBox txtMacongdung;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Button btnTukhoa;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvTKhang;
    }
}