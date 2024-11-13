using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom2_QuanLySinhVien.QuanLyMonHoc;
using QuanLySinhVien_Nhom2.QuanLyDiem;

namespace Nhom2_QuanLySinhVien
{
	internal static class Program
	{
		public static int loaiND = 0;
		
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new TrangChu());
		}
	}
}
