using Giao_dien_dang_nhap;
using PhieuTraMuon;
using QuanLyTacGia;

namespace BTL_QuanLyThuVien_Nhom2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new DangNhap());
        }
    }
}
