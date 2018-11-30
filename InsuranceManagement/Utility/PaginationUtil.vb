Imports Oracle.DataAccess.Client

Class PaginationUtil

    Public Shared Function getTotalRecords() As Integer
        Dim conn As OracleConnection
        Dim command As OracleCommand
        Dim query As String
        Dim totalRecords As Integer = 0

        conn = DatabaseUtil.initConnection()
        query = "SELECT COUNT(*) FROM USER_INFO"
        command = New OracleCommand(query, conn)

        totalRecords = Convert.ToInt16(command.ExecuteScalar())
        Return totalRecords
    End Function

    Public Shared Function getTotalPages(totalRecords As Integer, numberOfRecordsPerPage As Integer) As Integer
        Dim totalPages As Integer = Math.Ceiling(totalRecords / numberOfRecordsPerPage)
        Return totalPages
    End Function

    Public Shared Function getStartQueryPosition(currentPage As Integer, numberOfRecordsPerPage As Integer) As Integer
        Dim startQueryPosition As Integer = (currentPage - 1) * numberOfRecordsPerPage 'start at 0
        Return startQueryPosition
    End Function

    Public Shared Function getEndQueryPostion(startQueryPosition As Integer, numberOfRecordsPerPage As Integer, totalRecords As Integer)
        Dim endQueryPosition As Integer = startQueryPosition + numberOfRecordsPerPage
        If (endQueryPosition > totalRecords) Then
            endQueryPosition = totalRecords
        End If
        Return endQueryPosition
    End Function

End Class
