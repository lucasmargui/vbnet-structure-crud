@ModelType CrudVB.Fornecedor
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Fornecedor</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.NomeFornecedor)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NomeFornecedor)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Endereco)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Endereco)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Telefone)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Telefone)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Email)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
