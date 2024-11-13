namespace Nhom2_QuanLySinhVien
{
    partial class frm_SapXepLopHoc_Khanh
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
            this.lb_TieuDe_Khanh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_SapXep_Khanh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_DánhachLopHoc_Khanh = new System.Windows.Forms.Label();
            this.btn_SapXep_Khanh = new System.Windows.Forms.Button();
            this.btn_Huy_Khanh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SapXep_Khanh)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TieuDe_Khanh
            // 
            this.lb_TieuDe_Khanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TieuDe_Khanh.BackColor = System.Drawing.Color.SkyBlue;
            this.lb_TieuDe_Khanh.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe_Khanh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_TieuDe_Khanh.Location = new System.Drawing.Point(0, 0);
            this.lb_TieuDe_Khanh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TieuDe_Khanh.Name = "lb_TieuDe_Khanh";
            this.lb_TieuDe_Khanh.Size = new System.Drawing.Size(958, 54);
            this.lb_TieuDe_Khanh.TabIndex = 3;
            this.lb_TieuDe_Khanh.Text = "SẮP XẾP LỚP HỌC";
            this.lb_TieuDe_Khanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgv_SapXep_Khanh);
            this.panel1.Controls.Add(this.lb_DánhachLopHoc_Khanh);
            this.panel1.Location = new System.Drawing.Point(26, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 358);
            this.panel1.TabIndex = 4;
            // 
            // dgv_SapXep_Khanh
            // 
            this.dgv_SapXep_Khanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SapXep_Khanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_SapXep_Khanh.Location = new System.Drawing.Point(16, 60);
            this.dgv_SapXep_Khanh.Name = "dgv_SapXep_Khanh";
            this.dgv_SapXep_Khanh.RowHeadersWidth = 62;
            this.dgv_SapXep_Khanh.RowTemplate.Height = 28;
            this.dgv_SapXep_Khanh.Size = new System.Drawing.Size(860, 281);
            this.dgv_SapXep_Khanh.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLop";
            this.Column1.HeaderText = "Mã lớp";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLop";
            this.Column2.HeaderText = "Tên lớp";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "KhoaHoc";
            this.Column3.HeaderText = "Khoá học";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HeDaoTao";
            this.Column4.HeaderText = "Hệ đào tạo";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NamNhapHoc";
            this.Column5.HeaderText = "Năm nhập học";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // lb_DánhachLopHoc_Khanh
            // 
            this.lb_DánhachLopHoc_Khanh.AutoSize = true;
            this.lb_DánhachLopHoc_Khanh.Location = new System.Drawing.Point(40, 19);
            this.lb_DánhachLopHoc_Khanh.Name = "lb_DánhachLopHoc_Khanh";
            this.lb_DánhachLopHoc_Khanh.Size = new System.Drawing.Size(159, 25);
            this.lb_DánhachLopHoc_Khanh.TabIndex = 0;
            this.lb_DánhachLopHoc_Khanh.Text = "Danh sách lớp học";
            // 
            // btn_SapXep_Khanh
            // 
            this.btn_SapXep_Khanh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_SapXep_Khanh.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_SapXep_Khanh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SapXep_Khanh.ForeColor = System.Drawing.Color.Snow;
            this.btn_SapXep_Khanh.Location = new System.Drawing.Point(252, 470);
            this.btn_SapXep_Khanh.Name = "btn_SapXep_Khanh";
            this.btn_SapXep_Khanh.Size = new System.Drawing.Size(120, 38);
            this.btn_SapXep_Khanh.TabIndex = 5;
            this.btn_SapXep_Khanh.Text = "Sắp Xếp";
            this.btn_SapXep_Khanh.UseVisualStyleBackColor = false;
            this.btn_SapXep_Khanh.Click += new System.EventHandler(this.btn_SapXep_Khanh_Click);
            // 
            // btn_Huy_Khanh
            // 
            this.btn_Huy_Khanh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Huy_Khanh.BackColor = System.Drawing.Color.Gray;
            this.btn_Huy_Khanh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy_Khanh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Huy_Khanh.Location = new System.Drawing.Point(529, 470);
            this.btn_Huy_Khanh.Name = "btn_Huy_Khanh";
            this.btn_Huy_Khanh.Size = new System.Drawing.Size(120, 38);
            this.btn_Huy_Khanh.TabIndex = 5;
            this.btn_Huy_Khanh.Text = "Huỷ";
            this.btn_Huy_Khanh.UseVisualStyleBackColor = false;
            this.btn_Huy_Khanh.Click += new System.EventHandler(this.btn_Huy_Khanh_Click);
            // 
            // frm_SapXep_Khanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 553);
            this.Controls.Add(this.btn_Huy_Khanh);
            this.Controls.Add(this.btn_SapXep_Khanh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_TieuDe_Khanh);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_SapXep_Khanh";
            this.Text = "Quản lý lớp học - Sắp Xếp - Khánh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SapXep_Khanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_TieuDe_Khanh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_DánhachLopHoc_Khanh;
        private System.Windows.Forms.DataGridView dgv_SapXep_Khanh;
        private System.Windows.Forms.Button btn_SapXep_Khanh;
        private System.Windows.Forms.Button btn_Huy_Khanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}