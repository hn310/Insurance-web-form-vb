<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Views/Master/Site.Master" CodeBehind="UserList.aspx.vb" Inherits="InsuranceManagement.UserList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <form id="form1" runat="server">
        <h2>Danh sách thẻ bảo hiểm</h2>
        <p style="margin-left: 20px"><strong>Tên công ty</strong></p>
        <p style="margin-left: 20px">
            <asp:DropDownList ID="ddCompanies" runat="server">
            </asp:DropDownList>
        </p>
        <table style="width: 100%;">
            <thead>
                <tr>
                    <th>Tên người sử dụng</th>
                    <th>Giới tính</th>
                    <th>Ngày sinh</th>
                    <th>Mã số thẻ bảo hiểm</th>
                    <th>Kỳ hạn</th>
                    <th>Nơi đăng ký KCB</th>
                </tr>
            </thead>
            <%For Each User As InsuranceManagement.UserDto In Me.Users %>
            <tr>
                <%  Dim gender As String
                    If User.UserSexDivision = "01" Then
                        gender = "Nam"
                    Else
                        gender = "Nữ"
                    End If
                %>
                <td class="center"><%=User.UserFullName%></td>
                <td class="center"><%=gender%></td>
                <td class="center"><%=User.Birthdate.Day%>/<%=User.Birthdate.Month%>/<%=User.Birthdate.Year%></td>
                <td class="center"><%=User.InsuranceNumber%></td>
                <td class="center"><%=User.InsuranceStartDate.Day%>/<%=User.InsuranceStartDate.Month%>/<%=User.InsuranceStartDate.Year%>
                    ~
                    <%=User.InsuranceEndDate.Day%>/<%=User.InsuranceEndDate.Month%>/<%=User.InsuranceEndDate.Year%></td>
                <td class="center"><%=User.PlaceOfRegister%></td>
            </tr>
            <%Next%>
        </table>
    </form>
</asp:Content>
