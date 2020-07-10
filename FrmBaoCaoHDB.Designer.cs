namespace BTLCK_n1
{
    partial class FrmBaoCaoHDB
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBCHDN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "BÁO CÁO HÓA ĐƠN BÁN";
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(730, 545);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(109, 23);
            this.btnXuat.TabIndex = 10;
            this.btnXuat.Text = "Xuat Excel";
            this.btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(491, 545);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(75, 23);
            this.btnHienthi.TabIndex = 9;
            this.btnHienthi.Text = "Hiển Thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(274, 547);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            this.txtMaNV.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // dgvBCHDN
            // 
            this.dgvBCHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCHDN.Location = new System.Drawing.Point(59, 110);
            this.dgvBCHDN.Name = "dgvBCHDN";
            this.dgvBCHDN.RowTemplate.Height = 24;
            this.dgvBCHDN.Size = new System.Drawing.Size(1029, 391);
            this.dgvBCHDN.TabIndex = 6;
            this.dgvBCHDN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBCHDN_CellContentClick);
            // 
            // FrmBaoCaoHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 639);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBCHDN);
            this.Name = "FrmBaoCaoHDB";
            this.Text = "FrmBaoCaoHDB";
            this.Load += new System.EventHandler(this.FrmBaoCaoHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBCHDN;
    }
}