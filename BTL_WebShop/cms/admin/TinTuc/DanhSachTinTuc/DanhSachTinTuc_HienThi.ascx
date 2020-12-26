<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSachTinTuc_HienThi.ascx.cs" Inherits="cms_admin_TinTuc_DanhSachTinTuc_DanhSachTinTuc_HienThi" %>
<div class="head">
    Các tin đã tạo 
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=TinTuc&modulphu=DanhSachTinTuc&thaotac=ThemMoi">Thêm mới tin tức</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tiêu đề</th>
           <th class="cotAnh">Ảnh đại diện</th>
           <th class="cotSoLuong">Lượt xem</th>
           <th class="cotNgayDang">Ngày đăng</th>
           <th class="cotThuTu">Thứ Tự</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrTinTuc" runat="server"></asp:Literal>
   </table>
</div>

<%--<script type="text/javascript">
    function XoaTinTuc(TinTucID) {
        if (confirm("Bạn chắc chắn muốn xóa sản phẩm này")) {
            //Viết code xóa danh mục tại đây

            $.post("cms/admin/TinTuc/DanhSachTinTuc/Ajax/TinTuc.aspx",
                {
                    "ThaoTac": "XoaTinTuc",
                    "TinTucID": TinTucID
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + TinTucID).slideUp();

                    }
                });
        }
    }
</script>--%>