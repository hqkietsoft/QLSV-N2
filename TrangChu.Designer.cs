using System.Drawing;
using System.Windows.Forms;

namespace Nhom2_QuanLySinhVien
{
    partial class TrangChu
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_show = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnQLND = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.btn_hide = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnBCTK = new Guna.UI2.WinForms.Guna2Button();
            this.btnLH = new Guna.UI2.WinForms.Guna2Button();
            this.btnMH = new Guna.UI2.WinForms.Guna2Button();
            this.btnLHP = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnHSSV = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.btn_show);
            this.guna2Panel1.Controls.Add(this.btnQLND);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Controls.Add(this.guna2Separator2);
            this.guna2Panel1.Controls.Add(this.btn_hide);
            this.guna2Panel1.Controls.Add(this.btnDangXuat);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.btnBCTK);
            this.guna2Panel1.Controls.Add(this.btnLH);
            this.guna2Panel1.Controls.Add(this.btnMH);
            this.guna2Panel1.Controls.Add(this.btnLHP);
            this.guna2Panel1.Controls.Add(this.btnDiem);
            this.guna2Panel1.Controls.Add(this.btnHSSV);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(254, 715);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btn_show
            // 
            this.btn_show.Animated = true;
            this.btn_show.BackColor = System.Drawing.Color.Transparent;
            this.btn_show.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Transition1.SetDecoration(this.btn_show, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_show.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_show.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_show.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_show.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_show.FillColor = System.Drawing.Color.White;
            this.btn_show.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_show.ForeColor = System.Drawing.Color.White;
            this.btn_show.Image = ((System.Drawing.Image)(resources.GetObject("btn_show.Image")));
            this.btn_show.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_show.Location = new System.Drawing.Point(48, 544);
            this.btn_show.Name = "btn_show";
            this.btn_show.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_show.Size = new System.Drawing.Size(46, 40);
            this.btn_show.TabIndex = 10;
            this.btn_show.UseTransparentBackground = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click_1);
            // 
            // btnQLND
            // 
            this.btnQLND.Animated = true;
            this.btnQLND.BackColor = System.Drawing.Color.Transparent;
            this.btnQLND.BorderRadius = 8;
            this.btnQLND.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLND.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnQLND.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLND.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.btnQLND, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnQLND.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLND.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLND.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLND.FillColor = System.Drawing.Color.Transparent;
            this.btnQLND.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLND.ForeColor = System.Drawing.Color.White;
            this.btnQLND.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnQLND.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLND.Location = new System.Drawing.Point(13, 583);
            this.btnQLND.Name = "btnQLND";
            this.btnQLND.Size = new System.Drawing.Size(226, 57);
            this.btnQLND.TabIndex = 11;
            this.btnQLND.Text = "            Quản lý người dùng";
            this.btnQLND.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLND.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(-3, 44);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(86, 86);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 3;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2Separator2
            // 
            this.guna2Transition1.SetDecoration(this.guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator2.Location = new System.Drawing.Point(26, 558);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(16, 10);
            this.guna2Separator2.TabIndex = 5;
            // 
            // btn_hide
            // 
            this.btn_hide.Animated = true;
            this.btn_hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_hide.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Transition1.SetDecoration(this.btn_hide, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_hide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_hide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_hide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_hide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_hide.FillColor = System.Drawing.Color.White;
            this.btn_hide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_hide.ForeColor = System.Drawing.Color.White;
            this.btn_hide.Image = ((System.Drawing.Image)(resources.GetObject("btn_hide.Image")));
            this.btn_hide.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_hide.Location = new System.Drawing.Point(228, 544);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_hide.Size = new System.Drawing.Size(51, 40);
            this.btn_hide.TabIndex = 9;
            this.btn_hide.UseTransparentBackground = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.BorderRadius = 8;
            this.btnDangXuat.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnDangXuat.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.btnDangXuat, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnDangXuat.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(13, 646);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(226, 57);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "            Đăng xuất";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.UseTransparentBackground = true;
            // 
            // guna2Separator1
            // 
            this.guna2Transition1.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.Location = new System.Drawing.Point(28, 558);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(188, 10);
            this.guna2Separator1.TabIndex = 7;
            // 
            // btnBCTK
            // 
            this.btnBCTK.Animated = true;
            this.btnBCTK.BackColor = System.Drawing.Color.Transparent;
            this.btnBCTK.BorderRadius = 8;
            this.btnBCTK.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBCTK.CustomImages.Image = global::QuanLySinhVien_Nhom2.Properties.Resources.pie_chart;
            this.btnBCTK.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBCTK.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.btnBCTK, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBCTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBCTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBCTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBCTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBCTK.FillColor = System.Drawing.Color.Transparent;
            this.btnBCTK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCTK.ForeColor = System.Drawing.Color.White;
            this.btnBCTK.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnBCTK.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCTK.Location = new System.Drawing.Point(13, 472);
            this.btnBCTK.Name = "btnBCTK";
            this.btnBCTK.Size = new System.Drawing.Size(226, 57);
            this.btnBCTK.TabIndex = 6;
            this.btnBCTK.Text = "            Thống kê báo cáo";
            this.btnBCTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBCTK.UseTransparentBackground = true;
            this.btnBCTK.Click += new System.EventHandler(this.btnBCTK_Click);
            // 
            // btnLH
            // 
            this.btnLH.Animated = true;
            this.btnLH.BackColor = System.Drawing.Color.Transparent;
            this.btnLH.BorderRadius = 8;
            this.btnLH.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLH.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnLH.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLH.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.btnLH, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLH.FillColor = System.Drawing.Color.Transparent;
            this.btnLH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLH.ForeColor = System.Drawing.Color.White;
            this.btnLH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnLH.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLH.Location = new System.Drawing.Point(13, 220);
            this.btnLH.Name = "btnLH";
            this.btnLH.Size = new System.Drawing.Size(226, 57);
            this.btnLH.TabIndex = 5;
            this.btnLH.Text = "            Quản Lý lớp học";
            this.btnLH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLH.UseTransparentBackground = true;
            this.btnLH.Click += new System.EventHandler(this.btnLH_Click);
            // 
            // btnMH
            // 
            this.btnMH.Animated = true;
            this.btnMH.BackColor = System.Drawing.Color.Transparent;
            this.btnMH.BorderRadius = 8;
            this.btnMH.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMH.CustomImages.Image = global::QuanLySinhVien_Nhom2.Properties.Resources.books;
            this.btnMH.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMH.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.btnMH, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMH.FillColor = System.Drawing.Color.Transparent;
            this.btnMH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMH.ForeColor = System.Drawing.Color.White;
            this.btnMH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnMH.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMH.Location = new System.Drawing.Point(13, 283);
            this.btnMH.Name = "btnMH";
            this.btnMH.Size = new System.Drawing.Size(226, 57);
            this.btnMH.TabIndex = 4;
            this.btnMH.Text = "            Quản Lý môn học";
            this.btnMH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMH.UseTransparentBackground = true;
            this.btnMH.Click += new System.EventHandler(this.btnMH_Click);
            // 
            // btnLHP
            // 
            this.btnLHP.Animated = true;
            this.btnLHP.BackColor = System.Drawing.Color.Transparent;
            this.btnLHP.BorderRadius = 8;
            this.btnLHP.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLHP.CustomImages.Image = global::QuanLySinhVien_Nhom2.Properties.Resources.training__1_;
            this.btnLHP.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLHP.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.btnLHP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLHP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLHP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLHP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLHP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLHP.FillColor = System.Drawing.Color.Transparent;
            this.btnLHP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLHP.ForeColor = System.Drawing.Color.White;
            this.btnLHP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnLHP.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLHP.Location = new System.Drawing.Point(13, 346);
            this.btnLHP.Name = "btnLHP";
            this.btnLHP.Size = new System.Drawing.Size(226, 57);
            this.btnLHP.TabIndex = 3;
            this.btnLHP.Text = "            Quản Lý lớp học phần";
            this.btnLHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLHP.UseTransparentBackground = true;
            this.btnLHP.Click += new System.EventHandler(this.btnLHP_Click);
            // 
            // btnDiem
            // 
            this.btnDiem.Animated = true;
            this.btnDiem.BackColor = System.Drawing.Color.Transparent;
            this.btnDiem.BorderRadius = 8;
            this.btnDiem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDiem.CustomImages.Image = global::QuanLySinhVien_Nhom2.Properties.Resources.scoreboard;
            this.btnDiem.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDiem.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.btnDiem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiem.FillColor = System.Drawing.Color.Transparent;
            this.btnDiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.ForeColor = System.Drawing.Color.White;
            this.btnDiem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnDiem.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.Location = new System.Drawing.Point(13, 409);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(226, 57);
            this.btnDiem.TabIndex = 2;
            this.btnDiem.Text = "            Quản Lý điểm";
            this.btnDiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDiem.UseTransparentBackground = true;
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // btnHSSV
            // 
            this.btnHSSV.Animated = true;
            this.btnHSSV.BackColor = System.Drawing.Color.Transparent;
            this.btnHSSV.BorderRadius = 8;
            this.btnHSSV.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHSSV.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnHSSV.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHSSV.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.btnHSSV, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnHSSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHSSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHSSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHSSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHSSV.FillColor = System.Drawing.Color.Transparent;
            this.btnHSSV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHSSV.ForeColor = System.Drawing.Color.White;
            this.btnHSSV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnHSSV.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHSSV.Location = new System.Drawing.Point(13, 157);
            this.btnHSSV.Name = "btnHSSV";
            this.btnHSSV.Size = new System.Drawing.Size(226, 57);
            this.btnHSSV.TabIndex = 1;
            this.btnHSSV.Text = "            Quản Lý hồ sơ sinh viên";
            this.btnHSSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHSSV.UseTransparentBackground = true;
            this.btnHSSV.Click += new System.EventHandler(this.btnHSSV_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(47, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(177, 167);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(254, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 715);
            this.panel1.TabIndex = 2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.guna2ControlBox1);
            this.guna2Transition1.SetDecoration(this.panelMain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(255, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(945, 715);
            this.panelMain.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(911, 10);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(24, 25);
            this.guna2ControlBox1.TabIndex = 4;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 715);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnHSSV;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnBCTK;
        private Guna.UI2.WinForms.Guna2Button btnLH;
        private Guna.UI2.WinForms.Guna2Button btnMH;
        private Guna.UI2.WinForms.Guna2Button btnLHP;
        private Guna.UI2.WinForms.Guna2Button btnDiem;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_hide;
        private Guna.UI2.WinForms.Guna2CircleButton btn_show;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnQLND;
    }
}