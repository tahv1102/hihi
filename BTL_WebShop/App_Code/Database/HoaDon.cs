using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Shop
{
    /// <summary>
    /// Summary description for HoaDon
    /// </summary>
    public class HoaDon
    {
        #region Phương thức xóa hóa đơn theo mã hóa đơn truyền vào
        /// <summary>
        /// Phương thức xóa hóa đơn theo mã hóa đơn truyền vào
        /// </summary>
        /// <param name="mahoadon"></param>
        public static void Hoadon_Delete(string mahoadon)
        {
            OleDbCommand cmd = new OleDbCommand("hoadon_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới hóa đơn vào bảng hóa đơn
        /// <summary>
        /// Phương thức thêm mới hóa đơn vào bảng hóa đơn
        /// </summary>
        /// <param name="ngaylap"></param>
        /// <param name="thanhtien"></param>
        /// <param name="manv"></param>
        /// <param name="tennv"></param>
        /// <param name="makh"></param>
        /// <param name="tenkh"></param>
        /// <param name="ret"></param>
        public static void Hoadon_Inser(string ngaylap,string thanhtien,string manv,string tennv,string makh ,string tenkh, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("hoadon_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngaylap", ngaylap);
            cmd.Parameters.AddWithValue("@thanhtien", thanhtien);
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@makh", makh);

            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một hóa đơn
        /// <summary>
        ///  Phương thức chỉnh sửa thông tin một hóa đơn
        /// </summary>
        /// <param name="mahoadon"></param>
        /// <param name="ngaylap"></param>
        /// <param name="thanhtien"></param>
        /// <param name="manv"></param>
        /// <param name="tennv"></param>
        /// <param name="makh"></param>
        /// <param name="tenkh"></param>
        public static void Hoadon_Update(string mahoadon,string ngaylap,string thanhtien,string manv,string tennv,string makh ,string tenkh)
        {
            OleDbCommand cmd = new OleDbCommand("hoadon_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
            cmd.Parameters.AddWithValue("@ngaylap", ngaylap);
            cmd.Parameters.AddWithValue("@thanhtien", thanhtien);
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@makh", makh);

            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả hóa đơn
        /// <summary>
        ///  Phương thức lấy ra danh sách tất cả hóa đơn
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Hoadon()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_hoadon");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
