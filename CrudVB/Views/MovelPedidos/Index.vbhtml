@ModelType IEnumerable(Of CrudVB.MovelPedido)
@Code
    ViewData("Title") = "Index"
End Code

<div class="center-content">
    <h2>Pedidos</h2>
    @Html.ActionLink("Create New", "Create", Nothing, New With {.class = "btn btn-primary"})
</div>

<table class="table table-striped table-hover">
    <thead>
        <tr>
            <th>@Html.DisplayNameFor(Function(model) model.MaterialMovel.NomeMaterial)</th>
            <th>@Html.DisplayNameFor(Function(model) model.NumeroPedido)</th>
            <th>@Html.DisplayNameFor(Function(model) model.Quantidade)</th>
            <th>@Html.DisplayNameFor(Function(model) model.DataPedido)</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
        @For Each item In Model
            @<tr>
                <td>@Html.DisplayFor(Function(modelItem) item.MaterialMovel.NomeMaterial)</td>
                <td>@Html.DisplayFor(Function(modelItem) item.NumeroPedido)</td>
                <td>@Html.DisplayFor(Function(modelItem) item.Quantidade)</td>
                <td>@Html.DisplayFor(Function(modelItem) item.DataPedido)</td>
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
