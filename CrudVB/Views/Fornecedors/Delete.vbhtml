@ModelType CrudVB.Fornecedor
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
