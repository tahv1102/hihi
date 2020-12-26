<%@ Control Language="C#" AutoEventWireup="true" CodeFile="KhachHang_HienThi.ascx.cs" Inherits="cms_admin_KhachHang_KhachHang_HienThi" %>
<div class="head">
    Danh sách khách hàng 
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbKhachHang">
       <tr>
           <th class="cotMa">Mã khách hàng</th>
           <th class="cotTen">Tên khách hàng</th>
           <th class="cotAnh">Địa chỉ</th>
           <th class="cotThuTu">Số điện thoại</th>
           <th class="cotEmail">Email</th>
       </tr>
       <asp:Literal ID="ltrKhachHang" runat="server"></asp:Literal>
   </table>
</div>

<%--<script type="text/javascript">
    function XoaDanhMuc(MaDM) {
        if (confirm("Bạn chắc chắn muốn xóa danh mục này")) {
            //Viết code xóa danh mục tại đây

            $.post("cms/admin/SanPham/QuanLyDanhMuc/Ajax/DanhMuc.aspx",
                {
                    "ThaoTac": "XoaDanhMuc",
                    "MaDM": MaDM
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + MaDM).slideUp();

                    }
                });
        }
    }
</script>--%>