using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_AdminLoadControl : System.Web.UI.UserControl
{
   private string modul = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modul"] != null)
           modul = Request.QueryString["modul"];
       switch(modul)
        {
            case "SanPham":
                AdLoad.Controls.Add(LoadControl("SanPham/SanPhamLoadControl.ascx"));
                 break;

             case "TaiKhoan":
                AdLoad.Controls.Add(LoadControl("TaiKhoan/TaiKhoanLoadControl.ascx"));
                 break;

            case "QuangCao":
               AdLoad.Controls.Add(LoadControl("QuangCao/QuangCaoLoadControl.ascx"));
             break;

              case "TinTuc":
               AdLoad.Controls.Add(LoadControl("TinTuc/TinTucLoadControl.ascx"));
                break;

            case "KhachHang":
            AdLoad.Controls.Add(LoadControl("KhachHang/KhachHangLoadControl.ascx"));
             break;

          case "Menu":
               AdLoad.Controls.Add(LoadControl("Menu/MenuLoadControl.ascx"));
            break;

         default:
               AdLoad.Controls.Add(LoadControl("SanPham/SanPhamLoadControl.ascx"));
              break;

       }
        
     }
}