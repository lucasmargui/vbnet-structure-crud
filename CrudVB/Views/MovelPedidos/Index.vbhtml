@ModelType IEnumerable(Of CrudVB.MovelPedido)
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
            @Html.DisplayNameFor(Function(model) model.MaterialMovel.NomeMaterial)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NumeroPedido)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Quantidade)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DataPedido)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MaterialMovel.NomeMaterial)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NumeroPedido)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Quantidade)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DataPedido)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
