<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TinTucLoadControl.ascx.cs" Inherits="cms_admin_TinTuc_TinTucLoadControl" %>
Code trang tin tức
 <div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Quản lý
        </div>
        <ul>
            <li><a class="<%=DanhDau("TinTuc","DanhMucTin","") %>" href="Admin.aspx?modul=TinTuc&modulphu=DanhMucTin">Danh mục tin tức</a></li>
            <li><a class="<%=DanhDau("TinTuc","DanhSachTinTuc","") %>" href="Admin.aspx?modul=TinTuc&modulphu=DanhSachTinTuc">Danh sách tin tức</a></li>            
        </ul>
        <div class="head">
            Thêm mới
        </div>
        <ul>
            <li><a class="<%=DanhDau("TinTuc","DanhMucTin","ThemMoi") %>" href="Admin.aspx?modul=TinTuc&modulphu=DanhMucTin&thaotac=ThemMoi">Danh mục tin tức</a></li>
            <li><a class="<%=DanhDau("TinTuc","DanhSachTinTuc","ThemMoi") %>" href="Admin.aspx?modul=TinTuc&modulphu=DanhSachTinTuc&thaotac=ThemMoi">Danh sách tin tức</a></li>            
        </ul>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plTinTucLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div> 
