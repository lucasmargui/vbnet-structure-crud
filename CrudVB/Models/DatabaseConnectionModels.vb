Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatabaseConnectionModels
    Private connectionString As String

    ' Construtor
    Public Sub New()
        ' Obtém a string de conexão do arquivo de configuração
        connectionString = ConfigurationManager.ConnectionStrings("ConnectProjetoDB").ConnectionString
    End Sub

    ' Método para abrir a conexão
    Public Function OpenConnection() As SqlConnection
        Dim connection As New SqlConnection(connectionString)
        Try
            connection.Open()
            Return connection
        Catch ex As Exception
            ' Trate a exceção conforme necessário
            Throw New Exception("Error opening database connection", ex)
        End Try
    End Function

    ' Método para fechar a conexão
    Public Sub CloseConnection(ByRef connection As SqlConnection)
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    ' Método para executar consultas SQL
    Public Function ExecuteQuery(query As String) As DataTable
        Using connection As SqlConnection = OpenConnection()
            Using command As New SqlCommand(query, connection)
                Dim dataAdapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)
                Return dataTable
            End Using
        End Using
    End Function
End Class
