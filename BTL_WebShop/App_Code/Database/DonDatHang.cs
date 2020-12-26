using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Shop
{
    /// <summary>
    /// Summary description for DonDatHang
    /// </summary>
    public class DonDatHang
    {
        #region Phương thức xóa đơn đặt hàng theo mã đơn đặt hàng truyền vào
        /// <summary>
        /// Phương thức xóa đơn đặt hàng theo mã đơn đặt hàng truyền vào
        /// </summary>
        /// <param name="madondathang"></param>
        public static void Dondathang_Delete(string madondathang)
        {
            OleDbCommand cmd = new OleDbCommand("dondathang_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madondathang", madondathang);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới đơn đặt hàng vào bảng đơn đặt hàng
       /// <summary>
        ///  Phương thức thêm mới đơn đặt hàng vào bảng đơn đặt hàng
       /// </summary>
       /// <param name="ngaytao"></param>
       /// <param name="thanhtienhd"></param>
       /// <param name="tinhtrangdonhang"></param>
       /// <param name="makh"></param>
       /// <param name="tenkh"></param>
       /// <param name="sdtkh"></param>
       /// <param name="emailkh"></param>
       /// <param name="ret"></param>
        public static void Dondathang_Inser(string ngaytao, string thanhtienhd, string tinhtrangdonhang, string makh, string tenkh, string sdtkh, string emailkh, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("dondathang_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@thanhtienhd", thanhtienhd);
            cmd.Parameters.AddWithValue("@tinhtrangdonhang", tinhtrangdonhang);
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);

            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một đơn đặt hàng
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một đơn đặt hàng
        /// </summary>
        /// <param name="madondathang"></param>
        /// <param name="ngaytao"></param>
        /// <param name="thanhtienhd"></param>
        /// <param name="tinhtrangdonhang"></param>
        /// <param name="makh"></param>
        /// <param name="tenkh"></param>
        /// <param name="sdtkh"></param>
        /// <param name="emailkh"></param>
        public static void Dondathang_Update(string madondathang, string ngaytao, string thanhtienhd, string tinhtrangdonhang, string makh, string tenkh, string sdtkh, string emailkh)
        {
            OleDbCommand cmd = new OleDbCommand("dondathang_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madondathang", madondathang);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@thanhtienhd", thanhtienhd);
            cmd.Parameters.AddWithValue("@tinhtrangdonhang", tinhtrangdonhang);
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);

            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả đơn đặt hàng
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả đơn đặt hàng
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Dondathang()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dondathang");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }


        /// <summary>
        /// Lấy ra thông tin đơn đặt hàng theo mã
        /// </summary>
        /// <param name="MaDonDatHang"></param>
        /// <returns></returns>
        public static DataTable Thongtin_Dondathang_by_id(string MaDonDatHang)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dondathang_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDonDatHang", MaDonDatHang);
            return SQLDatabase.GetData(cmd);
        }


        public static DataTable Thongtin_Dondathang_by_maThanhToan(string mathanhtoan)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dondathang_by_mathanhtoan");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mathanhtoan", mathanhtoan);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả đơn đặt hàng từ mới tới cũ
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả đơn đặt hàng từ mới tới cũ
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Dondathang_Desc()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dondathang_desc");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
