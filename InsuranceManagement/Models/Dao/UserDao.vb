Imports Oracle.DataAccess.Client

Public Class UserDao
    Public Function ExistUser(loginName As String, loginPassword As String) As Boolean
        Dim conn As OracleConnection = DatabaseUtil.InitConnection()
        Dim query As String = "SELECT COUNT(*) FROM TBL_USER WHERE USERNAME = :loginName AND ""PASSWORD"" = :loginPassword"
        Dim command As OracleCommand = New OracleCommand(query, conn)
        command.Parameters.Add(New OracleParameter("loginName", OracleDbType.Varchar2)).Value = loginName
        command.Parameters.Add(New OracleParameter("loginPassword", OracleDbType.Varchar2)).Value = StringUtil.GetHash(loginPassword)

        Dim recordCount As Integer = Convert.ToInt32(command.ExecuteScalar())
        DatabaseUtil.CloseConnection(conn)
        If (recordCount = 0) Then
            Return False 'no user exists
        Else
            Return True
        End If
    End Function

    Public Function GetUsersByConditions(username As String, insuranceNumber As String, placeOfRegister As String) As List(Of UserDto)
        Dim users As New List(Of UserDto)
        Dim conn As OracleConnection = DatabaseUtil.InitConnection()
        Dim query As String = "SELECT u.USER_FULL_NAME, u.USER_SEX_DIVISION, u.BIRTHDATE,  " &
            "i.INSURANCE_NUMBER, i.INSURANCE_START_DATE, i.INSURANCE_END_DATE, i.PLACE_OF_REGISTER " &
            "FROM TBL_USER u " &
            "INNER JOIN TBL_COMPANY c ON u.COMPANY_INTERNAL_ID = c.COMPANY_INTERNAL_ID " &
            "INNER JOIN TBL_INSURANCE i ON u.INSURANCE_INTERNAL_ID = i.INSURANCE_INTERNAL_ID"
        Dim command As OracleCommand = New OracleCommand(query, conn)
        Dim dataReader As OracleDataReader = command.ExecuteReader()

        While (dataReader.Read())
            Dim user As New UserDto
            user.UserFullName = dataReader("USER_FULL_NAME").ToString
            user.UserSexDivision = dataReader("USER_SEX_DIVISION").ToString
            user.Birthdate = dataReader("BIRTHDATE").ToString
            user.InsuranceNumber = dataReader("INSURANCE_NUMBER").ToString
            user.InsuranceStartDate = dataReader("INSURANCE_START_DATE").ToString
            user.InsuranceEndDate = dataReader("INSURANCE_END_DATE").ToString
            user.PlaceOfRegister = dataReader("PLACE_OF_REGISTER").ToString
            users.Add(user)
        End While
        DatabaseUtil.CloseConnection(conn)
        Return users
    End Function
End Class
