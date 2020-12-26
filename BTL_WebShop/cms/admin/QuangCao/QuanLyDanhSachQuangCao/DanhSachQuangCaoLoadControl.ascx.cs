using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_QuangCao_QuanLyDanhSachQuangCao_DanhSachQuangCaoLoadControl : System.Web.UI.UserControl
{
    private string thaotac = "null";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        switch (thaotac)
        {
            case "ThemMoi":
            case "ChinhSua":
                plLoadControl.Controls.Add(LoadControl("DanhSachQuangCao_ThemMoi.ascx"));
                break;

            case "HienThi":
                plLoadControl.Controls.Add(LoadControl("DanhSachQuangCao_ChinhSua.ascx"));
                break;

            default:
                plLoadControl.Controls.Add(LoadControl("DanhSachQuangCao_HienThi.ascx"));
                break;

        }
    }
}