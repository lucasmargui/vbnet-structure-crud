@ModelType IEnumerable(Of CrudVB.MaterialMovel)
@Code
    ViewData("Title") = "Index"
End Code

<div class="center-content">
    <h2>Material</h2>
     @Html.ActionLink("Create New", "Create", Nothing, New With {.class = "btn btn-primary"})
   
</div>

<table class="table table-striped table-hover">
    <thead>
        <tr>
            <th>@Html.DisplayNameFor(Function(model) model.NomeMaterial)</th>
            <th>@Html.DisplayNameFor(Function(model) model.TipoMaterial)</th>
            <th>@Html.DisplayNameFor(Function(model) model.Descricao)</th>
            <th>@Html.DisplayNameFor(Function(model) model.Espessura)</th>
            <th>@Html.DisplayNameFor(Function(model) model.Largura)</th>
            <th>@Html.DisplayNameFor(Function(model) model.Altura)</th>
            <th>@Html.DisplayNameFor(Function(model) model.Cor)</th>
            <th>@Html.DisplayNameFor(Function(model) model.Fabricante)</th>
            <th>@Html.DisplayNameFor(Function(model) model.CodigoFabricante)</th>
            <th>@Html.DisplayNameFor(Function(model) model.Preco)</th>
            <th>@Html.DisplayNameFor(Function(model) model.DataCadastro)</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
        @For Each item In Model
            @<tr>
                <td>@Html.DisplayFor(Function(modelItem) item.NomeMaterial)</td>
                <td>@Html.DisplayFor(Function(modelItem) item.TipoMaterial)</td>
                <td>@Html.DisplayFor(Function(modelItem) item.Descricao)</td>
                <td>@Html.DisplayFor(Function(modelItem) item.Espessura)</td>
                <td>@Html.DisplayFor(Function(modelItem) item.Largura)</td>
                <td>@Html.DisplayFor(Function(modelItem) item.Altura)</td>
                <td>@Html.DisplayFor(Function(modelItem) item.Cor)</td>
                <td>@Html.DisplayFor(Function(modelItem) item.Fabricante)</td>
                <td>@Html.DisplayFor(Function(modelItem) item.CodigoFabricante)</td>
                <td>@Html.DisplayFor(Function(modelItem) item.Preco)</td>
                <td>@Html.DisplayFor(Function(modelItem) item.DataCadastro)</td>
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


