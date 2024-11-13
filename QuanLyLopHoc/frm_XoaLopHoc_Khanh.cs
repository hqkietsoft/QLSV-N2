using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2_QuanLySinhVien
{
    public partial class frm_XoaLopHoc_Khanh : Form
    {
        public frm_XoaLopHoc_Khanh()
        {
            InitializeComponent();
             
        }
        private void frm_Xoa_Khanh_Load(object sender, EventArgs e)
        {
            LoadMaLop();
        }
        #region Cập nhật mã lớp lên combobox
        private void LoadMaLop()
        {
            try
            {
                cb_MaLop_Khanh.DataSource = TruyVan.LayDanhSachMaLop(); // Cập nhật danh sách mã lớp
                cb_MaLop_Khanh.DisplayMember = "MaLop";
                cb_MaLop_Khanh.ValueMember = "MaLop";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách mã lớp: " + ex.Message, "Lỗi");
            }
        }

        #endregion

        #region Nút tìm theo mã lớp
        private void btn_Tim_Khanh_Click(object sender, EventArgs e)
        {
            string maLop = cb_MaLop_Khanh.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng chọn mã lớp!", "Thông báo");
                return;
            }

            try
            {
                DataTable dt = TruyVan.LayThongTinLop(maLop);
                if (dt.Rows.Count > 0)
                {
                    tb_TenLop_Khanh.Text = dt.Rows[0]["TenLop"].ToString();
                    tb_KhoaHoc_Khanh.Text = dt.Rows[0]["KhoaHoc"].ToString();
                    tb_HeDaoTao_Khanh.Text = dt.Rows[0]["HeDaoTao"].ToString();
                    tb_NamNhapHoc_Khanh.Text = dt.Rows[0]["NamNhapHoc"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin lớp học!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin lớp học: " + ex.Message, "Lỗi");
            }
        }
        #endregion


        #region Nút Xoá lớp
        private void btn_Xoa_Khanh_Click(object sender, EventArgs e)
        {
            string maLop = cb_MaLop_Khanh.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng chọn mã lớp để xóa!", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int kq = TruyVan.XoaLop(maLop);
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa lớp học thành công!", "Thông báo");
                        LoadMaLop(); 
                        ClearTextBoxes();
                        frm_QuanLyLopHoc_Khanh QuanLyLopHoc = new frm_QuanLyLopHoc_Khanh();
                        QuanLyLopHoc.HienThi(); 
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được lớp học.", "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa lớp học: " + ex.Message, "Lỗi");
                }
            }
        }

        #endregion

        #region Xoá các textbox
        private void ClearTextBoxes()
        {
            tb_TenLop_Khanh.Text = "";
            tb_KhoaHoc_Khanh.Text = "";
            tb_HeDaoTao_Khanh.Text = "";
            tb_NamNhapHoc_Khanh.Text = "";
        }

        #endregion

        #region Nút Huỷ
        private void btn_Huy_Khanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
