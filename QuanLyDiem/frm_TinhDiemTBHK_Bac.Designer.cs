namespace QuanLySinhVien_Nhom2.QuanLyDiem
{
	partial class frm_TinhDiemTBHK_Bac
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
			this.cbo_ThongTinSV = new System.Windows.Forms.ComboBox();
			this.dgv_DiemTBHK = new System.Windows.Forms.DataGridView();
			this.btnTinhDiem = new System.Windows.Forms.Button();
			this.btnXetHocBong = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_TTTimKiem = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbo_hocky = new System.Windows.Forms.ComboBox();
			this.cbo_hocky_diem = new System.Windows.Forms.ComboBox();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_DiemTBHK)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sinh viên :";
			// 
			// cbo_ThongTinSV
			// 
			this.cbo_ThongTinSV.DisplayMember = "MaSV";
			this.cbo_ThongTinSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_ThongTinSV.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_ThongTinSV.FormattingEnabled = true;
			this.cbo_ThongTinSV.Location = new System.Drawing.Point(197, 70);
			this.cbo_ThongTinSV.Name = "cbo_ThongTinSV";
			this.cbo_ThongTinSV.Size = new System.Drawing.Size(401, 46);
			this.cbo_ThongTinSV.TabIndex = 7;
			this.cbo_ThongTinSV.SelectedIndexChanged += new System.EventHandler(this.cbo_ThongTinSV_SelectedIndexChanged);
			// 
			// dgv_DiemTBHK
			// 
			this.dgv_DiemTBHK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_DiemTBHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_DiemTBHK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dgv_DiemTBHK.Location = new System.Drawing.Point(31, 199);
			this.dgv_DiemTBHK.Name = "dgv_DiemTBHK";
			this.dgv_DiemTBHK.RowHeadersWidth = 62;
			this.dgv_DiemTBHK.RowTemplate.Height = 28;
			this.dgv_DiemTBHK.Size = new System.Drawing.Size(1226, 430);
			this.dgv_DiemTBHK.TabIndex = 8;
			// 
			// btnTinhDiem
			// 
			this.btnTinhDiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTinhDiem.Location = new System.Drawing.Point(611, 69);
			this.btnTinhDiem.Name = "btnTinhDiem";
			this.btnTinhDiem.Size = new System.Drawing.Size(168, 47);
			this.btnTinhDiem.TabIndex = 9;
			this.btnTinhDiem.Text = "Tính điểm";
			this.btnTinhDiem.UseVisualStyleBackColor = true;
			this.btnTinhDiem.Click += new System.EventHandler(this.btnTinhDiem_Click);
			// 
			// btnXetHocBong
			// 
			this.btnXetHocBong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXetHocBong.Location = new System.Drawing.Point(216, 56);
			this.btnXetHocBong.Name = "btnXetHocBong";
			this.btnXetHocBong.Size = new System.Drawing.Size(180, 47);
			this.btnXetHocBong.TabIndex = 10;
			this.btnXetHocBong.Text = "Xét học bổng";
			this.btnXetHocBong.UseVisualStyleBackColor = true;
			this.btnXetHocBong.Click += new System.EventHandler(this.btnXetHocBong_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(621, 155);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(403, 38);
			this.label2.TabIndex = 12;
			this.label2.Text = "Tìm kiếm theo điểm trung bình";
			// 
			// txt_TTTimKiem
			// 
			this.txt_TTTimKiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TTTimKiem.Location = new System.Drawing.Point(1030, 153);
			this.txt_TTTimKiem.Name = "txt_TTTimKiem";
			this.txt_TTTimKiem.Size = new System.Drawing.Size(227, 40);
			this.txt_TTTimKiem.TabIndex = 13;
			this.txt_TTTimKiem.TextChanged += new System.EventHandler(this.txt_TTTimKiem_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnXetHocBong);
			this.groupBox1.Controls.Add(this.cbo_hocky);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(31, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(419, 145);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Học kỳ";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbo_hocky_diem);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.btnTinhDiem);
			this.groupBox2.Controls.Add(this.cbo_ThongTinSV);
			this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(478, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(789, 122);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tính điểm trung bình chung học kỳ";
			// 
			// cbo_hocky
			// 
			this.cbo_hocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_hocky.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_hocky.FormattingEnabled = true;
			this.cbo_hocky.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
			this.cbo_hocky.Location = new System.Drawing.Point(25, 56);
			this.cbo_hocky.Name = "cbo_hocky";
			this.cbo_hocky.Size = new System.Drawing.Size(172, 44);
			this.cbo_hocky.TabIndex = 0;
			// 
			// cbo_hocky_diem
			// 
			this.cbo_hocky_diem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_hocky_diem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_hocky_diem.FormattingEnabled = true;
			this.cbo_hocky_diem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
			this.cbo_hocky_diem.Location = new System.Drawing.Point(350, 20);
			this.cbo_hocky_diem.Name = "cbo_hocky_diem";
			this.cbo_hocky_diem.Size = new System.Drawing.Size(248, 44);
			this.cbo_hocky_diem.TabIndex = 11;
			this.cbo_hocky_diem.SelectedIndexChanged += new System.EventHandler(this.cbo_hocky_diem_SelectedIndexChanged);
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "MaSV";
			this.Column6.FillWeight = 90F;
			this.Column6.HeaderText = "Mã sinh viên";
			this.Column6.MinimumWidth = 8;
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "HoDem";
			this.Column7.FillWeight = 70F;
			this.Column7.HeaderText = "Họ đệm";
			this.Column7.MinimumWidth = 8;
			this.Column7.Name = "Column7";
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "Ten";
			this.Column8.FillWeight = 60F;
			this.Column8.HeaderText = "Tên";
			this.Column8.MinimumWidth = 8;
			this.Column8.Name = "Column8";
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaMH";
			this.Column1.HeaderText = "Mã môn học";
			this.Column1.MinimumWidth = 8;
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "TenMH";
			this.Column2.HeaderText = "Tên môn học";
			this.Column2.MinimumWidth = 8;
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "SoTC";
			this.Column3.FillWeight = 80F;
			this.Column3.HeaderText = "Số tín chỉ";
			this.Column3.MinimumWidth = 8;
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "DiemHocPhan";
			this.Column4.FillWeight = 110F;
			this.Column4.HeaderText = "Điểm học phần";
			this.Column4.MinimumWidth = 8;
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "DiemTBHK";
			this.Column5.FillWeight = 140F;
			this.Column5.HeaderText = "Điểm trung bình học kỳ";
			this.Column5.MinimumWidth = 8;
			this.Column5.Name = "Column5";
			// 
			// frm_TinhDiemTBHK_Bac
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1305, 641);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txt_TTTimKiem);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgv_DiemTBHK);
			this.Name = "frm_TinhDiemTBHK_Bac";
			this.Text = "frm_TinhDiemTBHK_Bac";
			((System.ComponentModel.ISupportInitialize)(this.dgv_DiemTBHK)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbo_ThongTinSV;
		private System.Windows.Forms.DataGridView dgv_DiemTBHK;
		private System.Windows.Forms.Button btnTinhDiem;
		private System.Windows.Forms.Button btnXetHocBong;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_TTTimKiem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbo_hocky;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cbo_hocky_diem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}