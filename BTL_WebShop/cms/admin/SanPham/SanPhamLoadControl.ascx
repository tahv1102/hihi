<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPhamLoadControl.ascx.cs"
    Inherits="cms_admin_SanPham_SanPhamLoadControl" %>
 <div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Hiển Thị
        </div>
        <ul>
            <li><a class="<%=DanhDau("SanPham","DanhMuc","") %>"  href="Admin.aspx?modul=SanPham&modulphu=DanhMuc">Danh mục sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","DanhSachSanPham","") %>" href="Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham">Danh sách sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","Mau","") %>" href="Admin.aspx?modul=SanPham&modulphu=Mau">Màu sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","ChatLieu","") %>" href="Admin.aspx?modul=SanPham&modulphu=ChatLieu">Chất liệu sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","Size","") %>" href="Admin.aspx?modul=SanPham&modulphu=Size">Size sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","NhomSanPham","") %>" href="Admin.aspx?modul=SanPham&modulphu=NhomSanPham">Nhóm Sản Phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","PhienDauGia","") %>"  href="Admin.aspx?modul=SanPham&modulphu=PhienDauGia">Phiên đấu giá</a></li>
            <li><a class="<%=DanhDau("SanPham","DonHang","") %>"  href="Admin.aspx?modul=SanPham&modulphu=DonHang">Đơn hàng</a></li>
        </ul>
        <div class="head">
            Thêm mới
        </div>
        <ul>
            <li><a class="<%=DanhDau("SanPham","DanhMuc","ThemMoi") %>" href="Admin.aspx?modul=SanPham&modulphu=DanhMuc&thaotac=ThemMoi">Danh mục sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","DanhSachSanPham","ThemMoi") %>" href="Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham&thaotac=ThemMoi">Danh sách sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","Mau","ThemMoi") %>" href="Admin.aspx?modul=SanPham&modulphu=Mau&thaotac=ThemMoi">Màu sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","ChatLieu","ThemMoi") %>" href ="Admin.aspx?modul=SanPham&modulphu=ChatLieu&thaotac=ThemMoi">Chất liệu sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","Size","ThemMoi") %>" href="Admin.aspx?modul=SanPham&modulphu=Size&thaotac=ThemMoi">Size sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","NhomSanPham","ThemMoi") %>" href="Admin.aspx?modul=SanPham&modulphu=NhomSanPham&thaotac=ThemMoi">Nhóm Sản Phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","PhienDauGia","ThemMoi") %>" href="Admin.aspx?modul=SanPham&modulphu=PhienDauGia&thaotac=ThemMoi">Phiên đấu giá</a></li>
        </ul>
    </div>
    <div class="cotPhai">
      
        <asp:PlaceHolder ID="plSanPhamLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div> 

</div>


