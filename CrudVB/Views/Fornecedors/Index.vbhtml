@ModelType IEnumerable(Of CrudVB.Fornecedor)
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
            @Html.DisplayNameFor(Function(model) model.NomeFornecedor)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Endereco)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Telefone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Email)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NomeFornecedor)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Endereco)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Telefone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Email)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
