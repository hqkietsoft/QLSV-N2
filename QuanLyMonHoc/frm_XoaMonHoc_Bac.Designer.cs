namespace Nhom2_QuanLySinhVien.QuanLyMonHoc
{
	partial class frm_XoaMonHoc_Bac
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
			this.cbo_MaMH_Bac = new System.Windows.Forms.ComboBox();
			this.cbo_TenMH_Bac = new System.Windows.Forms.ComboBox();
			this.txt_SoTC_Bac = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_Thoat_Bac = new System.Windows.Forms.Button();
			this.btn_Xoa_Bac = new System.Windows.Forms.Button();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.guna2GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbo_MaMH_Bac
			// 
			this.cbo_MaMH_Bac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_MaMH_Bac.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_MaMH_Bac.FormattingEnabled = true;
			this.cbo_MaMH_Bac.Location = new System.Drawing.Point(239, 59);
			this.cbo_MaMH_Bac.Name = "cbo_MaMH_Bac";
			this.cbo_MaMH_Bac.Size = new System.Drawing.Size(310, 44);
			this.cbo_MaMH_Bac.TabIndex = 9;
			this.cbo_MaMH_Bac.SelectedIndexChanged += new System.EventHandler(this.cbo_MaMH_Bac_SelectedIndexChanged);
			// 
			// cbo_TenMH_Bac
			// 
			this.cbo_TenMH_Bac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_TenMH_Bac.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_TenMH_Bac.FormattingEnabled = true;
			this.cbo_TenMH_Bac.Location = new System.Drawing.Point(239, 108);
			this.cbo_TenMH_Bac.Name = "cbo_TenMH_Bac";
			this.cbo_TenMH_Bac.Size = new System.Drawing.Size(310, 44);
			this.cbo_TenMH_Bac.TabIndex = 7;
			this.cbo_TenMH_Bac.SelectedIndexChanged += new System.EventHandler(this.cbo_TenMH_Bac_SelectedIndexChanged);
			// 
			// txt_SoTC_Bac
			// 
			this.txt_SoTC_Bac.Enabled = false;
			this.txt_SoTC_Bac.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_SoTC_Bac.Location = new System.Drawing.Point(239, 163);
			this.txt_SoTC_Bac.Name = "txt_SoTC_Bac";
			this.txt_SoTC_Bac.Size = new System.Drawing.Size(310, 44);
			this.txt_SoTC_Bac.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.YellowGreen;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(36, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 36);
			this.label1.TabIndex = 4;
			this.label1.Text = "Mã môn học : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.YellowGreen;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(72, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(161, 36);
			this.label3.TabIndex = 8;
			this.label3.Text = "Số tín chỉ : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.YellowGreen;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(30, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(203, 36);
			this.label2.TabIndex = 6;
			this.label2.Text = "Tên môn học : ";
			// 
			// btn_Thoat_Bac
			// 
			this.btn_Thoat_Bac.BackColor = System.Drawing.Color.RoyalBlue;
			this.btn_Thoat_Bac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Thoat_Bac.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Thoat_Bac.ForeColor = System.Drawing.Color.White;
			this.btn_Thoat_Bac.Location = new System.Drawing.Point(332, 228);
			this.btn_Thoat_Bac.Name = "btn_Thoat_Bac";
			this.btn_Thoat_Bac.Size = new System.Drawing.Size(149, 63);
			this.btn_Thoat_Bac.TabIndex = 4;
			this.btn_Thoat_Bac.Text = "Hủy bỏ";
			this.btn_Thoat_Bac.UseVisualStyleBackColor = false;
			this.btn_Thoat_Bac.Click += new System.EventHandler(this.btn_Thoat_Bac_Click);
			// 
			// btn_Xoa_Bac
			// 
			this.btn_Xoa_Bac.BackColor = System.Drawing.Color.RoyalBlue;
			this.btn_Xoa_Bac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Xoa_Bac.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Xoa_Bac.ForeColor = System.Drawing.Color.White;
			this.btn_Xoa_Bac.Location = new System.Drawing.Point(162, 228);
			this.btn_Xoa_Bac.Name = "btn_Xoa_Bac";
			this.btn_Xoa_Bac.Size = new System.Drawing.Size(136, 63);
			this.btn_Xoa_Bac.TabIndex = 3;
			this.btn_Xoa_Bac.Text = "Xóa";
			this.btn_Xoa_Bac.UseVisualStyleBackColor = false;
			this.btn_Xoa_Bac.Click += new System.EventHandler(this.btn_Xoa_Bac_Click);
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.Controls.Add(this.cbo_MaMH_Bac);
			this.guna2GroupBox1.Controls.Add(this.cbo_TenMH_Bac);
			this.guna2GroupBox1.Controls.Add(this.btn_Thoat_Bac);
			this.guna2GroupBox1.Controls.Add(this.txt_SoTC_Bac);
			this.guna2GroupBox1.Controls.Add(this.btn_Xoa_Bac);
			this.guna2GroupBox1.Controls.Add(this.label1);
			this.guna2GroupBox1.Controls.Add(this.label2);
			this.guna2GroupBox1.Controls.Add(this.label3);
			this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkBlue;
			this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2GroupBox1.FillColor = System.Drawing.Color.YellowGreen;
			this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new System.Drawing.Size(612, 305);
			this.guna2GroupBox1.TabIndex = 5;
			this.guna2GroupBox1.Text = "XÓA THÔNG TIN MÔN HỌC";
			this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
			// 
			// frm_XoaMonHoc_Bac
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 305);
			this.Controls.Add(this.guna2GroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frm_XoaMonHoc_Bac";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_XoaMonHoc_Bac";
			this.Load += new System.EventHandler(this.frm_XoaMonHoc_Bac_Load);
			this.guna2GroupBox1.ResumeLayout(false);
			this.guna2GroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ComboBox cbo_TenMH_Bac;
		private System.Windows.Forms.TextBox txt_SoTC_Bac;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Thoat_Bac;
		private System.Windows.Forms.Button btn_Xoa_Bac;
		private System.Windows.Forms.ComboBox cbo_MaMH_Bac;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
	}
}