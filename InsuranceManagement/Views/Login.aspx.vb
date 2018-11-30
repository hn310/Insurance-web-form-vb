Public Class Login
    Inherits System.Web.UI.Page

    Private UserDao As New UserDao()

    Protected Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim loginName As String = tbLoginName.Text
        Dim password As String = tbLoginPassword.Text
        If (StringUtil.isEmpty(loginName)) Then
            lblError.Visible = True
            lblError.Text = "Hãy nhập Tên đăng nhập"
            Return
        End If

        If (StringUtil.isEmpty(password)) Then
            lblError.Visible = True
            lblError.Text = "Hãy nhập Mật khẩu"
            Return
        End If

        If (UserDao.ExistUser(loginName, password)) Then
            Response.Redirect("~/Views/UserList.aspx")
        Else
            lblError.Visible = True
            lblError.Text = "Tên đăng nhập hoặc Mật khẩu không đúng!"
        End If

    End Sub
End Class