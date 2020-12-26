<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhMucTin_HienThi.ascx.cs" Inherits="cms_admin_TinTuc_DanhMucTin_DanhMucTin_HienThi" %>
<div class="head">
    Các danh mục tin tức đã tạo. 
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=TinTuc&modulphu=DanhMucTin&thaotac=ThemMoi">Thêm mới danh mục tin</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tên danh mục</th>
           <th class="cotAnh">Ảnh đại diện</th>
           <th class="cotThuTu">Thứ tự</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrDanhMuc" runat="server"></asp:Literal>
   </table>
</div>

<%--<script type="text/javascript">
    function XoaDanhMuc(MaDM) {
        if (confirm("Bạn chắc chắn muốn xóa danh mục này")) {
            //Viết code xóa danh mục tại đây

            $.post("cms/admin/TinTuc/DanhMucTin/Ajax/DanhMucTin.aspx",
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