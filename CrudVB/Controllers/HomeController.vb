Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Dim db As New DatabaseConnectionModels()
        Dim query As String = "SELECT * FROM MateriaisMoveis"

        Try
            Dim result As DataTable = db.ExecuteQuery(query)
            ' Processar o resultado conforme necessário
        Catch ex As Exception
            ' Tratar qualquer erro
        End Try

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
