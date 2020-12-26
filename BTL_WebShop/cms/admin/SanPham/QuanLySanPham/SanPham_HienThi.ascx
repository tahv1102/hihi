<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPham_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLySanPham_SanPham_HienThi" %>
<%--<div class="head">
    Các sản phẩm đã tạo. 
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham&thaotac=ThemMoi">Thêm mới sản phẩm</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tên sản phẩm</th>
           <th class="cotAnh">Ảnh đại diện</th>
           <th class="cotSoLuong">Số lượng</th>
           <th class="cotDonGia">Đơn Giá</th>
           <th class="cotNgayTao">Ngày tạo</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrSanPham" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    function XoaSanPham(MaSP) {
        if (confirm("Bạn chắc chắn muốn xóa sản phẩm này")) {
            //Viết code xóa danh mục tại đây

            $.post("cms/admin/SanPham/QuanLySanPham/Ajax/SanPham.aspx",
                {
                    "ThaoTac": "XoaSanPham",
                    "MaSP": MaSP
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + MaSP).slideUp();

                    }
                });
        }
    }
</script>--%>


Hiểm thị sản phẩm