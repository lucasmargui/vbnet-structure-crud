Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class MovelPedido
    Public Property Id As Integer

    <Required>
    <Display(Name:="Order Number")>
    Public Property NumeroPedido As String

    <Display(Name:="Quantity")>
    Public Property Quantidade As Integer

    <Display(Name:="Order Date")>
    Public Property DataPedido As DateTime

    ' Chave estrangeira para MaterialMovel
    <ForeignKey("MaterialMovel")>
    Public Property MaterialMovelId As Integer

    ' Propriedade de navegação para MaterialMovel
    Public Overridable Property MaterialMovel As MaterialMovel
End Class