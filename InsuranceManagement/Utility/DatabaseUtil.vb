Imports Oracle.DataAccess.Client

Class DatabaseUtil

    Public Shared Function InitConnection() As OracleConnection
        Dim conn As OracleConnection
        conn = New OracleConnection("Data Source=localhost:1522/test;User ID=root;Password=root")
        conn.Open()
        Return conn
    End Function

    Public Shared Sub CloseConnection(connection As OracleConnection)
        connection.Dispose()
    End Sub
End Class
