Public Class UserList
    Inherits System.Web.UI.Page

    Private usersValue As List(Of UserDto)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PopulateCompaniesDropDown()
        GetUsers()
    End Sub

    Private Sub PopulateCompaniesDropDown()
        Dim companyDao As New CompanyDao
        Dim companies As List(Of CompanyDto) = companyDao.GetCompanies()
        ddCompanies.DataTextField = "CompanyName"
        ddCompanies.DataValueField = "CompanyInternalId"
        ddCompanies.DataSource = companies
        ddCompanies.DataBind()
    End Sub

    Private Sub GetUsers()
        Dim userDao As New UserDao
        Me.Users = userDao.GetUsersByConditions("", "", "")
    End Sub

    Public Property Users() As List(Of UserDto)
        Get
            Return usersValue
        End Get
        Set(ByVal value As List(Of UserDto))
            usersValue = value
        End Set
    End Property
End Class