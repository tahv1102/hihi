<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Size_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLySize_Size_HienThi" %>
<%--<div class="head">
    Các Size đã tạo. 
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=SanPham&modulphu=Size&thaotac=ThemMoi">Thêm một Size mới</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbSize">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tên Size</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrSize" runat="server"></asp:Literal>
   </table>
</div>
<script type="text/javascript">
    function XoaSize(SizeID) {
        if (confirm("Bạn chắc chắn muốn xóa Size này")) {
            //Viết code xóa màu tại đây

            $.post("cms/admin/SanPham/QuanLySize/Ajax/Size.aspx",
                {
                    "ThaoTac": "XoaSize",
                    "SizeID": SizeID
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + SizeID).slideUp();

                    }
                });
        }
    }
</script>--%>

Hiển thị size sản phẩm