using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Shop

{
    /// <summary>
    /// Summary description for Mau
    /// </summary>
    public class Mau
    {
        #region Phương thức xóa Mau
        /// <summary>
        /// Phương thức xóa Mau
        /// </summary>
        /// <param name="mauid"></param>
        public static void Mau_Delete(string mauid)
        {
            OleDbCommand cmd = new OleDbCommand("mau_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mauid", mauid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Màu vào bảng Màu
        /// <summary>
        /// Phương thức thêm mới Màu vào bảng Màu
        /// </summary>
        /// <param name="tenmau"></param>
        /// <param name="ret"></param>

        public static void Mau_Inser(string tenmau, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("mau_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenmau", tenmau);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một Màu
        /// <summary>
        ///  Phương thức chỉnh sửa thông tin một Màu
        /// </summary>
        /// <param name="mauid"></param>
        /// <param name="tenmau"></param>

        public static void Mau_Update(string mauid, string tenmau)
        {
            OleDbCommand cmd = new OleDbCommand("mau_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mauid", mauid);
            cmd.Parameters.AddWithValue("@tenmau", tenmau);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả Màu
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Màu
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Mau()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_mau");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin màu theo id màu
        /// <summary>
        /// Phương thức lấy ra thông tin màu theo id màu
        /// <para name="MauID">Mã của màu cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Mau_by_id(string MauID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_mau_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MauID", MauID);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
