using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class cms_admin_TaiKhoan_TaiKhoan_ThemMoi : System.Web.UI.UserControl
{
    //private string thaotac = "";
    //private string id = "";//lấy id của danh mục cần chỉnh sửa
    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    if (Request.QueryString["thaotac"] != null)
    //        thaotac = Request.QueryString["thaotac"];
    //    if (Request.QueryString["id"] != null)
    //        id = Request.QueryString["id"];
    //    if (!IsPostBack)
    //    {

    //        LayQuyenDangNhap();

    //        HienThiThongTin(id);
    //    }

    //}

    //private void HienThiThongTin(string id)
    //{
    //    if (thaotac == "ChinhSua")
    //    {
    //        btThemMoi.Text = "Chỉnh Sửa";
    //        cbThemNhieuDanhMuc.Visible = false;
    //        tbTenDangNhap.Enabled = false;

    //        DataTable dt = new DataTable();
    //        dt = emdepvn.DangKy.Thongtin_DangKy_by_id(id);
    //        if (dt.Rows.Count > 0)
    //        {
    //            ddlQuyenDangNhap.SelectedValue = dt.Rows[0]["MaQuyen"].ToString();
    //            tbTenDangNhap.Text = dt.Rows[0]["TenDangNhap"].ToString();
    //            tbEmail.Text = dt.Rows[0]["EmailDK"].ToString(); 
    //            tbDiaChi.Text = dt.Rows[0]["DiaChiDK"].ToString(); 
    //            tbHoTen.Text = dt.Rows[0]["TenDayDu"].ToString();
    //            tbNgaySinh.Text = dt.Rows[0]["NgaySinh"].ToString();
    //            ddlGioiTinh.SelectedValue = dt.Rows[0]["GioiTinhDK"].ToString();

    //            //lưu lại mật khẩu cũ vào trường ẩn để lấy lại khi ko cập nhật mật khẩu mới
    //            hdMatKhauCu.Value = dt.Rows[0]["MatKhau"].ToString();
    //            // bỏ yêu cầu bắt buộc nhập mật khẩu khi cập nhật
    //            RequiredFieldValidator2.Visible = false;
    //        }
    //    }

    //    else
    //    {
    //        btThemMoi.Text = "Thêm Mới";
    //        cbThemNhieuDanhMuc.Visible = true;
    //    }

    //}
    //private void LayQuyenDangNhap()
    //{
    //    DataTable dt = new DataTable();
    //    dt = emdepvn.QuyenDangNhap.Thongtin_Quyendangnhap();
    //    ddlQuyenDangNhap.Items.Clear();
    //    for (int i = 0; i < dt.Rows.Count; i++)
    //    {
    //        ddlQuyenDangNhap.Items.Add(new ListItem(dt.Rows[i]["TenQuyen"].ToString(), dt.Rows[i]["MaQuyen"].ToString()));
            
    //    }
    //}
    //protected void btThemMoi_Click(object sender, EventArgs e)
    //{
    //    if (thaotac == "ThemMoi")
    //    {
    //        #region code nút thêm mới

    //        //Mã hóa mật khẩu trước khi thêm vào database
    //        string matKhau = "";
    //        if(matKhau != null)
    //          matKhau = emdepvn.MaHoa.MaHoaMD5(tbMatKhau.Text);
    //        else
    //            matKhau = emdepvn.MaHoa.MaHoaMD5(hdMatKhauCu.Value);//TRƯỜNG hợp ko nhập mật khẩu thì lấy lại mật khẩu cũ

    //        emdepvn.DangKy.Dangky_Inser(
    //            tbTenDangNhap.Text, matKhau, tbEmail.Text, 
    //            tbDiaChi.Text, tbHoTen.Text, "", tbNgaySinh.Text , 
    //            ddlGioiTinh.SelectedValue, ddlQuyenDangNhap.SelectedValue, "");
    //        ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã tạo tài khoản: " + tbTenDangNhap.Text + "</div>";

    //        if (cbThemNhieuDanhMuc.Checked)
    //        {
    //            //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
    //            ResetControl();
    //        }

    //        else
    //        {
    //            //đẩy trang về trang danh sách các damnh mục đã tạo

    //            Response.Redirect("Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan");
    //        }
    //        #endregion
    //    }
    //    else
    //    {
    //        #region code nút chỉnh sửa

    //        //Mã hóa mật khẩu trước khi thêm vào database
    //        string matKhau = emdepvn.MaHoa.MaHoaMD5(tbMatKhau.Text);

    //        emdepvn.DangKy.Dangky_Update(
    //            id, matKhau, tbEmail.Text,
    //            tbDiaChi.Text, tbHoTen.Text, "", tbNgaySinh.Text,
    //            ddlGioiTinh.SelectedValue, ddlQuyenDangNhap.SelectedValue);

    //        //đẩy trang về trang danh sách các damnh mục đã tạo
    //        Response.Redirect("Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan");

    //        #endregion
    //    }
    //}

    //private void ResetControl()
    //{
    //    tbTenDangNhap.Text = "";
    //    tbMatKhau.Text = "";
    //    tbEmail.Text = "";
    //    tbDiaChi.Text="";
    //    tbHoTen.Text="";
    //    tbNgaySinh.Text = "";


    //}
    //protected void btHuy_Click(object sender, EventArgs e)
    //{
    //    ResetControl();
    //}
}