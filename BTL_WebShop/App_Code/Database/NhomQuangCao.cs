using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Shop
{
    /// <summary>
    /// Summary description for NhomQuangCao
    /// </summary>
    public class NhomQuangCao
    {
        #region Phương thức xóa Nhomquangcao theo mã Nhomquangcao truyền vào
        /// <summary>
        /// Phương thức xóa Nhomquangcao theo mã Nhomquangcao truyền vào
        /// </summary>
        /// <param name="nhomquangcaoid"></param>
        public static void Nhomquangcao_Delete(string nhomquangcaoid)
        {
            OleDbCommand cmd = new OleDbCommand("nhomquangcao_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nhomquangcaoid", nhomquangcaoid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Nhomquangcao vào Nhomquangcao
        /// <summary>
        /// Phương thức thêm mới Nhomquangcao vào Nhomquangcao
        /// </summary>
        /// <param name="tennhomqc"></param>
        /// <param name="vitriqc"></param>
        /// <param name="thutunhomqc"></param>
        /// <param name="anhdaidienqc"></param>
        /// <param name="ret"></param>
        public static void Nhomquangcao_Inser(string tennhomqc,string vitriqc,string thutunhomqc,string anhdaidienqc, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("nhomquangcao_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tennhomqc", tennhomqc);
            cmd.Parameters.AddWithValue("@vitriqc", vitriqc);
            cmd.Parameters.AddWithValue("@thutunhomqc", thutunhomqc);
            cmd.Parameters.AddWithValue("@anhdaidienqc", anhdaidienqc);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một Nhomquangcao
        /// <summary>
        ///  Phương thức chỉnh sửa thông tin một Nhomquangcao
        /// </summary>
        /// <param name="nhomquangcaoid"></param>
        /// <param name="tennhomquangcao"></param>
        /// <param name="vitriqc"></param>
        /// <param name="thutunhomqc"></param>
        /// <param name="anhdaidienqc"></param>
        public static void Nhomquangcao_Update(string nhomquangcaoid,string tennhomquangcao,string vitriqc,string thutunhomqc,string anhdaidienqc)
        {
            OleDbCommand cmd = new OleDbCommand("nhomquangcao_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nhomquangcaoid", nhomquangcaoid);
            cmd.Parameters.AddWithValue("@tennhomquangcao", tennhomquangcao);
            cmd.Parameters.AddWithValue("@vitriqc", vitriqc);
            cmd.Parameters.AddWithValue("@thutunhomqc", thutunhomqc);
            cmd.Parameters.AddWithValue("@anhdaidienqc", anhdaidienqc);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả NhomQuangCao
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả NhomQuangCao
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Nhomquangcao()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_nhomquangcao");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin nhóm quảng cáo theo id nhóm quảng cáo
        /// <summary>
        /// Phương thức lấy ra thông tin nhóm quảng cáo theo id nhóm quảng cáo
        /// <para name="NhomQuangCaoID">Mã của nhóm quảng cáo cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Nhomquangcao_by_id(string NhomQuangCaoID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_nhomquangcao_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NhomQuangCaoID", NhomQuangCaoID);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra nhóm quảng cáo theo vị trí
        public static DataTable Thongtin_Nhomquangcao_by_vitriqc(string ViTriQC)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_nhomquangcao_by_vitriqc");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ViTriQC", ViTriQC);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
