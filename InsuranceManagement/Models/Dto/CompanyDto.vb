Public Class CompanyDto
    Private companyInternalIdValue As Integer
    Public Property CompanyInternalId() As Integer
        Get
            Return companyInternalIdValue
        End Get
        Set(ByVal value As Integer)
            companyInternalIdValue = value
        End Set
    End Property

    Private companyNameValue As String
    Public Property CompanyName() As String
        Get
            Return companyNameValue
        End Get
        Set(ByVal value As String)
            companyNameValue = value
        End Set
    End Property

    Private addressValue As String
    Public Property Address() As String
        Get
            Return addressValue
        End Get
        Set(ByVal value As String)
            addressValue = value
        End Set
    End Property

    Private emailValue As String
    Public Property Email() As String
        Get
            Return emailValue
        End Get
        Set(ByVal value As String)
            emailValue = value
        End Set
    End Property

    Private telephoneValue As String
    Public Property Telephone() As String
        Get
            Return telephoneValue
        End Get
        Set(ByVal value As String)
            telephoneValue = value
        End Set
    End Property

End Class
