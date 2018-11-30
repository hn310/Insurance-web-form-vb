Public Class UserDto
    Private userInternalIdValue As Integer
    Public Property UserInternalId() As Integer
        Get
            Return userInternalIdValue
        End Get
        Set(ByVal value As Integer)
            userInternalIdValue = value
        End Set
    End Property

    Private CompanyInternalIdValue As Integer
    Public Property CompanyInternalId() As Integer
        Get
            Return CompanyInternalIdValue
        End Get
        Set(ByVal value As Integer)
            CompanyInternalIdValue = value
        End Set
    End Property

    Private InsuranceInternalIdValue As Integer
    Public Property InsuranceInternalId() As Integer
        Get
            Return InsuranceInternalIdValue
        End Get
        Set(ByVal value As Integer)
            InsuranceInternalIdValue = value
        End Set
    End Property

    Private UsernameValue As String
    Public Property Username() As String
        Get
            Return UsernameValue
        End Get
        Set(ByVal value As String)
            UsernameValue = value
        End Set
    End Property

    Private PasswordValue As String
    Public Property Password() As String
        Get
            Return PasswordValue
        End Get
        Set(ByVal value As String)
            PasswordValue = value
        End Set
    End Property

    Private UserFullNameValue As String
    Public Property UserFullName() As String
        Get
            Return UserFullNameValue
        End Get
        Set(ByVal value As String)
            UserFullNameValue = value
        End Set
    End Property

    Private UserSexDivisionValue As String
    Public Property UserSexDivision() As String
        Get
            Return UserSexDivisionValue
        End Get
        Set(ByVal value As String)
            UserSexDivisionValue = value
        End Set
    End Property

    Private BirthdateValue As Date
    Public Property Birthdate() As Date
        Get
            Return BirthdateValue
        End Get
        Set(ByVal value As Date)
            BirthdateValue = value
        End Set
    End Property

    Private InsuranceStartDateValue As Date
    Public Property InsuranceStartDate() As Date
        Get
            Return InsuranceStartDateValue
        End Get
        Set(ByVal value As Date)
            InsuranceStartDateValue = value
        End Set
    End Property

    Private InsuranceEndDateValue As Date
    Public Property InsuranceEndDate() As Date
        Get
            Return InsuranceEndDateValue
        End Get
        Set(ByVal value As Date)
            InsuranceEndDateValue = value
        End Set
    End Property

    Private InsuranceNumberValue As String
    Public Property InsuranceNumber() As String
        Get
            Return InsuranceNumberValue
        End Get
        Set(ByVal value As String)
            InsuranceNumberValue = value
        End Set
    End Property

    Private PlaceOfRegisterValue As String
    Public Property PlaceOfRegister() As String
        Get
            Return PlaceOfRegisterValue
        End Get
        Set(ByVal value As String)
            PlaceOfRegisterValue = value
        End Set
    End Property
End Class
