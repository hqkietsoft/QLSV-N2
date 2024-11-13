namespace Nhom2_QuanLySinhVien
{
    partial class frm_DiemThi_Khanh
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
            this.lbl_TieuDe_Khanh = new System.Windows.Forms.Label();
            this.grb_ThongTin_Khanh = new System.Windows.Forms.GroupBox();
            this.cb_Mon_Khanh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_LuuTatCa_Khanh = new System.Windows.Forms.Button();
            this.dgv_DiemThi_Khanh = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoDem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQuaTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_ThongTin_Khanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DiemThi_Khanh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TieuDe_Khanh
            // 
            this.lbl_TieuDe_Khanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TieuDe_Khanh.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_TieuDe_Khanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe_Khanh.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbl_TieuDe_Khanh.Location = new System.Drawing.Point(1, 0);
            this.lbl_TieuDe_Khanh.Name = "lbl_TieuDe_Khanh";
            this.lbl_TieuDe_Khanh.Size = new System.Drawing.Size(928, 48);
            this.lbl_TieuDe_Khanh.TabIndex = 0;
            this.lbl_TieuDe_Khanh.Text = "TÍNH ĐIỂM THI";
            this.lbl_TieuDe_Khanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grb_ThongTin_Khanh
            // 
            this.grb_ThongTin_Khanh.Controls.Add(this.cb_Mon_Khanh);
            this.grb_ThongTin_Khanh.Controls.Add(this.label3);
            this.grb_ThongTin_Khanh.Location = new System.Drawing.Point(8, 64);
            this.grb_ThongTin_Khanh.Name = "grb_ThongTin_Khanh";
            this.grb_ThongTin_Khanh.Size = new System.Drawing.Size(1017, 99);
            this.grb_ThongTin_Khanh.TabIndex = 1;
            this.grb_ThongTin_Khanh.TabStop = false;
            this.grb_ThongTin_Khanh.Text = "Thông tin chi tiết";
            // 
            // cb_Mon_Khanh
            // 
            this.cb_Mon_Khanh.FormattingEnabled = true;
            this.cb_Mon_Khanh.Location = new System.Drawing.Point(423, 37);
            this.cb_Mon_Khanh.Name = "cb_Mon_Khanh";
            this.cb_Mon_Khanh.Size = new System.Drawing.Size(225, 21);
            this.cb_Mon_Khanh.TabIndex = 5;
            this.cb_Mon_Khanh.SelectedIndexChanged += new System.EventHandler(this.cb_Mon_Khanh_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Môn học:";
            // 
            // btn_LuuTatCa_Khanh
            // 
            this.btn_LuuTatCa_Khanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuTatCa_Khanh.Location = new System.Drawing.Point(442, 556);
            this.btn_LuuTatCa_Khanh.Name = "btn_LuuTatCa_Khanh";
            this.btn_LuuTatCa_Khanh.Size = new System.Drawing.Size(132, 40);
            this.btn_LuuTatCa_Khanh.TabIndex = 3;
            this.btn_LuuTatCa_Khanh.Text = "Lưu Tất Cả";
            this.btn_LuuTatCa_Khanh.UseVisualStyleBackColor = true;
            this.btn_LuuTatCa_Khanh.Click += new System.EventHandler(this.btn_LuuTatCa_Khanh_Click);
            // 
            // dgv_DiemThi_Khanh
            // 
            this.dgv_DiemThi_Khanh.AllowUserToAddRows = false;
            this.dgv_DiemThi_Khanh.AllowUserToDeleteRows = false;
            this.dgv_DiemThi_Khanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DiemThi_Khanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.MaMH,
            this.HoDem,
            this.Ten,
            this.DiemQuaTrinh,
            this.DiemThi,
            this.DiemHocPhan});
            this.dgv_DiemThi_Khanh.Location = new System.Drawing.Point(8, 169);
            this.dgv_DiemThi_Khanh.Name = "dgv_DiemThi_Khanh";
            this.dgv_DiemThi_Khanh.RowHeadersWidth = 62;
            this.dgv_DiemThi_Khanh.RowTemplate.Height = 28;
            this.dgv_DiemThi_Khanh.Size = new System.Drawing.Size(1017, 362);
            this.dgv_DiemThi_Khanh.TabIndex = 2;
            this.dgv_DiemThi_Khanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DiemThi_Khanh_CellClick);
            this.dgv_DiemThi_Khanh.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DiemThi_Khanh_CellEndEdit);
            this.dgv_DiemThi_Khanh.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_DiemThi_Khanh_CellValidating);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 8;
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            this.MaSV.Width = 150;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã môn học";
            this.MaMH.MinimumWidth = 8;
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 150;
            // 
            // HoDem
            // 
            this.HoDem.DataPropertyName = "HoDem";
            this.HoDem.HeaderText = "Họ đệm";
            this.HoDem.MinimumWidth = 8;
            this.HoDem.Name = "HoDem";
            this.HoDem.ReadOnly = true;
            this.HoDem.Width = 150;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 8;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 150;
            // 
            // DiemQuaTrinh
            // 
            this.DiemQuaTrinh.DataPropertyName = "DiemQuaTrinh";
            this.DiemQuaTrinh.HeaderText = "Điểm quá trinh";
            this.DiemQuaTrinh.MinimumWidth = 8;
            this.DiemQuaTrinh.Name = "DiemQuaTrinh";
            this.DiemQuaTrinh.Width = 150;
            // 
            // DiemThi
            // 
            this.DiemThi.DataPropertyName = "DiemThi";
            this.DiemThi.HeaderText = "Điểm thi";
            this.DiemThi.MinimumWidth = 8;
            this.DiemThi.Name = "DiemThi";
            this.DiemThi.Width = 200;
            // 
            // DiemHocPhan
            // 
            this.DiemHocPhan.DataPropertyName = "DiemHocPhan";
            this.DiemHocPhan.HeaderText = "Điểm học phần";
            this.DiemHocPhan.MinimumWidth = 8;
            this.DiemHocPhan.Name = "DiemHocPhan";
            this.DiemHocPhan.ReadOnly = true;
            this.DiemHocPhan.Width = 150;
            // 
            // frm_DiemThi_Khanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 676);
            this.Controls.Add(this.btn_LuuTatCa_Khanh);
            this.Controls.Add(this.dgv_DiemThi_Khanh);
            this.Controls.Add(this.grb_ThongTin_Khanh);
            this.Controls.Add(this.lbl_TieuDe_Khanh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_DiemThi_Khanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DiemThi_Khanh";
            this.grb_ThongTin_Khanh.ResumeLayout(false);
            this.grb_ThongTin_Khanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DiemThi_Khanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_TieuDe_Khanh;
        private System.Windows.Forms.GroupBox grb_ThongTin_Khanh;
        private System.Windows.Forms.Button btn_LuuTatCa_Khanh;
        private System.Windows.Forms.ComboBox cb_Mon_Khanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_DiemThi_Khanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoDem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQuaTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemHocPhan;
    }
}