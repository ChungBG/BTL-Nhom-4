namespace BTLCK_n1
{
    partial class FrmTimHDNhap
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.dgvTKHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoHDN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgaynhap = new System.Windows.Forms.MaskedTextBox();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.btnTukhoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(657, 516);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 28);
            this.btnDong.TabIndex = 46;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTimlai
            // 
            this.btnTimlai.Location = new System.Drawing.Point(481, 516);
            this.btnTimlai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(100, 28);
            this.btnTimlai.TabIndex = 45;
            this.btnTimlai.Text = "Tìm lại";
            this.btnTimlai.UseVisualStyleBackColor = true;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(303, 516);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimkiem.TabIndex = 44;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // dgvTKHoaDonNhap
            // 
            this.dgvTKHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKHoaDonNhap.Location = new System.Drawing.Point(49, 260);
            this.dgvTKHoaDonNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTKHoaDonNhap.Name = "dgvTKHoaDonNhap";
            this.dgvTKHoaDonNhap.Size = new System.Drawing.Size(957, 222);
            this.dgvTKHoaDonNhap.TabIndex = 43;
            this.dgvTKHoaDonNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTKHoaDonNhap_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "TÌM KIẾM HÓA ĐƠN NHẬP";
            // 
            // txtsoHDN
            // 
            this.txtsoHDN.Location = new System.Drawing.Point(124, 94);
            this.txtsoHDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsoHDN.Name = "txtsoHDN";
            this.txtsoHDN.Size = new System.Drawing.Size(352, 22);
            this.txtsoHDN.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Mã NCC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Số HDN";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(124, 172);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(121, 24);
            this.cboMaNV.TabIndex = 48;
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(632, 94);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(121, 24);
            this.cboMaNCC.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Ngày nhập";
            // 
            // txtNgaynhap
            // 
            this.txtNgaynhap.Location = new System.Drawing.Point(641, 169);
            this.txtNgaynhap.Mask = "00/00/0000 90:00";
            this.txtNgaynhap.Name = "txtNgaynhap";
            this.txtNgaynhap.Size = new System.Drawing.Size(100, 22);
            this.txtNgaynhap.TabIndex = 51;
            this.txtNgaynhap.ValidatingType = typeof(System.DateTime);
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Location = new System.Drawing.Point(540, 220);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(100, 22);
            this.txtTukhoa.TabIndex = 52;
            // 
            // btnTukhoa
            // 
            this.btnTukhoa.Location = new System.Drawing.Point(670, 220);
            this.btnTukhoa.Name = "btnTukhoa";
            this.btnTukhoa.Size = new System.Drawing.Size(75, 23);
            this.btnTukhoa.TabIndex = 53;
            this.btnTukhoa.Text = "Từ khóa";
            this.btnTukhoa.UseVisualStyleBackColor = true;
            // 
            // FrmTimHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 569);
            this.Controls.Add(this.btnTukhoa);
            this.Controls.Add(this.txtTukhoa);
            this.Controls.Add(this.txtNgaynhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMaNCC);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimlai);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.dgvTKHoaDonNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsoHDN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTimHDNhap";
            this.Text = "FrmTimHDNhap";
            this.Load += new System.EventHandler(this.FrmTimHDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHoaDonNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridView dgvTKHoaDonNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsoHDN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtNgaynhap;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Button btnTukhoa;
    }
}