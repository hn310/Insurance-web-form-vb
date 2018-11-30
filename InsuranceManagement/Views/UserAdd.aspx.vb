Public Class UserAdd
    Inherits System.Web.UI.Page

    Private companyDao As CompanyDao

    Private companies As List(Of CompanyDto)

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        companyDao = New CompanyDao()
        PopulateGenderDropDown()
        ControlCompanyRadioButton()
        PopulateCompaniesDropDown()
        DisplayInitExistingCompanyInfo()
    End Sub

    Private Sub PopulateGenderDropDown()
        Dim genderMap As New Dictionary(Of String, String)
        genderMap.Add("01", "Nam")
        genderMap.Add("02", "Nữ")
        ddGender.DataSource = genderMap
        ddGender.DataValueField = "Key"
        ddGender.DataTextField = "Value"
        ddGender.DataBind()
    End Sub

    Private Sub ControlCompanyRadioButton()
        rbExistingCompany.Checked = True
        ExistingCompanyInfoArea.Visible = True
        rbNewCompany.Checked = False
        NewCompanyInfoArea.Style.Add("display", "none")
    End Sub

    Private Sub PopulateCompaniesDropDown()
        Dim companyDao As New CompanyDao
        companies = companyDao.GetCompanies()
        ddExistingCompany.DataTextField = "CompanyName"
        ddExistingCompany.DataValueField = "CompanyInternalId"
        ddExistingCompany.DataSource = companies
        ddExistingCompany.DataBind()
    End Sub

    Private Sub DisplayInitExistingCompanyInfo()
        Dim initCompanyInternalId As String = companies.First().CompanyInternalId
        Dim initCompany As CompanyDto = companyDao.GetCompanyById(initCompanyInternalId)
        lblExistingCompanyName.InnerText = initCompany.CompanyName
        lblExistingCompanyAddress.InnerText = initCompany.Address
        lblExistingCompanyEmail.InnerText = initCompany.Email
        lblExistingCompanyTelephone.InnerText = initCompany.Telephone
    End Sub

    Protected Sub ddExistingCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddExistingCompany.SelectedIndexChanged
        Dim currentCompanyInternalId As String = ddExistingCompany.SelectedItem.Value
        Dim currentCompany As CompanyDto = companyDao.GetCompanyById(currentCompanyInternalId)
        lblExistingCompanyName.InnerText = currentCompany.CompanyName
        lblExistingCompanyAddress.InnerText = currentCompany.Address
        lblExistingCompanyEmail.InnerText = currentCompany.Email
        lblExistingCompanyTelephone.InnerText = currentCompany.Telephone
    End Sub

    Protected Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim user As New UserDto
    End Sub
End Class