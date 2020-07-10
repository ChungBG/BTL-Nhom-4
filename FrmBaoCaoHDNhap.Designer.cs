namespace BTLCK_n1
{
    partial class FrmBaoCaoHDNhap
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
            this.txtNam = new System.Windows.Forms.TextBox();
            this.dgvBCHDNhap = new System.Windows.Forms.DataGridView();
            this.btnHienthitheonam = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCHDNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(206, 126);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 22);
            this.txtNam.TabIndex = 4;
            // 
            // dgvBCHDNhap
            // 
            this.dgvBCHDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCHDNhap.Location = new System.Drawing.Point(469, 51);
            this.dgvBCHDNhap.Name = "dgvBCHDNhap";
            this.dgvBCHDNhap.RowTemplate.Height = 24;
            this.dgvBCHDNhap.Size = new System.Drawing.Size(528, 229);
            this.dgvBCHDNhap.TabIndex = 6;
            // 
            // btnHienthitheonam
            // 
            this.btnHienthitheonam.Location = new System.Drawing.Point(114, 232);
            this.btnHienthitheonam.Name = "btnHienthitheonam";
            this.btnHienthitheonam.Size = new System.Drawing.Size(269, 23);
            this.btnHienthitheonam.TabIndex = 7;
            this.btnHienthitheonam.Text = "Hiển thị theo năm";
            this.btnHienthitheonam.UseVisualStyleBackColor = true;
            this.btnHienthitheonam.Click += new System.EventHandler(this.btnHienthitheonam_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(575, 369);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(269, 23);
            this.btnXuat.TabIndex = 8;
            this.btnXuat.Text = "Xuất file năm";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // FrmBaoCaoHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 592);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnHienthitheonam);
            this.Controls.Add(this.dgvBCHDNhap);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label2);
            this.Name = "FrmBaoCaoHDNhap";
            this.Text = "FrmBaoCaoHDNhap";
            this.Load += new System.EventHandler(this.FrmBaoCaoHDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCHDNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.DataGridView dgvBCHDNhap;
        private System.Windows.Forms.Button btnHienthitheonam;
        private System.Windows.Forms.Button btnXuat;
    }
}