namespace Nhom2_QuanLySinhVien.QuanLyMonHoc
{
	partial class frm_QuanLyMonHoc_Bac
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_addNew_Bac = new System.Windows.Forms.Button();
            this.btn_SuaMH_Bac = new System.Windows.Forms.Button();
            this.btn_XoaMH_Bac = new System.Windows.Forms.Button();
            this.cbo_SapxepMonHoc_Bac = new System.Windows.Forms.ComboBox();
            this.dgv_DSMonHoc_Bac = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_TimKiem_Bac = new System.Windows.Forms.TextBox();
            this.lb_somonhoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSMonHoc_Bac)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addNew_Bac
            // 
            this.btn_addNew_Bac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addNew_Bac.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_addNew_Bac.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNew_Bac.ForeColor = System.Drawing.Color.White;
            this.btn_addNew_Bac.Location = new System.Drawing.Point(7, 42);
            this.btn_addNew_Bac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addNew_Bac.Name = "btn_addNew_Bac";
            this.btn_addNew_Bac.Size = new System.Drawing.Size(130, 43);
            this.btn_addNew_Bac.TabIndex = 1;
            this.btn_addNew_Bac.Text = "Thêm mới";
            this.btn_addNew_Bac.UseVisualStyleBackColor = false;
            this.btn_addNew_Bac.Click += new System.EventHandler(this.btn_addNew_Bac_Click);
            // 
            // btn_SuaMH_Bac
            // 
            this.btn_SuaMH_Bac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SuaMH_Bac.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_SuaMH_Bac.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaMH_Bac.ForeColor = System.Drawing.Color.White;
            this.btn_SuaMH_Bac.Location = new System.Drawing.Point(145, 43);
            this.btn_SuaMH_Bac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SuaMH_Bac.Name = "btn_SuaMH_Bac";
            this.btn_SuaMH_Bac.Size = new System.Drawing.Size(135, 43);
            this.btn_SuaMH_Bac.TabIndex = 2;
            this.btn_SuaMH_Bac.Text = "Cập nhật";
            this.btn_SuaMH_Bac.UseVisualStyleBackColor = false;
            this.btn_SuaMH_Bac.Click += new System.EventHandler(this.btn_SuaMH_Bac_Click);
            // 
            // btn_XoaMH_Bac
            // 
            this.btn_XoaMH_Bac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XoaMH_Bac.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_XoaMH_Bac.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaMH_Bac.ForeColor = System.Drawing.Color.White;
            this.btn_XoaMH_Bac.Location = new System.Drawing.Point(285, 42);
            this.btn_XoaMH_Bac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_XoaMH_Bac.Name = "btn_XoaMH_Bac";
            this.btn_XoaMH_Bac.Size = new System.Drawing.Size(144, 43);
            this.btn_XoaMH_Bac.TabIndex = 3;
            this.btn_XoaMH_Bac.Text = "Xóa";
            this.btn_XoaMH_Bac.UseVisualStyleBackColor = false;
            this.btn_XoaMH_Bac.Click += new System.EventHandler(this.btn_XoaMH_Bac_Click);
            // 
            // cbo_SapxepMonHoc_Bac
            // 
            this.cbo_SapxepMonHoc_Bac.BackColor = System.Drawing.Color.Wheat;
            this.cbo_SapxepMonHoc_Bac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_SapxepMonHoc_Bac.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_SapxepMonHoc_Bac.FormattingEnabled = true;
            this.cbo_SapxepMonHoc_Bac.Items.AddRange(new object[] {
            "Theo mã môn học",
            "Theo tên môn học ",
            "Theo số tín chỉ "});
            this.cbo_SapxepMonHoc_Bac.Location = new System.Drawing.Point(675, 45);
            this.cbo_SapxepMonHoc_Bac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_SapxepMonHoc_Bac.Name = "cbo_SapxepMonHoc_Bac";
            this.cbo_SapxepMonHoc_Bac.Size = new System.Drawing.Size(219, 29);
            this.cbo_SapxepMonHoc_Bac.TabIndex = 8;
            this.cbo_SapxepMonHoc_Bac.SelectedIndexChanged += new System.EventHandler(this.cbo_SapxepMonHoc_Bac_SelectedIndexChanged);
            // 
            // dgv_DSMonHoc_Bac
            // 
            this.dgv_DSMonHoc_Bac.AllowUserToAddRows = false;
            this.dgv_DSMonHoc_Bac.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgv_DSMonHoc_Bac.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DSMonHoc_Bac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSMonHoc_Bac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DSMonHoc_Bac.ColumnHeadersHeight = 22;
            this.dgv_DSMonHoc_Bac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_DSMonHoc_Bac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DSMonHoc_Bac.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_DSMonHoc_Bac.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgv_DSMonHoc_Bac.Location = new System.Drawing.Point(6, 94);
            this.dgv_DSMonHoc_Bac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_DSMonHoc_Bac.Name = "dgv_DSMonHoc_Bac";
            this.dgv_DSMonHoc_Bac.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSMonHoc_Bac.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_DSMonHoc_Bac.RowHeadersVisible = false;
            this.dgv_DSMonHoc_Bac.RowHeadersWidth = 62;
            this.dgv_DSMonHoc_Bac.RowTemplate.Height = 28;
            this.dgv_DSMonHoc_Bac.Size = new System.Drawing.Size(929, 507);
            this.dgv_DSMonHoc_Bac.TabIndex = 10;
            this.dgv_DSMonHoc_Bac.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dgv_DSMonHoc_Bac.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgv_DSMonHoc_Bac.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_DSMonHoc_Bac.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_DSMonHoc_Bac.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_DSMonHoc_Bac.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_DSMonHoc_Bac.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DSMonHoc_Bac.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgv_DSMonHoc_Bac.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgv_DSMonHoc_Bac.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DSMonHoc_Bac.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgv_DSMonHoc_Bac.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DSMonHoc_Bac.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_DSMonHoc_Bac.ThemeStyle.HeaderStyle.Height = 22;
            this.dgv_DSMonHoc_Bac.ThemeStyle.ReadOnly = true;
            this.dgv_DSMonHoc_Bac.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgv_DSMonHoc_Bac.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DSMonHoc_Bac.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgv_DSMonHoc_Bac.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_DSMonHoc_Bac.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_DSMonHoc_Bac.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgv_DSMonHoc_Bac.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_DSMonHoc_Bac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSMonHoc_Bac_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaMH";
            this.Column1.HeaderText = "Mã môn học";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenMH";
            this.Column2.HeaderText = "Tên môn học";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoTC";
            this.Column3.HeaderText = "Số tín chỉ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GroupBox1.Controls.Add(this.txt_TimKiem_Bac);
            this.guna2GroupBox1.Controls.Add(this.cbo_SapxepMonHoc_Bac);
            this.guna2GroupBox1.Controls.Add(this.btn_addNew_Bac);
            this.guna2GroupBox1.Controls.Add(this.btn_SuaMH_Bac);
            this.guna2GroupBox1.Controls.Add(this.btn_XoaMH_Bac);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkBlue;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(945, 90);
            this.guna2GroupBox1.TabIndex = 11;
            this.guna2GroupBox1.Text = "Chức năng                                                                        " +
    "                      Tìm kiếm                        Sắp xếp";
            // 
            // txt_TimKiem_Bac
            // 
            this.txt_TimKiem_Bac.BackColor = System.Drawing.Color.Wheat;
            this.txt_TimKiem_Bac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem_Bac.Location = new System.Drawing.Point(506, 49);
            this.txt_TimKiem_Bac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TimKiem_Bac.Name = "txt_TimKiem_Bac";
            this.txt_TimKiem_Bac.Size = new System.Drawing.Size(113, 29);
            this.txt_TimKiem_Bac.TabIndex = 9;
            this.txt_TimKiem_Bac.TextChanged += new System.EventHandler(this.txt_TimKiem_Bac_TextChanged_1);
            // 
            // lb_somonhoc
            // 
            this.lb_somonhoc.AutoSize = true;
            this.lb_somonhoc.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_somonhoc.ForeColor = System.Drawing.Color.Black;
            this.lb_somonhoc.Location = new System.Drawing.Point(3, 617);
            this.lb_somonhoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_somonhoc.Name = "lb_somonhoc";
            this.lb_somonhoc.Size = new System.Drawing.Size(108, 21);
            this.lb_somonhoc.TabIndex = 12;
            this.lb_somonhoc.Text = "Số môn học : ";
            // 
            // frm_QuanLyMonHoc_Bac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 715);
            this.Controls.Add(this.lb_somonhoc);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dgv_DSMonHoc_Bac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(945, 715);
            this.Name = "frm_QuanLyMonHoc_Bac";
            this.Text = "Quản Lý Thông Tin Môn Học";
            this.Load += new System.EventHandler(this.frm_XemThongTinMonHoc_Bac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSMonHoc_Bac)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_addNew_Bac;
		private System.Windows.Forms.Button btn_SuaMH_Bac;
		private System.Windows.Forms.Button btn_XoaMH_Bac;
		private System.Windows.Forms.ComboBox cbo_SapxepMonHoc_Bac;
		private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
		private Guna.UI2.WinForms.Guna2DataGridView dgv_DSMonHoc_Bac;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private System.Windows.Forms.TextBox txt_TimKiem_Bac;
		private System.Windows.Forms.Label lb_somonhoc;
	}
}