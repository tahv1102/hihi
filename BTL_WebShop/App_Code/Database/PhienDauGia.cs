using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Shop

{
    /// <summary>
    /// Summary description for PhienDauGia
    /// </summary>
    public class PhienDauGia
    {
        #region Phương thức xóa Phiên đấu giá
        /// Phương thức xóa Size theo mã phiên đấu giá truyền vào
        /// </summary>
        /// <param name="masp">mã phiên đấu giá cần xóa</param>
        public static void PhienDauGia_Delete(string MaPhienDG)
        {
            OleDbCommand cmd = new OleDbCommand("phiendaugia_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhienDG", MaPhienDG);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới phiên đấu giá vào bảng phiên đấu giá
        /// <summary>
        /// Phương thức thêm mới phiên đấu giá vào bảng phiên đấu giá
        /// </summary>
    
        public static void PhienDauGia_Inser(string ThoiGianBatDau,string ThoigGianKetThuc, string MaSP, string GiaDeXuat, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("phiendaugia_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ThoiGianBatDau", ThoiGianBatDau);
            cmd.Parameters.AddWithValue("@ThoigGianKetThuc", ThoigGianKetThuc);
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            cmd.Parameters.AddWithValue("@GiaDeXuat", GiaDeXuat);

            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một phiên đấu giá
       /// <summary>
        /// Phương thức chỉnh sửa thông tin một phiên đấu giá
       /// </summary>
       

        public static void PhienDauGia_Update(string MaPhienDG, string ThoiGianBatDau, string ThoiGianKetThuc, string MaSP, string GiaDeXuat)
        {
            OleDbCommand cmd = new OleDbCommand("phiendaugia_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhienDG", MaPhienDG);
            cmd.Parameters.AddWithValue("@ThoiGianBatDau", ThoiGianBatDau);
            cmd.Parameters.AddWithValue("@ThoiGianKetThuc", ThoiGianKetThuc);
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            cmd.Parameters.AddWithValue("@GiaDeXuat", GiaDeXuat);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả phiên đấu giá
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả phiên đấu giá
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_PhienDauGia()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_phiendaugia");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin phiên đấu giá theo id phiên đấu giá
        /// <summary>
        /// Phương thức lấy ra thông tin phiên đấu giá theo id phiên đấu giá
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_PhienDauGia_by_id(string MaPhienDG)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_phiendaugia_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhienDG", @MaPhienDG);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
