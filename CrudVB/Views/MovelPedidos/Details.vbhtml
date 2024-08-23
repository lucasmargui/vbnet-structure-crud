@ModelType CrudVB.MovelPedido
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
