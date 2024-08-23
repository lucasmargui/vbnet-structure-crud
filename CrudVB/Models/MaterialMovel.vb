Imports System.ComponentModel.DataAnnotations

Imports System.ComponentModel.DataAnnotations.Schema

Public Class MaterialMovel
    Public Property Id As Integer

    <Required>
    <Display(Name:="Material Name")>
    Public Property NomeMaterial As String

    <Display(Name:="Material Type")>
    Public Property TipoMaterial As String

    <Display(Name:="Description")>
    Public Property Descricao As String

    <Display(Name:="Thickness (mm)")>
    <Range(0, 1000, ErrorMessage:="Thickness must be between {1} and {2} mm.")>
    Public Property Espessura As Decimal

    <Display(Name:="Width (mm)")>
    <Range(0, 10000, ErrorMessage:="Width must be between {1} and {2} mm.")>
    Public Property Largura As Decimal

    <Display(Name:="Height (mm)")>
    <Range(0, 10000, ErrorMessage:="Height must be between {1} and {2} mm.")>
    Public Property Altura As Decimal

    <Display(Name:="Color")>
    Public Property Cor As String

    <Display(Name:="Manufacturer")>
    Public Property Fabricante As String

    <Display(Name:="Manufacturer Code")>
    Public Property CodigoFabricante As String

    <Display(Name:="Price")>
    <DataType(DataType.Currency)>
    Public Property Preco As Decimal

    <Display(Name:="Date Added")>
    Public Property DataCadastro As DateTime

    ' Propriedade de navegação para relação One-to-Many
    Public Overridable Property MovelPedidos As ICollection(Of MovelPedido)

    ' Propriedade de navegação para relação many-to-many
    Public Overridable Property Fornecedores As ICollection(Of Fornecedor)
End Class
