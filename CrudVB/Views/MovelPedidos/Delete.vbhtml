@ModelType CrudVB.MovelPedido
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>MovelPedido</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.MaterialMovel.NomeMaterial)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MaterialMovel.NomeMaterial)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NumeroPedido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NumeroPedido)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Quantidade)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Quantidade)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DataPedido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DataPedido)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
