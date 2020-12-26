using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;


public partial class cms_admin_QuangCao_QuanLyDanhSachQuangCao_DanhSachQuangCao_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = "";//lấy id của tin tức cần chỉnh sửa
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (!IsPostBack)
        {

            LayNhom();

            HienThiThongTin(id);
        }
            
    }

    private void HienThiThongTin(string id)
    {
        if(thaotac=="ChinhSua")
        {
            btThemMoi.Text = "Chỉnh Sửa";
            cbThemNhieuDanhMuc.Visible = false;

            DataTable dt = new DataTable();
            dt = Shop.QuangCao.Thongtin_Quangcao_by_id(id);
            if (dt.Rows.Count > 0)
            {
                ddlDanhMucCha.SelectedValue = dt.Rows[0]["NhomQuangCaoID"].ToString();
                tbTen.Text = dt.Rows[0]["TenQC"].ToString();
                tbLienKet.Text = dt.Rows[0]["LienKet"].ToString();
                tbThuTu.Text = dt.Rows[0]["ThuTuQC"].ToString();
                ltrAnhDaiDien.Text = "<img class='anhDaiDien'src='/pic/QuangCao/" + dt.Rows[0]["AnhQC"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhQC"].ToString();
            }
        }

        else
        {
            btThemMoi.Text = "Thêm Mới";
            cbThemNhieuDanhMuc.Visible = true;
        }

    }

    private void LayNhom()
    {
        DataTable dt = new DataTable();
        dt = Shop.NhomQuangCao.Thongtin_Nhomquangcao();
        ddlDanhMucCha.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlDanhMucCha.Items.Add(new ListItem(dt.Rows[i]["TenNhomQuangCao"].ToString(), dt.Rows[i]["NhomQuangCaoID"].ToString()));
            //dt.Rows[i]["AnhDaiDien"].ToString(), dt.Rows[i]["ThuTu"].ToString(), dt.Rows[i]["SoSPHienThi"].ToString()
        }
    }
    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region code nút thêm mới

            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/QuangCao/") + flAnhDaiDien.FileName);
                }
            }
            //else ltrThongBao.Text = "Nhập sai hoặc thiếu thông tin! Mời nhập lại";


            Shop.QuangCao.Quangcao_Inser(
                tbTen.Text, "", flAnhDaiDien.FileName, 
                tbLienKet.Text, tbThuTu.Text, ddlDanhMucCha.SelectedValue, "");
            ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã tạo quảng cáo mới</div>";

            if (cbThemNhieuDanhMuc.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?modul=QuangCao&modulphu=DanhSachQuangCao");
            }
            #endregion
        }
        else
        {
            #region code nút chỉnh sửa
            string tenAnhDaiDien = "";

            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/QuangCao/") + flAnhDaiDien.FileName);
                    tenAnhDaiDien = flAnhDaiDien.FileName;

                    // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                }
            }

            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }

            Shop.QuangCao.Quangcao_Update(
                id, tbTen.Text, "", tenAnhDaiDien,  
                tbLienKet.Text, tbThuTu.Text, ddlDanhMucCha.SelectedValue);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=QuangCao&modulphu=DanhSachQuangCao");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbTen.Text = "";
        tbThuTu.Text = "";
        tbLienKet.Text = "";
    }
    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}