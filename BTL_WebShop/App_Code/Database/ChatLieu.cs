using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Shop
{
    /// <summary>
    /// Summary description for ChatLieu
    /// </summary>
    public class ChatLieu
    {
        #region Phương thức xóa Chất liệu
        /// Phương thức xóa Size theo mã chất liệu truyền vào
        /// </summary>
        /// <param name="masp">mã chất liệu cần xóa</param>
        public static void Chatlieu_Delete(string chatlieuid)
        {
            OleDbCommand cmd = new OleDbCommand("chatlieu_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@chatlieuid", chatlieuid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới chất liệu vào bảng chất liệu
        /// <summary>
        /// Phương thức thêm mới chất liệu vào bảng chất liệu
        /// </summary>
        /// <param name="tenchatlieu"></param>
        /// <param name="ret"></param>

        public static void Chatlieu_Inser(string tenchatlieu, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("chatlieu_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenchatlieu", tenchatlieu);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một chất liệu
       /// <summary>
        /// Phương thức chỉnh sửa thông tin một chất liệu
       /// </summary>
       /// <param name="chatlieuid"></param>
       /// <param name="tenchatlieu"></param>

        public static void Chatlieu_Update(string chatlieuid, string tenchatlieu)
        {
            OleDbCommand cmd = new OleDbCommand("chatlieu_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@chatlieuid", chatlieuid);
            cmd.Parameters.AddWithValue("@tenchatlieu", tenchatlieu);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả chất liệu
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả chất liệu
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Chatlieu()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_chatlieu");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin chất liệu theo id chất liệu
        /// <summary>
        /// Phương thức lấy ra thông tin chất liệu theo id chất liệu
        /// <para name="ChatLieuID">Mã của chất liệu cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_ChatLieu_by_id(string ChatLieuID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_chatlieu_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ChatLieuID", ChatLieuID);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
