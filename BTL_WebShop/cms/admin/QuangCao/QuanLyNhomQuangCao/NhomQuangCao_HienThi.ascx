<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NhomQuangCao_HienThi.ascx.cs" Inherits="cms_admin_QuangCao_QuanLyNhomQuangCao_NhomQuangCao_HienThi" %>
<div class="head">
    Các nhóm quảng cáo đã tạo. 
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=QuangCao&modulphu=NhomQuangCao&thaotac=ThemMoi">Thêm mới nhóm quảng cáo</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbNhomQuangCao">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tên nhóm quảng cáo</th>
           <th class="cotViTri">Vị trí quảng cáo</th>
           <th class="cotAnh">Ảnh đại diện</th>
           <th class="cotThuTu">Thứ tự</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrNhomQuangCao" runat="server"></asp:Literal>
   </table>
</div>

<%--<script type="text/javascript">
    function XoaNhomQuangCao(NhomQuangCaoID) {
        if (confirm("Bạn chắc chắn muốn xóa nhóm sản phẩn này")) {
            //Viết code xóa danh mục tại đây

            $.post("cms/admin/QuangCao/QuanLyNhomQuangCao/Ajax/NhomQuangCao.aspx",
                {
                    "ThaoTac": "XoaNhomQuangCao",
                    "NhomQuangCaoID": NhomQuangCaoID
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + NhomQuangCaoID).slideUp();

                    }
                });
        }
    }
</script>--%>