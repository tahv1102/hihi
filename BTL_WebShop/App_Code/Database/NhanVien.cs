using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Shop

{
    /// <summary>
    /// Summary description for NhanVien
    /// </summary>
    public class NhanVien
    {
        #region Phương thức xóa nhân viên theo mã nhân viên truyền vào
        /// <summary>
        /// Phương thức xóa nhân viên theo mã nhân viên truyền vào
        /// </summary>
        /// <param name="manv"></param>
        public static void Nhanvien_Delete(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("nhanvien_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", manv);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Nhanvien vào bảng Nhanvien
        /// <summary>
        /// Phương thức thêm mới Nhanvien vào bảng Nhanvien
        /// </summary>
        /// <param name="tennv"></param>
        /// <param name="gioitinhnv"></param>
        /// <param name="diachinv"></param>
        /// <param name="sdtnv"></param>
        /// <param name="ngayvaolam"></param>
        /// <param name="ret"></param>
        public static void Nhanvien_Inser(string tennv,string gioitinhnv,string diachinv,string sdtnv,string ngayvaolam, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("nhanvien_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@gioitinhnv", gioitinhnv);
            cmd.Parameters.AddWithValue("@diachinv", diachinv);
            cmd.Parameters.AddWithValue("@sdtnv", sdtnv);
            cmd.Parameters.AddWithValue("@ngayvaolam", ngayvaolam);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một Nhanvien
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một Nhanvien
        /// </summary>
        /// <param name="manv"></param>
        /// <param name="tennv"></param>
        /// <param name="gioitinhnv"></param>
        /// <param name="diachinv"></param>
        /// <param name="sdtnv"></param>
        /// <param name="ngayvaolam"></param>
        public static void Nhanvien_Update(string manv,string tennv,string gioitinhnv,string diachinv,string sdtnv,string ngayvaolam )
        {
            OleDbCommand cmd = new OleDbCommand("nhanvien_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@gioitinhnv", gioitinhnv);
            cmd.Parameters.AddWithValue("@diachinv", diachinv);
            cmd.Parameters.AddWithValue("@ssdtnv", sdtnv);
            cmd.Parameters.AddWithValue("@ngayvaolam", ngayvaolam);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả Nhân viên
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Nhân viên
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Nhanvien()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_nhanvien");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
