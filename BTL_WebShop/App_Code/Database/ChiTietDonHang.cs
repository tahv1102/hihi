using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Shop
{
    /// <summary>
    /// Summary description for ChiTietDonHang
    /// </summary>
    public class ChiTietDonHang
    {

        #region Phương thức xóa chi tiết đơn hàng theo mã sản phẩm và mã hóa đơn
        /// <summary>
        /// Phương thức xóa chi tiết đơn hàng theo mã sản phẩm và mã hóa đơn
        /// </summary>
        /// <param name="masp"></param>
        /// <param name="mahoadon"></param>
        public static void Chitietdonhang_Delete(string masp,string mahoadon)
        {
            OleDbCommand cmd = new OleDbCommand("chitietdonhang_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới chi tiết đơn hàng vào chi tiết đơn hàng
        /// <summary>
        /// Phương thức thêm mới chi tiết đơn hàng vào chi tiết đơn hàng
        /// </summary>
        /// <param name="masp"></param>
        /// <param name="mahoadon"></param>
        /// <param name="soluong"></param>
        /// <param name="dongia"></param>
        /// <param name="ret"></param>
        public static void Chitietdonhang_Inser(string masp,string mahoadon,string soluong,string dongia, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("chitietdonhang_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
            cmd.Parameters.AddWithValue("@soluong", soluong);
            cmd.Parameters.AddWithValue("@dongia", dongia);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một chi tiết đơn hàng
       /// <summary>
        /// Phương thức chỉnh sửa thông tin một chi tiết đơn hàng
       /// </summary>
       /// <param name="masp"></param>
       /// <param name="mahoadon"></param>
       /// <param name="soluong"></param>
       /// <param name="dongia"></param>
        public static void Chitietdonhang_Update(string masp, string mahoadon, string soluong, string dongia)
        {
            OleDbCommand cmd = new OleDbCommand("chitietdonhang_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
            cmd.Parameters.AddWithValue("@soluong", soluong);
            cmd.Parameters.AddWithValue("@dongia", dongia);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả các chi tiết đơn hàng
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả các chi tiết đơn hàng
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Chitietdonhang()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_chitietdonhang");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
