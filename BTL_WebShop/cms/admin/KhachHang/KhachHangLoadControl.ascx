<%@ Control Language="C#" AutoEventWireup="true" CodeFile="KhachHangLoadControl.ascx.cs" Inherits="cms_admin_KhachHang_KhachHangLoadControl" %>
 <div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Quản lý
        </div>
        <ul>
            <li><a class="<%=DanhDau("KhachHang","DanhSachKhachHang","") %>" href="Admin.aspx?modul=KhachHang&modulphu=DanhSachKhachHang">Danh sách khách hàng</a></li>
        </ul>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div> 