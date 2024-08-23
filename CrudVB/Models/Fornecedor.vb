Imports System.ComponentModel.DataAnnotations

Public Class Fornecedor
    Public Property Id As Integer

    <Required>
    <Display(Name:="Fornecedor Name")>
    Public Property NomeFornecedor As String

    <Display(Name:="Address")>
    Public Property Endereco As String

    <Display(Name:="Phone Number")>
    Public Property Telefone As String

    <Display(Name:="Email")>
    Public Property Email As String

    ' Propriedade de navegação para relação many-to-many
    Public Overridable Property Materials As ICollection(Of MaterialMovel)
End Class