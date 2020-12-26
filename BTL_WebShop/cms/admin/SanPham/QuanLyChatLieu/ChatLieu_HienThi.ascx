<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChatLieu_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyChatLieu_ChatLieu_HienThi" %>


Code hiển thị chất liệu


<%--<div class="head">
    Các chất liệu đã tạo. 
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=SanPham&modulphu=ChatLieu&thaotac=ThemMoi">Thêm chất liệu mới</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbChatLieu">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tên chất liệu</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrChatLieu" runat="server"></asp:Literal>
   </table>
</div>
<script type="text/javascript">
    function XoaChatLieu(ChatLieuID) {
        if (confirm("Bạn chắc chắn muốn xóa màu này")) {
            //Viết code xóa màu tại đây

            $.post("cms/admin/SanPham/QuanLyChatLieu/Ajax/ChatLieu.aspx",
                {
                    "ThaoTac": "XoaChatLieu",
                    "ChatLieuID": ChatLieuID
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + ChatLieuID).slideUp();

                    }
                });
        }
    }
</script>--%>