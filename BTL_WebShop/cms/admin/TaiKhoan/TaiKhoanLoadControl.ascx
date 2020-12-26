<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TaiKhoanLoadControl.ascx.cs" 
    Inherits="cms_admin_TaiKhoan_TaiKhoanLoadControl" %>
<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Quản lý
        </div>
        <ul>
            <li><a class="<%=DanhDau("TaiKhoan","DanhSachTaiKhoan","") %>" href="Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan">Danh sách tài khoản</a></li>
        </ul>
        <div class="head">
            Thêm mới
        </div>
        <ul>
            <li><a class="<%=DanhDau("TaiKhoan","DanhSachTaiKhoan","ThemMoi") %>" href="Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan&thaotac=ThemMoi">Danh sách tài khoản</a></li>            
        </ul>
    </div>
    <div class="cotPhai">
      
        <asp:PlaceHolder ID="plLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div>
