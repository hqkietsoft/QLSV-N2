namespace Nhom2_QuanLySinhVien.QuanLyNguoiDung
{
	partial class frm_ThongTinNguoiDung_Bac
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_TenDN_Bac = new System.Windows.Forms.TextBox();
			this.txt_MatKhau_Bac = new System.Windows.Forms.TextBox();
			this.txt_LoaiND_Bac = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 65);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên đăng nhập";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1, 224);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(199, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "Loại người dùng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(79, 139);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 33);
			this.label4.TabIndex = 3;
			this.label4.Text = "Mật khẩu";
			// 
			// txt_TenDN_Bac
			// 
			this.txt_TenDN_Bac.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TenDN_Bac.Location = new System.Drawing.Point(212, 62);
			this.txt_TenDN_Bac.Name = "txt_TenDN_Bac";
			this.txt_TenDN_Bac.Size = new System.Drawing.Size(279, 44);
			this.txt_TenDN_Bac.TabIndex = 4;
			// 
			// txt_MatKhau_Bac
			// 
			this.txt_MatKhau_Bac.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_MatKhau_Bac.Location = new System.Drawing.Point(212, 139);
			this.txt_MatKhau_Bac.Name = "txt_MatKhau_Bac";
			this.txt_MatKhau_Bac.Size = new System.Drawing.Size(279, 44);
			this.txt_MatKhau_Bac.TabIndex = 6;
			this.txt_MatKhau_Bac.UseSystemPasswordChar = true;
			// 
			// txt_LoaiND_Bac
			// 
			this.txt_LoaiND_Bac.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_LoaiND_Bac.Location = new System.Drawing.Point(212, 223);
			this.txt_LoaiND_Bac.Name = "txt_LoaiND_Bac";
			this.txt_LoaiND_Bac.Size = new System.Drawing.Size(279, 44);
			this.txt_LoaiND_Bac.TabIndex = 7;
			// 
			// frm_ThongTinNguoiDung_Bac
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 370);
			this.Controls.Add(this.txt_LoaiND_Bac);
			this.Controls.Add(this.txt_MatKhau_Bac);
			this.Controls.Add(this.txt_TenDN_Bac);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximumSize = new System.Drawing.Size(539, 426);
			this.Name = "frm_ThongTinNguoiDung_Bac";
			this.Text = "THÔNG TIN NGƯỜI DÙNG";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_TenDN_Bac;
		private System.Windows.Forms.TextBox txt_MatKhau_Bac;
		private System.Windows.Forms.TextBox txt_LoaiND_Bac;
	}
}