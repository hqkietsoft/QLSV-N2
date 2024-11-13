using System.Drawing;
using System.Windows.Forms;

namespace Nhom2_QuanLySinhVien
{
    partial class BaoCaoThongKe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXuatDanhSachSV = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatBaiDiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatBaoCaoSV = new Guna.UI2.WinForms.Guna2Button();
            this.cbbLopHoc1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbLopHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbMaSV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2vSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbbMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2vSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2vSeparator3 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXuatDanhSachSV
            // 
            this.btnXuatDanhSachSV.BorderRadius = 20;
            this.btnXuatDanhSachSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatDanhSachSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatDanhSachSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatDanhSachSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatDanhSachSV.FillColor = System.Drawing.Color.Black;
            this.btnXuatDanhSachSV.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatDanhSachSV.ForeColor = System.Drawing.Color.White;
            this.btnXuatDanhSachSV.Location = new System.Drawing.Point(39, 78);
            this.btnXuatDanhSachSV.Name = "btnXuatDanhSachSV";
            this.btnXuatDanhSachSV.Size = new System.Drawing.Size(437, 49);
            this.btnXuatDanhSachSV.TabIndex = 0;
            this.btnXuatDanhSachSV.Text = "Danh sách sinh viên của một lớp";
            this.btnXuatDanhSachSV.Click += new System.EventHandler(this.btnXuatDanhSachSV_Click);
            // 
            // btnXuatBaiDiem
            // 
            this.btnXuatBaiDiem.BorderRadius = 20;
            this.btnXuatBaiDiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatBaiDiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatBaiDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatBaiDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatBaiDiem.FillColor = System.Drawing.Color.Black;
            this.btnXuatBaiDiem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBaiDiem.ForeColor = System.Drawing.Color.White;
            this.btnXuatBaiDiem.Location = new System.Drawing.Point(39, 76);
            this.btnXuatBaiDiem.Name = "btnXuatBaiDiem";
            this.btnXuatBaiDiem.Size = new System.Drawing.Size(437, 49);
            this.btnXuatBaiDiem.TabIndex = 1;
            this.btnXuatBaiDiem.Text = "Danh sách điểm của một lớp của một môn học";
            this.btnXuatBaiDiem.Click += new System.EventHandler(this.btnXuatBaiDiem_Click);
            // 
            // btnXuatBaoCaoSV
            // 
            this.btnXuatBaoCaoSV.BorderRadius = 20;
            this.btnXuatBaoCaoSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatBaoCaoSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatBaoCaoSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatBaoCaoSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatBaoCaoSV.FillColor = System.Drawing.Color.Black;
            this.btnXuatBaoCaoSV.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBaoCaoSV.ForeColor = System.Drawing.Color.White;
            this.btnXuatBaoCaoSV.Location = new System.Drawing.Point(39, 75);
            this.btnXuatBaoCaoSV.Name = "btnXuatBaoCaoSV";
            this.btnXuatBaoCaoSV.Size = new System.Drawing.Size(437, 49);
            this.btnXuatBaoCaoSV.TabIndex = 2;
            this.btnXuatBaoCaoSV.Text = "Thông tin bảng điểm của một sinh viên";
            this.btnXuatBaoCaoSV.Click += new System.EventHandler(this.btnXuatBaoCaoSV_Click);
            // 
            // cbbLopHoc1
            // 
            this.cbbLopHoc1.BackColor = System.Drawing.Color.Transparent;
            this.cbbLopHoc1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLopHoc1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLopHoc1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLopHoc1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLopHoc1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbLopHoc1.ForeColor = System.Drawing.Color.Black;
            this.cbbLopHoc1.ItemHeight = 30;
            this.cbbLopHoc1.Location = new System.Drawing.Point(652, 90);
            this.cbbLopHoc1.Name = "cbbLopHoc1";
            this.cbbLopHoc1.Size = new System.Drawing.Size(184, 36);
            this.cbbLopHoc1.TabIndex = 3;
            // 
            // cbbLopHoc
            // 
            this.cbbLopHoc.BackColor = System.Drawing.Color.Transparent;
            this.cbbLopHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLopHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLopHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLopHoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbLopHoc.ForeColor = System.Drawing.Color.Black;
            this.cbbLopHoc.ItemHeight = 30;
            this.cbbLopHoc.Location = new System.Drawing.Point(652, 56);
            this.cbbLopHoc.Name = "cbbLopHoc";
            this.cbbLopHoc.Size = new System.Drawing.Size(184, 36);
            this.cbbLopHoc.TabIndex = 4;
            // 
            // cbbMaSV
            // 
            this.cbbMaSV.BackColor = System.Drawing.Color.Transparent;
            this.cbbMaSV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaSV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbMaSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbMaSV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbMaSV.ForeColor = System.Drawing.Color.Black;
            this.cbbMaSV.ItemHeight = 30;
            this.cbbMaSV.Location = new System.Drawing.Point(652, 86);
            this.cbbMaSV.Name = "cbbMaSV";
            this.cbbMaSV.Size = new System.Drawing.Size(184, 36);
            this.cbbMaSV.TabIndex = 6;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 8;
            this.guna2GroupBox1.Controls.Add(this.guna2vSeparator2);
            this.guna2GroupBox1.Controls.Add(this.btnXuatDanhSachSV);
            this.guna2GroupBox1.Controls.Add(this.cbbLopHoc1);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(41, 106);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(861, 172);
            this.guna2GroupBox1.TabIndex = 7;
            this.guna2GroupBox1.Text = "XUẤT DANH SÁCH SINH VIÊN CỦA MỘT LỚP";
            // 
            // guna2vSeparator2
            // 
            this.guna2vSeparator2.Location = new System.Drawing.Point(518, 62);
            this.guna2vSeparator2.Name = "guna2vSeparator2";
            this.guna2vSeparator2.Size = new System.Drawing.Size(9, 89);
            this.guna2vSeparator2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(554, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lớp học";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(554, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(554, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lớp học";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 10);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 10);
            this.panel1.TabIndex = 10;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(945, 70);
            this.guna2Panel1.TabIndex = 9;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(918, 5);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(24, 25);
            this.guna2ControlBox2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 45);
            this.label5.TabIndex = 3;
            this.label5.Text = "THỐNG KÊ";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1557, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(24, 25);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "BÁO CÁO";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderRadius = 8;
            this.guna2GroupBox3.Controls.Add(this.cbbMonHoc);
            this.guna2GroupBox3.Controls.Add(this.label4);
            this.guna2GroupBox3.Controls.Add(this.guna2vSeparator1);
            this.guna2GroupBox3.Controls.Add(this.btnXuatBaiDiem);
            this.guna2GroupBox3.Controls.Add(this.label2);
            this.guna2GroupBox3.Controls.Add(this.cbbLopHoc);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(41, 290);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(861, 172);
            this.guna2GroupBox3.TabIndex = 8;
            this.guna2GroupBox3.Text = "XUẤT DANH SÁCH ĐIỂM CỦA MỘT LỚP CỦA MỘT MÔN HỌC";
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.cbbMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbMonHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbMonHoc.ForeColor = System.Drawing.Color.Black;
            this.cbbMonHoc.ItemHeight = 30;
            this.cbbMonHoc.Location = new System.Drawing.Point(652, 116);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(184, 36);
            this.cbbMonHoc.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(554, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Môn học";
            // 
            // guna2vSeparator1
            // 
            this.guna2vSeparator1.Location = new System.Drawing.Point(518, 62);
            this.guna2vSeparator1.Name = "guna2vSeparator1";
            this.guna2vSeparator1.Size = new System.Drawing.Size(9, 89);
            this.guna2vSeparator1.TabIndex = 9;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BorderRadius = 8;
            this.guna2GroupBox4.Controls.Add(this.guna2vSeparator3);
            this.guna2GroupBox4.Controls.Add(this.label3);
            this.guna2GroupBox4.Controls.Add(this.btnXuatBaoCaoSV);
            this.guna2GroupBox4.Controls.Add(this.cbbMaSV);
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox4.Location = new System.Drawing.Point(41, 474);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(861, 172);
            this.guna2GroupBox4.TabIndex = 8;
            this.guna2GroupBox4.Text = "XUẤT THÔNG TIN BẢNG ĐIỂM CỦA MỘT SINH VIÊN KHI BIẾT MÃ SINH VIÊN";
            // 
            // guna2vSeparator3
            // 
            this.guna2vSeparator3.Location = new System.Drawing.Point(518, 56);
            this.guna2vSeparator3.Name = "guna2vSeparator3";
            this.guna2vSeparator3.Size = new System.Drawing.Size(9, 89);
            this.guna2vSeparator3.TabIndex = 11;
            // 
            // BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2GroupBox4);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "BaoCaoThongKe";
            this.Size = new System.Drawing.Size(945, 715);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnXuatDanhSachSV;
        private Guna.UI2.WinForms.Guna2Button btnXuatBaiDiem;
        private Guna.UI2.WinForms.Guna2Button btnXuatBaoCaoSV;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLopHoc1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLopHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cbbMaSV;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Label label7;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator3;
        private Guna.UI2.WinForms.Guna2ComboBox cbbMonHoc;
        private Label label4;
    }
}
