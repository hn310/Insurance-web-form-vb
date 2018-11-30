<%@ Page Language="vb" MasterPageFile="~/Views/Master/Site.Master" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="InsuranceManagement.Login" %>

<asp:Content ContentPlaceHolderID="Main" runat="server">
    <form id="loginForm" runat="server" accept-charset="utf-8" method="post">
        <h2>Đăng nhập hệ thống</h2>
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="False"></asp:Label>
        </p>
        <p>
            Tên đăng nhập&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbLoginName" runat="server"></asp:TextBox>
        </p>
        <p>
            Mật khẩu&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbLoginPassword" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p style="margin-left: 160px">
            <asp:Button ID="LoginBtn" runat="server" Text="Đăng nhập" />
        </p>
    </form>
</asp:Content>
