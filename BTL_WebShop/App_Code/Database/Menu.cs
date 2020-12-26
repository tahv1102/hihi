using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Shop
{
    /// <summary>
    /// Summary description for Menu
    /// </summary>
    public class Menu
    {
        #region Phương thức xóa menu theo mã menu truyền vào
        /// <summary>
        /// Phương thức xóa menu theo mã menu truyền vào
        /// </summary>
        /// <param name="mamenu"></param>
        public static void Menu_Delete(string mamenu)
        {
            OleDbCommand cmd = new OleDbCommand("menu_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mamenu", mamenu);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới menu vào bảng menu
        /// <summary>
        /// Phương thức thêm mới menu vào bảng menu
        /// </summary>
        /// <param name="tenmenu"></param>
        /// <param name="lienket"></param>
        /// <param name="mamenucha"></param>
        /// <param name="thutumenu"></param>
        /// <param name="ret"></param>
        public static void Menu_Inser(string tenmenu,string lienket,string mamenucha,string thutumenu, string ret)        {
            OleDbCommand cmd = new OleDbCommand("menu_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenmenu", tenmenu);
            cmd.Parameters.AddWithValue("@lienket", lienket);
            cmd.Parameters.AddWithValue("@mamenucha", mamenucha);
            cmd.Parameters.AddWithValue("@thutumenu", thutumenu);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một menu
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một menu
        /// </summary>
        /// <param name="mamenu"></param>
        /// <param name="tenmenu"></param>
        /// <param name="lienket"></param>
        /// <param name="mamenucha"></param>
        /// <param name="thutumenu"></param>
        public static void Menu_Update(string mamenu,string tenmenu,string lienket,string mamenucha,string thutumenu)
        {
            OleDbCommand cmd = new OleDbCommand("menu_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mamenu", mamenu);
            cmd.Parameters.AddWithValue("@tenmenu", tenmenu);
            cmd.Parameters.AddWithValue("@lienket", lienket);
            cmd.Parameters.AddWithValue("@mamenucha", mamenucha);
            cmd.Parameters.AddWithValue("@thutumenu", thutumenu);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả menu
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả menu
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Menu()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách thông tin menu theo mã menu
        /// <summary>
        /// Phương thức lấy ra danh sách thông tin menu theo mã menu
        /// </summary>
        /// <param name="MaMenu"></param>
        /// <returns></returns>
        public static DataTable Thongtin_Menu_by_id(string MaMenu)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMenu", MaMenu);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin menu theo mã menu cha
        /// <summary>
        /// Phương thức lấy ra thông tin menu theo mã menu cha
        /// </summary>
        /// <param name="MaMenuCha"></param>
        /// <returns></returns>
        public static DataTable Thongtin_Menu_by_MaMenuCha(string MaMenuCha)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu_by_mamenucha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMenuCha", MaMenuCha);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
