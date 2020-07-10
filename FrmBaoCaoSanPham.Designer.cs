namespace BTLCK_n1
{
    partial class FrmBaoCaoSanPham
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
            this.dgvBCSP = new System.Windows.Forms.DataGridView();
            this.btnXuat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.mskThang = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày bán";
            // 
            // dgvBCSP
            // 
            this.dgvBCSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCSP.Location = new System.Drawing.Point(85, 290);
            this.dgvBCSP.Name = "dgvBCSP";
            this.dgvBCSP.RowTemplate.Height = 24;
            this.dgvBCSP.Size = new System.Drawing.Size(903, 210);
            this.dgvBCSP.TabIndex = 6;
            this.dgvBCSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBCSP_CellContentClick);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(430, 558);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(198, 23);
            this.btnXuat.TabIndex = 7;
            this.btnXuat.Text = "Xuất Excel";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "SẢN PHẨM BÁN CHẠY NHẤT";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(534, 165);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 9;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click_1);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(807, 165);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 10;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click_1);
            // 
            // mskThang
            // 
            this.mskThang.Location = new System.Drawing.Point(192, 171);
            this.mskThang.Mask = "00/00/0000";
            this.mskThang.Name = "mskThang";
            this.mskThang.Size = new System.Drawing.Size(100, 22);
            this.mskThang.TabIndex = 11;
            this.mskThang.ValidatingType = typeof(System.DateTime);
            // 
            // FrmBaoCaoSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 646);
            this.Controls.Add(this.mskThang);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.dgvBCSP);
            this.Controls.Add(this.label1);
            this.Name = "FrmBaoCaoSanPham";
            this.Text = "FrmBaoCaoSanPham";
            this.Load += new System.EventHandler(this.FrmBaoCaoSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBCSP;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.MaskedTextBox mskThang;
    }
}