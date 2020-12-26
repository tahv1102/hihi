<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TaiKhoan_HienThi.ascx.cs" Inherits="cms_admin_TaiKhoan_TaiKhoan_HienThi" %>
<div class="head">
    Danh sách tài khoản đã tạo 
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan&thaotac=ThemMoi">Thêm tài khoản mới</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotTenDK">Tên  đăng nhập</th>
           <th class="cotEmail">Email</th>
           <th class="cotDiaChia">Địa chỉ</th>
           <th class="cotHoTen">Họ tên</th>
           <th class="cotNgaySinh">Ngày sinh</th>
           <th class="cotGioiTinh">Giới tính</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrTaiKhoan" runat="server"></asp:Literal>
   </table>
</div>
<%--<script type="text/javascript">
    function XoaTaiKhoan(TenDangNhap) {
        if (confirm("Bạn chắc chắn muốn xóa tài khoản này")) {
            //Viết code xóa màu tại đây

            $.post("cms/admin/TaiKhoan/Ajax/TaiKhoan.aspx",
                {
                    "ThaoTac": "XoaTaiKhoan",
                    "TenDangNhap": TenDangNhap
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + TenDangNhap).slideUp();

                    }

                    else
                    {
                        alert(data);
                    }
                });
        }
    }
</script>--%>