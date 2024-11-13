namespace Nhom2_QuanLySinhVien
{
    partial class frm_TimKiemLopHoc_Khanh
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
            this.cb_Khoa_Khanh = new System.Windows.Forms.ComboBox();
            this.btn_TimKiem_Khanh = new System.Windows.Forms.Button();
            this.tb_TuKhoa_Khanh = new System.Windows.Forms.TextBox();
            this.lb_Khoa_Khanh = new System.Windows.Forms.Label();
            this.lb_TuKhoa_Khanh = new System.Windows.Forms.Label();
            this.dgv_TimKiem_Khanh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TimKiem_Khanh)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TieuDe_Khanh
            // 
            this.lb_TieuDe_Khanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TieuDe_Khanh.BackColor = System.Drawing.Color.Salmon;
            this.lb_TieuDe_Khanh.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe_Khanh.ForeColor = System.Drawing.Color.White;
            this.lb_TieuDe_Khanh.Location = new System.Drawing.Point(0, 0);
            this.lb_TieuDe_Khanh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TieuDe_Khanh.Name = "lb_TieuDe_Khanh";
            this.lb_TieuDe_Khanh.Size = new System.Drawing.Size(1110, 48);
            this.lb_TieuDe_Khanh.TabIndex = 4;
            this.lb_TieuDe_Khanh.Text = "TÌM KIẾM LỚP HỌC";
            this.lb_TieuDe_Khanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cb_Khoa_Khanh);
            this.panel1.Controls.Add(this.btn_TimKiem_Khanh);
            this.panel1.Controls.Add(this.tb_TuKhoa_Khanh);
            this.panel1.Controls.Add(this.lb_Khoa_Khanh);
            this.panel1.Controls.Add(this.lb_TuKhoa_Khanh);
            this.panel1.Location = new System.Drawing.Point(25, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 130);
            this.panel1.TabIndex = 5;
            // 
            // cb_Khoa_Khanh
            // 
            this.cb_Khoa_Khanh.FormattingEnabled = true;
            this.cb_Khoa_Khanh.Location = new System.Drawing.Point(444, 43);
            this.cb_Khoa_Khanh.Name = "cb_Khoa_Khanh";
            this.cb_Khoa_Khanh.Size = new System.Drawing.Size(189, 36);
            this.cb_Khoa_Khanh.TabIndex = 5;
            // 
            // btn_TimKiem_Khanh
            // 
            this.btn_TimKiem_Khanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TimKiem_Khanh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_TimKiem_Khanh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem_Khanh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TimKiem_Khanh.Location = new System.Drawing.Point(710, 37);
            this.btn_TimKiem_Khanh.Name = "btn_TimKiem_Khanh";
            this.btn_TimKiem_Khanh.Size = new System.Drawing.Size(135, 50);
            this.btn_TimKiem_Khanh.TabIndex = 4;
            this.btn_TimKiem_Khanh.Text = "Tìm Kiếm";
            this.btn_TimKiem_Khanh.UseVisualStyleBackColor = false;
            this.btn_TimKiem_Khanh.Click += new System.EventHandler(this.btn_TimKiem_Khanh_Click);
            // 
            // tb_TuKhoa_Khanh
            // 
            this.tb_TuKhoa_Khanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_TuKhoa_Khanh.Location = new System.Drawing.Point(128, 45);
            this.tb_TuKhoa_Khanh.Name = "tb_TuKhoa_Khanh";
            this.tb_TuKhoa_Khanh.Size = new System.Drawing.Size(189, 34);
            this.tb_TuKhoa_Khanh.TabIndex = 2;
            // 
            // lb_Khoa_Khanh
            // 
            this.lb_Khoa_Khanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_Khoa_Khanh.AutoSize = true;
            this.lb_Khoa_Khanh.Location = new System.Drawing.Point(377, 48);
            this.lb_Khoa_Khanh.Name = "lb_Khoa_Khanh";
            this.lb_Khoa_Khanh.Size = new System.Drawing.Size(61, 28);
            this.lb_Khoa_Khanh.TabIndex = 1;
            this.lb_Khoa_Khanh.Text = "Khoa:";
            // 
            // lb_TuKhoa_Khanh
            // 
            this.lb_TuKhoa_Khanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_TuKhoa_Khanh.AutoSize = true;
            this.lb_TuKhoa_Khanh.Location = new System.Drawing.Point(38, 48);
            this.lb_TuKhoa_Khanh.Name = "lb_TuKhoa_Khanh";
            this.lb_TuKhoa_Khanh.Size = new System.Drawing.Size(88, 28);
            this.lb_TuKhoa_Khanh.TabIndex = 0;
            this.lb_TuKhoa_Khanh.Text = "Từ Khoá:";
            // 
            // dgv_TimKiem_Khanh
            // 
            this.dgv_TimKiem_Khanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TimKiem_Khanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TimKiem_Khanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_TimKiem_Khanh.Location = new System.Drawing.Point(25, 257);
            this.dgv_TimKiem_Khanh.Name = "dgv_TimKiem_Khanh";
            this.dgv_TimKiem_Khanh.RowHeadersWidth = 62;
            this.dgv_TimKiem_Khanh.RowTemplate.Height = 28;
            this.dgv_TimKiem_Khanh.Size = new System.Drawing.Size(1057, 342);
            this.dgv_TimKiem_Khanh.TabIndex = 6;
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
            this.Column5.Width = 250;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaKhoa";
            this.Column6.HeaderText = "Khoa";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(888, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Huỷ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_TimKiem_Khanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 630);
            this.Controls.Add(this.dgv_TimKiem_Khanh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_TieuDe_Khanh);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_TimKiem_Khanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lớp học - Tìm Kiếm";
            this.Load += new System.EventHandler(this.frm_TimKiem_Khanh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TimKiem_Khanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_TieuDe_Khanh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_TimKiem_Khanh;
        private System.Windows.Forms.TextBox tb_TuKhoa_Khanh;
        private System.Windows.Forms.Label lb_Khoa_Khanh;
        private System.Windows.Forms.Label lb_TuKhoa_Khanh;
        private System.Windows.Forms.Button btn_TimKiem_Khanh;
        private System.Windows.Forms.ComboBox cb_Khoa_Khanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
    }
}