@ModelType IEnumerable(Of CrudVB.MaterialMovel)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.NomeMaterial)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TipoMaterial)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Descricao)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Espessura)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Largura)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Altura)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cor)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Fabricante)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CodigoFabricante)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Preco)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DataCadastro)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NomeMaterial)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TipoMaterial)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Descricao)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Espessura)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Largura)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Altura)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cor)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Fabricante)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CodigoFabricante)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Preco)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DataCadastro)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
