using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Shop
{
    /// <summary>
    /// Class thực hiện truy vấn liên quan đế bảng TinTuc
    /// </summary>
    public class TinTuc
    {
        #region Phương thức xóa tin tức theo mã tin tức truyền vào
        /// <summary>
        /// Phương thức xóa tin tức theo mã tin tức truyền vào
        /// </summary>
        /// <param name="TinTucID">mã tin tức cần xóa</param>
        public static void TinTuc_Delete(string TinTucID)
        {
            OleDbCommand cmd = new OleDbCommand("tintuc_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TinTucID", TinTucID);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới một tin tức vào bảng tin tức
        /// <summary>
        /// Phương thức thêm mới một tin tức vào bảng tin tức
        /// </summary>
        /// <param name="TieuDe"></param>
        /// <param name="MoTa"></param>
        /// <param name="NgayDang"></param>
        /// <param name="LuotXem"></param>
        /// <param name="ChiTiet"></param>
        /// <param name="ThuTu"></param>
        /// <param name="MaDM"></param>
        public static void TinTuc_Inser(
            string TieuDe, string AnhDaiDien, string MoTa,
            string NgayDang, string LuotXem, string ChiTiet,
            string ThuTu, string MaDM)
        {
            OleDbCommand cmd = new OleDbCommand("tintuc_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TieuDe", TieuDe);
            cmd.Parameters.AddWithValue("@AnhDaiDien", AnhDaiDien);
            cmd.Parameters.AddWithValue("@MoTa", MoTa);
            cmd.Parameters.AddWithValue("@NgayDang", NgayDang);
            cmd.Parameters.AddWithValue("@LuotXem", LuotXem);
            cmd.Parameters.AddWithValue("@ChiTiet", ChiTiet);

            cmd.Parameters.AddWithValue("@ThuTu", ThuTu);
            cmd.Parameters.AddWithValue("@MaDM", MaDM);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        
        #endregion

        #region  Phương thức chỉnh sửa thông tin một tin tức
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một tin tức
        /// </summary>
        /// <param name="TinTucID"></param>
        /// <param name="TieuDe"></param>
        /// <param name="MoTa"></param>
        /// <param name="NgayDang"></param>
        /// <param name="LuotXem"></param>
        /// <param name="ChiTiet"></param>
        /// <param name="ThuTu"></param>
        /// <param name="MaDM"></param>
        public static void TinTuc_Update(string TinTucID, string TieuDe, string AnhDaiDien, string MoTa, string NgayDang, string LuotXem, string ChiTiet, string ThuTu, string MaDM)
        {
            OleDbCommand cmd = new OleDbCommand("tintuc_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TinTucID", TinTucID);
            cmd.Parameters.AddWithValue("@TieuDe", TieuDe);
            cmd.Parameters.AddWithValue("@AnhDaiDien", AnhDaiDien);
            cmd.Parameters.AddWithValue("@MoTa", MoTa);
            cmd.Parameters.AddWithValue("@NgayDang", NgayDang);
            cmd.Parameters.AddWithValue("@LuotXem", LuotXem);
            cmd.Parameters.AddWithValue("@ChiTiet", ChiTiet);

            cmd.Parameters.AddWithValue("@ThuTu", ThuTu);
            cmd.Parameters.AddWithValue("@MaDM", MaDM);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả tin tức
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả tin tức
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_TinTuc()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra một tin tức theo id tin tức
        /// <summary>
        /// Phương thức lấy ra một tin tức theo id tin tức
        /// <para name="TinTucID">Mã của Tin cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Tintuc_by_id(string TinTucID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TinTucID", TinTucID);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy danh sách tin tức theo mã danh mục - chỉ lấy 6 tin đầu
        public static DataTable Thongtin_TinTuc_by_madm(string MaDM)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc_by_madm");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDM", MaDM);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy danh sách tin tức theo mã danh mục - lấy tất cả tin
        public static DataTable Thongtin_TinTuc_by_madm_tatca(string MaDM)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc_by_madm_tatca");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDM", MaDM);
            return SQLDatabase.GetData(cmd);
        }
        #endregion


        #region Thủ tục cập nhật lượt xem tin tức
        public static void CapNhatLuotXemTinTuc(string id)
        {
            OleDbCommand cmd = new OleDbCommand("CapNhatLuotXemTinTuc");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion
    }
}
