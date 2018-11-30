<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Views/Master/Site.Master" CodeBehind="UserAdd.aspx.vb" Inherits="InsuranceManagement.UserAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 251px;
        }

        .auto-style2 {
            width: 251px;
            height: 20px;
        }

        .auto-style3 {
            height: 20px;
        }

        .auto-style4 {
            width: 56%;
        }

        .auto-style5 {
            width: 98px;
        }

        .auto-style6 {
            width: 98px;
            height: 26px;
        }

        .auto-style7 {
            height: 26px;
        }
        .auto-style8 {
            width: 99%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <form id="form1" runat="server" method="post">
        <h2>Cập nhật thông tin thẻ bảo hiểm</h2>
        <table style="width: 66%;">
            <tr>
                <td class="auto-style1">Mã số thẻ bảo hiểm</td>
                <td>
                    <asp:TextBox ID="txtInsuranceNumber" runat="server" Width="236px"></asp:TextBox>
                    (format: 10 chữ số)</td>
            </tr>
            <tr>
                <td class="auto-style2">Họ và Tên</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtUserFullName" runat="server" Width="236px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Giới tính</td>
                <td>
                    <asp:DropDownList ID="ddGender" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Ngày sinh</td>
                <td>
                    <asp:TextBox ID="txtBirthdate" runat="server" Width="236px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="vertical-align: top">Công ty</td>
                <td>
                    <asp:RadioButton ID="rbExistingCompany" runat="server" onclick="showExistingCompany(this)" />
                    Công ty đã có<br />
                    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true"></asp:ScriptManager>
                    <asp:UpdatePanel ID="upnlUpdateExistingCompanyInfo" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="ddExistingCompany" runat="server" OnSelectedIndexChanged="ddExistingCompany_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList>
                            <br />
                            <table id="ExistingCompanyInfoArea" class="auto-style4" runat="server">
                                <tr>
                                    <td class="auto-style6">Tên công ty</td>
                                    <td class="auto-style7" id="lblExistingCompanyName">
                                        <asp:Label ID="lbl" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">Địa chỉ</td>
                                    <td id="lblExistingCompanyAddress">
                                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">Email</td>
                                    <td id="lblExistingCompanyEmail">
                                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">Điện thoại</td>
                                    <td id="lblExistingCompanyTelephone">
                                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="ddExistingCompany" EventName="SelectedIndexChanged" />
                        </Triggers>
                    </asp:UpdatePanel>
                    <asp:RadioButton ID="rbNewCompany" runat="server" onclick="showNewCompany(this)" />
                    Đăng ký theo công ty mới<br />
                    <table id="NewCompanyInfoArea" class="auto-style8" runat="server">
                        <tr>
                            <td class="auto-style6">Tên công ty</td>
                            <td class="auto-style7">
                                <asp:TextBox ID="txtNewCompanyName" runat="server" Width="226px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="txtNewCompanyValidator" runat="server" ControlToValidate="txtNewCompanyName" ErrorMessage="Hãy nhập tên công ty" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">Địa chỉ</td>
                            <td>
                                <asp:TextBox ID="txtNewCompanyAddress" runat="server" Width="226px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">Email</td>
                            <td>
                                <asp:TextBox ID="txtNewCompanyEmail" runat="server" Width="226px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">Điện thoại</td>
                            <td>
                                <asp:TextBox ID="txtNewCompanyTelephone" runat="server" Width="226px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Nơi đăng ký KCB</td>
                <td>
                    <asp:TextBox ID="txtPlaceOfRegister" runat="server" Width="236px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Ngày bắt đầu thẻ BH</td>
                <td>
                    <asp:TextBox ID="txtInsuranceStartDate" runat="server" Width="236px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Ngày kết thúc thẻ BH</td>
                <td>
                    <asp:TextBox ID="txtInsuranceEndDate" runat="server" Width="236px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnCancel" runat="server" Text="Hủy" Width="69px" />
        <asp:Button ID="BtnUpdate" runat="server" Text="Cập nhật" />
    </form>
</asp:Content>
