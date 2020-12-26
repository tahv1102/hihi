using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Shop 
{
    public class SanPham
    {
        //xóa sản phẩm
        public static void Sanpham_Delete(string masp)
        {
            OleDbCommand cmd = new OleDbCommand("sanpham_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //Thêm mới sản phẩm
        public static void Sanpham_Inser(string tensp, string mauID, string sizeID, string chatieuID, string anhsanpham, string soluongsp, string giasp, string motasp, string ngaytao, string ngayhuy, string maDM, string nhomID, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("sanpham_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@mauID", mauID);
            cmd.Parameters.AddWithValue("@sizeID", sizeID);
            cmd.Parameters.AddWithValue("@chatieuID", chatieuID);
            cmd.Parameters.AddWithValue("@anhsanpham", anhsanpham);

            cmd.Parameters.AddWithValue("@soluongsp", soluongsp);
            cmd.Parameters.AddWithValue("@giasp", giasp);
            cmd.Parameters.AddWithValue("@motasp", motasp);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@ngayhuy", ngayhuy);

            cmd.Parameters.AddWithValue("@maDM", maDM);
            cmd.Parameters.AddWithValue("@nhomID", nhomID);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
       
        // Phương thức chỉnh sửa thông tin một sản phẩm
        
        public static void Sanpham_Update(string masp, string tensp, string mauid, string sizeid, string chatieuid, string anhsp, string soluongsp, string giasp, string motasp, string ngaytao, string ngayhuy, string madm, string nhomid)
        {
            OleDbCommand cmd = new OleDbCommand("sanpham_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@mauid", mauid);
            cmd.Parameters.AddWithValue("@sizeid", sizeid);
            cmd.Parameters.AddWithValue("@chatieuid", chatieuid);
            cmd.Parameters.AddWithValue("@anhsp", anhsp);

            cmd.Parameters.AddWithValue("@soluongsp", soluongsp);
            cmd.Parameters.AddWithValue("@giasp", giasp);
            cmd.Parameters.AddWithValue("@motasp", motasp);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@ngayhuy", ngayhuy);

            cmd.Parameters.AddWithValue("@madm", madm);
            cmd.Parameters.AddWithValue("@nhomid", nhomid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


 
        // Phương thức lấy ra danh sách tất cả sản phẩm
 
        public static DataTable Thongtin_Sanpham()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
   
        // Phương thức lấy ra thông tin size theo id size
  
        public static DataTable Thongtin_Sanpham_by_id(string MaSP)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            return SQLDatabase.GetData(cmd);
        }
       


        // Lấy danh sách sản phẩm theo nhóm id
        public static DataTable Thongtin_Sanpham_by_nhomid(string NhomID, string SoSPHienThi)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_nhomid");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NhomID", NhomID);
            cmd.Parameters.AddWithValue("@SoSPHienThi", SoSPHienThi);
            return SQLDatabase.GetData(cmd);
        }
 
      //Lấy danh sách sản phẩm theo mã danh mục - chỉ 3 sản phẩm đầu
        public static DataTable Thongtin_Sanpham_by_madm(string MaDM)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_madm");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDM", MaDM);
            return SQLDatabase.GetData(cmd);
        }

        public static DataTable Thongtin_Sanpham_by_madm_tatca(string MaDM)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_madm_tatca");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDM", MaDM);
            return SQLDatabase.GetData(cmd);
        }
 


      //Lấy danh sách sản phẩm theo từ khóa tìm kiếm: sẽ tìm theo tên hoặc mã sản phẩm
        public static DataTable Thongtin_Sanpham_by_tukhoa(string tukhoa)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_tukhoa");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TuKhoa", tukhoa);
            return SQLDatabase.GetData(cmd);
        }
    

    }
}
 