@ModelType IEnumerable(Of CrudVB.Fornecedor)
@Code
    ViewData("Title") = "Index"
End Code



<div class="container body-content">

    <div class="center-content">
        <h2>Suppliers</h2>
        @Html.ActionLink("Create New", "Create", Nothing, New With {.class = "btn btn-primary"})
    </div>

    <table class="table table-striped table-hover">
        <thead>
            <tr>
                <th>@Html.DisplayNameFor(Function(model) model.NomeFornecedor)</th>
                <th>@Html.DisplayNameFor(Function(model) model.Endereco)</th>
                <th>@Html.DisplayNameFor(Function(model) model.Telefone)</th>
                <th>@Html.DisplayNameFor(Function(model) model.Email)</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            @For Each item In Model
        @<tr>
            <td>@Html.DisplayFor(Function(modelItem) item.NomeFornecedor)</td>
            <td>@Html.DisplayFor(Function(modelItem) item.Endereco)</td>
            <td>@Html.DisplayFor(Function(modelItem) item.Telefone)</td>
            <td>@Html.DisplayFor(Function(modelItem) item.Email)</td>
            <td>
                <div class="btn-group btn-group-row" role="group">
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}, New With {.class = "btn btn-sm btn-outline-primary"})
                    @Html.ActionLink("Details", "Details", New With {.id = item.Id}, New With {.class = "btn btn-sm btn-outline-info"})
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.Id}, New With {.class = "btn btn-sm btn-outline-danger"})
                </div>
            </td>
        </tr>
            Next
        </tbody>
    </table>
</div>
