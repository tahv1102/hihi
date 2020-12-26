<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu_HienThi.ascx.cs" Inherits="cms_admin_Menu_Menu_HienThi" %>
<div class="head">
    Các Menu đã tạo. 
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=Menu&modulphu=DanhSachMenu&thaotac=ThemMoi">Thêm mới danh mục</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tên menu</th>
           <th class="cotThuTu">Thứ tự</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrMenu" runat="server"></asp:Literal>
   </table>
</div>

<%--<script type="text/javascript">
    function XoaMenu(MaMenu) {
        if (confirm("Bạn chắc chắn muốn xóa menu này")) {
            //Viết code xóa danh mục tại đây

            $.post("cms/admin/Menu/Ajax/Menu.aspx",
                {
                    "ThaoTac": "XoaMenu",
                    "MaMenu": MaMenu
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + MaMenu).slideUp();

                    }
                });
        }
    }
</script>--%>