<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSachTinTuc_ThemMoi.ascx.cs" Inherits="cms_admin_TinTuc_DanhSachTinTuc_DanhSachTinTuc_ThemMoi" %>
<%--<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div class="head">
    Thêm mới, chỉnh sửa tin tức
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Chọn danh mục tin</div>
        <div class="oNhap"><asp:DropDownList ID="ddlDanhMucCha" runat="server"></asp:DropDownList></div>
    </div>   
    <div class="thongTin">
        <div class="tenTruong">Tiêu đề</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbTieuDe" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbTieuDe" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Mô tả</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbMoTa" TextMode="MultiLine" runat="server" Height="150px"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Lượt xem</div>
        <div class="oNhap">
            <asp:TextBox ID="tbLuotXem" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Số lượng phải nhập kiểu số" ControlToValidate="tbLuotXem" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div> 
    <div class="thongTin">
        <div class="tenTruong">Ngày đăng</div>
        <div class="oNhap">
            <asp:TextBox ID="tbNgayDang" runat="server"></asp:TextBox>
        </div>
    </div> 
    <div class="thongTin">
        <div class="tenTruong">Ảnh Đại Diện</div>
        <div class="oNhap">
            <div>
                <asp:HiddenField ID="hdTenAnhDaiDienCu" runat="server" />
                <asp:Literal ID="ltrAnhDaiDien" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="flAnhDaiDien" runat="server" />
        </div>
    </div> 
    <div class="thongTin">
        <div class="tenTruong">Thứ tự</div>
        <div class="oNhap">
            <asp:TextBox ID="tbThuTu" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Thứ tự phải nhập kiểu số" ControlToValidate="tbThuTu" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div>  
    <div class="thongTin">
        <div class="tenTruong">Bài viết chi tiết</div>
        <div class="oNhap">            
            <%--<asp:TextBox ID="tbMoTa" TextMode="MultiLine" runat="server" Height="150px"></asp:TextBox>--%>
            <%--<CKEditor:CKEditorControl ID="tbChiTiet" runat="server" FilebrowserImageBrowseUrl="ckeditor/ckfinder/ckfinder.aspx?type=Images&path=pic"></CKEditor:CKEditorControl>
        </div>
    </div>
   
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap"><asp:CheckBox ID="cbThemNhieuDanhMuc" runat="server" Text="Tạo thêm tin khác sau khi tạo tin này"/></div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Thêm mới" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
            <asp:Button ID="btHuy" runat="server" Text="Hủy" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>--%>--%>
Thêm mới tin tức