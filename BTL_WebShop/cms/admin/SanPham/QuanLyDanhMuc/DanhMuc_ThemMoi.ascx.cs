using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using Shop;


public partial class cms_admin_SanPham_QuanLyDanhMuc_DanhMuc_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = "";//lấy id của danh mục cần chỉnh sửa
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (!IsPostBack)
        {

            LayDanhMucCha();
        }

    }
    private void LayDanhMucCha()
    {
        DataTable dt = new DataTable();
        dt = Shop.DanhMuc.Thongtin_Danhmuc();
        ddlDanhMucCha.Items.Clear();

        ddlDanhMucCha.Items.Add(new ListItem("Danh mục gốc", "0"));
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlDanhMucCha.Items.Add(new ListItem(dt.Rows[i]["TenDM"].ToString(), dt.Rows[i]["MaDM"].ToString()));
            
        }
    }

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
     

            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/SanPham/") + flAnhDaiDien.FileName);
                }
            }

        Shop.DanhMuc.Danhmuc_Inser(tbTenDanhMuc.Text, flAnhDaiDien.FileName, tbThuTu.Text, ddlDanhMucCha.SelectedValue,"");
        ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã tạo danh mục: " + tbTenDanhMuc.Text + "</div>";

        if (cbThemNhieuDanhMuc.Checked)
        {
            //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
            ResetControl();
        }

        else
        {
            //đẩy trang về trang danh sách các damnh mục đã tạo

            Response.Redirect("Admin.aspx?modul=SanPham&modulphu=DanhMuc");
        }
    }

    private void ResetControl()
    {
        tbTenDanhMuc.Text = "";
        tbThuTu.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}