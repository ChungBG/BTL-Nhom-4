namespace BTLCK_n1
{
    partial class FrmBCKHtheoQuy
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
            this.txtQuy = new System.Windows.Forms.TextBox();
            this.dgvBCKH = new System.Windows.Forms.DataGridView();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qúy";
            // 
            // txtQuy
            // 
            this.txtQuy.Location = new System.Drawing.Point(128, 72);
            this.txtQuy.Name = "txtQuy";
            this.txtQuy.Size = new System.Drawing.Size(100, 22);
            this.txtQuy.TabIndex = 1;
            // 
            // dgvBCKH
            // 
            this.dgvBCKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCKH.Location = new System.Drawing.Point(158, 208);
            this.dgvBCKH.Name = "dgvBCKH";
            this.dgvBCKH.RowTemplate.Height = 24;
            this.dgvBCKH.Size = new System.Drawing.Size(771, 150);
            this.dgvBCKH.TabIndex = 2;
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(183, 435);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(75, 23);
            this.btnBaocao.TabIndex = 3;
            this.btnBaocao.Text = "Báo cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(599, 435);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // FrmBCKHtheoQuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 566);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.dgvBCKH);
            this.Controls.Add(this.txtQuy);
            this.Controls.Add(this.label1);
            this.Name = "FrmBCKHtheoQuy";
            this.Text = "FrmBCKHtheoQuy";
            this.Load += new System.EventHandler(this.FrmBCKHtheoQuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuy;
        private System.Windows.Forms.DataGridView dgvBCKH;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnDong;
    }
}