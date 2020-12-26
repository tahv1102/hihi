using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;


namespace Shop
{
    /// <summary>
    /// Summary description for QuangCao
    /// </summary>
    public class QuangCao
    {
        #region Phương thức xóa Quangcao theo mã Quangcao truyền vào
        /// <summary>
        /// Phương thức xóa Quangcao theo mã Quangcao truyền vào
        /// </summary>
        /// <param name="quangcaoid">mã quangcao cần xóa</param>
        public static void Quangcao_Delete(string quangcaoid)
        {
            OleDbCommand cmd = new OleDbCommand("quangcao_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@quangcaoid", quangcaoid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Quangcao vào bảng Quangcao
        /// <summary>
        /// Phương thức thêm mới Quangcao vào bảng Quangcao
        /// </summary>
        /// <param name="tenqc"></param>
        /// <param name="loaiqc"></param>
        /// <param name="anhqc"></param>
        /// <param name="lienket"></param>
        /// <param name="thutuqc"></param>
        /// <param name="nhomqcID"></param>
        /// <param name="ret"></param>
        public static void Quangcao_Inser(string tenqc, string loaiqc, string anhqc, 
            string lienket, string thutuqc, string nhomqcID, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("quangcao_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenqc", tenqc);
            cmd.Parameters.AddWithValue("@loaiqc", loaiqc);
            cmd.Parameters.AddWithValue("@anhqc", anhqc);
            cmd.Parameters.AddWithValue("@lienket", lienket);
            cmd.Parameters.AddWithValue("@thutuqc", thutuqc);

            cmd.Parameters.AddWithValue("@nhomqcID", nhomqcID);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một Quảng Cáo
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một Quảng Cáo
        /// </summary>
        /// <param name="quangcaoid"></param>
        /// <param name="tenquangcao"></param>
        /// <param name="loaiqc"></param>
        /// <param name="anhqc"></param>
        /// <param name="lienket"></param>
        /// <param name="thutuqc"></param>
        /// <param name="nhomquangcaoid"></param>
      
        public static void Quangcao_Update(string quangcaoid,string tenquangcao,string loaiqc,string anhqc,string lienket,string thutuqc,string nhomquangcaoid)
        {
            OleDbCommand cmd = new OleDbCommand("quangcao_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@quangcaoid", quangcaoid);
            cmd.Parameters.AddWithValue("@tenquangcao", tenquangcao);
            cmd.Parameters.AddWithValue("@loaiqc", loaiqc);
            cmd.Parameters.AddWithValue("@anhqc", anhqc);
            cmd.Parameters.AddWithValue("@lienket", lienket);
            cmd.Parameters.AddWithValue("@thutuqc", thutuqc);

            cmd.Parameters.AddWithValue("@nhomquangcaoid", nhomquangcaoid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả Quangcao
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Quangcao
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Quangcao()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_quangcao");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin quảng cáo theo id quảng cáo
        /// <summary>
        /// Phương thức lấy ra thông tin quảng cáo theo id quảng cáo
        /// <para name="QuangCaoID">Mã quảng cáo cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Quangcao_by_id(string QuangCaoID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_quangcao_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@QuangCaoID", QuangCaoID);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra quảng cáo theo id của nhóm quảng cáo
        public static DataTable Thongtin_Quangcao_by_nhomquangcaoid(string NhomQuangCaoID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_quangcao_by_nhomquangcaoid");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NhomQuangCaoID", NhomQuangCaoID);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
