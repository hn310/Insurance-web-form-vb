Imports Oracle.DataAccess.Client

Public Class CompanyDao

    Public Function GetCompanies() As List(Of CompanyDto)
        Dim companies As New List(Of CompanyDto)
        Dim conn As OracleConnection = DatabaseUtil.InitConnection()
        Dim query As String = "SELECT COMPANY_INTERNAL_ID, COMPANY_NAME FROM TBL_COMPANY ORDER BY COMPANY_NAME"
        Dim command As OracleCommand = New OracleCommand(query, conn)
        Dim dataReader As OracleDataReader = command.ExecuteReader()

        While (dataReader.Read())
            Dim company As New CompanyDto
            Dim companyInternalId As Integer = Convert.ToInt32(dataReader("COMPANY_INTERNAL_ID").ToString)
            Dim companyName As String = dataReader("COMPANY_NAME").ToString
            company.CompanyInternalId = companyInternalId
            company.CompanyName = companyName
            companies.Add(company)
        End While

        DatabaseUtil.CloseConnection(conn)
        Return companies
    End Function

    Public Function GetCompanyById(companyInternalId As String) As CompanyDto
        Dim company As New CompanyDto
        Dim conn As OracleConnection = DatabaseUtil.InitConnection()
        Dim query As String = "SELECT * FROM TBL_COMPANY WHERE COMPANY_INTERNAL_ID = :companyInternalId"
        Dim command As OracleCommand = New OracleCommand(query, conn)
        command.Parameters.Add(New OracleParameter("companyInternalId", OracleDbType.Int32)).Value = Convert.ToInt32(companyInternalId)
        Dim dataReader As OracleDataReader = command.ExecuteReader()
        While (dataReader.Read())
            company.CompanyInternalId = companyInternalId
            company.CompanyName = dataReader("COMPANY_NAME")
            company.Address = dataReader("ADDRESS")
            company.Email = dataReader("EMAIL")
            company.Telephone = dataReader("TELEPHONE")
            Return company
        End While
        Return Nothing
    End Function

End Class
