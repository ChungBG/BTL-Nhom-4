namespace BTLCK_n1
{
    partial class FrmHoaDonBan
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
            this.txtHDB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoHDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.dgvHDBan = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtNgayban = new System.Windows.Forms.MaskedTextBox();
            this.txtMakhach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHDB
            // 
            this.txtHDB.AutoSize = true;
            this.txtHDB.Location = new System.Drawing.Point(509, 14);
            this.txtHDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHDB.Name = "txtHDB";
            this.txtHDB.Size = new System.Drawing.Size(105, 17);
            this.txtHDB.TabIndex = 24;
            this.txtHDB.Text = "HÓA ĐƠN BÁN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã Khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số HDB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày Bán";
            // 
            // txtsoHDB
            // 
            this.txtsoHDB.Location = new System.Drawing.Point(208, 96);
            this.txtsoHDB.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoHDB.Name = "txtsoHDB";
            this.txtsoHDB.Size = new System.Drawing.Size(265, 22);
            this.txtsoHDB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tổng tiền";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(796, 188);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(265, 22);
            this.txtTongtien.TabIndex = 26;
            // 
            // dgvHDBan
            // 
            this.dgvHDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBan.Location = new System.Drawing.Point(107, 350);
            this.dgvHDBan.Name = "dgvHDBan";
            this.dgvHDBan.RowTemplate.Height = 24;
            this.dgvHDBan.Size = new System.Drawing.Size(914, 195);
            this.dgvHDBan.TabIndex = 27;
            this.dgvHDBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDBan_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(57, 607);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(208, 607);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(398, 607);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(608, 607);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(796, 607);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 32;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(986, 607);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 33;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(208, 188);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(265, 22);
            this.txtMaNV.TabIndex = 34;
            // 
            // txtNgayban
            // 
            this.txtNgayban.Location = new System.Drawing.Point(208, 304);
            this.txtNgayban.Mask = "00/00/0000 90:00";
            this.txtNgayban.Name = "txtNgayban";
            this.txtNgayban.Size = new System.Drawing.Size(265, 22);
            this.txtNgayban.TabIndex = 35;
            this.txtNgayban.ValidatingType = typeof(System.DateTime);
            // 
            // txtMakhach
            // 
            this.txtMakhach.Location = new System.Drawing.Point(796, 93);
            this.txtMakhach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Size = new System.Drawing.Size(265, 22);
            this.txtMakhach.TabIndex = 36;
            // 
            // FrmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 710);
            this.Controls.Add(this.txtMakhach);
            this.Controls.Add(this.txtNgayban);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHDBan);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsoHDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHoaDonBan";
            this.Text = "FrmHoaDonBan";
            this.Load += new System.EventHandler(this.FrmHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoHDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.DataGridView dgvHDBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.MaskedTextBox txtNgayban;
        private System.Windows.Forms.TextBox txtMakhach;
    }
}