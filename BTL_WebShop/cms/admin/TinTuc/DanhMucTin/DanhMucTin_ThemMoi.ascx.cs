using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_TinTuc_DanhMucTin_DanhMucTin_ThemMoi : System.Web.UI.UserControl
{
    //private string thaotac = "";
    //private string id = "";//lấy id của danh mục tin cần chỉnh sửa
    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    if (Request.QueryString["thaotac"] != null)
    //        thaotac = Request.QueryString["thaotac"];
    //    if (Request.QueryString["id"] != null)
    //        id = Request.QueryString["id"];
    //    if (!IsPostBack)
    //    {

    //        LayDanhMucCha();

    //        HienThiThongTin(id);
    //    }
    //}

    //private void HienThiThongTin(string id)
    //{
    //    if (thaotac == "ChinhSua")
    //    {
    //        btThemMoi.Text = "Chỉnh Sửa";
    //        cbThemNhieuDanhMuc.Visible = false;

    //        DataTable dt = new DataTable();
    //        dt = Shop.DanhMucTin.Thongtin_DanhmucTin_by_id(id);
    //        if (dt.Rows.Count > 0)
    //        {
    //            ddlDanhMucCha.SelectedValue = dt.Rows[0]["MaDMCha"].ToString();
    //            tbTenDanhMuc.Text = dt.Rows[0]["TenDM"].ToString();
    //            tbThuTu.Text = dt.Rows[0]["ThuTu"].ToString();

    //            ltrAnhDaiDien.Text = "<img class='anhDaiDien'src='/pic/TinTuc/" + dt.Rows[0]["AnhDaiDien"] + @"'/>";
    //            hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhDaiDien"].ToString();
    //        }
    //    }

    //    else
    //    {
    //        btThemMoi.Text = "Thêm Mới";
    //        cbThemNhieuDanhMuc.Visible = true;
    //    }

    //}
    //private void LayDanhMucCha()
    //{
    //    DataTable dt = new DataTable();
    //    dt = emdepvn.DanhMucTin.Thongtin_DanhmucTin_by_MaDMCha("0");
    //    ddlDanhMucCha.Items.Clear();

    //    ddlDanhMucCha.Items.Add(new ListItem("Danh mục gốc", "0"));
    //    for (int i = 0; i < dt.Rows.Count; i++)
    //    {
    //        ddlDanhMucCha.Items.Add(new ListItem(dt.Rows[i]["TenDM"].ToString(), dt.Rows[i]["MaDM"].ToString()));
    //        LayDanhMucCon(dt.Rows[i]["MaDM"].ToString(), "___");
    //    }
    //}

    //private void LayDanhMucCon(string MaDMCha, string KhoangCach)
    //{
    //    DataTable dt = new DataTable();
    //    dt = emdepvn.DanhMucTin.Thongtin_DanhmucTin_by_MaDMCha(MaDMCha);

    //    for (int i = 0; i < dt.Rows.Count; i++)
    //    {
    //        ddlDanhMucCha.Items.Add(new ListItem(KhoangCach + dt.Rows[i]["TenDM"].ToString(), dt.Rows[i]["MaDM"].ToString()));
    //        LayDanhMucCon(dt.Rows[i]["MaDM"].ToString(), KhoangCach + "___");
    //    }
    //}
    //protected void btThemMoi_Click(object sender, EventArgs e)
    //{
    //    if (thaotac == "ThemMoi")
    //    {
    //        #region code nút thêm mới

    //        if (flAnhDaiDien.FileContent.Length > 0)
    //        {
    //            if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
    //            {
    //                flAnhDaiDien.SaveAs(Server.MapPath("pic/TinTuc/") + flAnhDaiDien.FileName);
    //            }
    //        }
    //        //else ltrThongBao.Text = "Nhập sai hoặc thiếu thông tin! Mời nhập lại";


    //        emdepvn.DanhMucTin.DanhmucTin_Inser(tbTenDanhMuc.Text, flAnhDaiDien.FileName, tbThuTu.Text, ddlDanhMucCha.SelectedValue, "");
    //        ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã tạo danh mục tin: " + tbTenDanhMuc.Text + "</div>";

    //        if (cbThemNhieuDanhMuc.Checked)
    //        {
    //            //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
    //            ResetControl();
    //        }

    //        else
    //        {
    //            //đẩy trang về trang danh sách các damnh mục đã tạo

    //            Response.Redirect("Admin.aspx?modul=TinTuc&modulphu=DanhMucTin");
    //        }
    //        #endregion
    //    }
    //    else
    //    {
    //        #region code nút chỉnh sửa
    //        string tenAnhDaiDien = "";

    //        if (flAnhDaiDien.FileContent.Length > 0)
    //        {
    //            if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
    //            {
    //                flAnhDaiDien.SaveAs(Server.MapPath("pic/TinTuc/") + flAnhDaiDien.FileName);
    //                tenAnhDaiDien = flAnhDaiDien.FileName;

    //                // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
    //            }
    //        }

    //        if (tenAnhDaiDien == "")
    //        {
    //            tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
    //        }

    //        emdepvn.DanhMucTin.DanhmucTin_Update(id, tbTenDanhMuc.Text, flAnhDaiDien.FileName, tbThuTu.Text, ddlDanhMucCha.SelectedValue);

    //        //đẩy trang về trang danh sách các damnh mục đã tạo
    //        Response.Redirect("Admin.aspx?modul=TinTuc&modulphu=DanhMucTin");

    //        #endregion
    //    }
    //}

    //private void ResetControl()
    //{
    //    tbTenDanhMuc.Text = "";
    //    tbThuTu.Text = "";

    //}
    //protected void btHuy_Click(object sender, EventArgs e)
    //{
    //    ResetControl();
    //}
}