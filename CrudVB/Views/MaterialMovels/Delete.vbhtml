@ModelType CrudVB.MaterialMovel
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>MaterialMovel</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.NomeMaterial)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NomeMaterial)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TipoMaterial)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TipoMaterial)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Descricao)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Descricao)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Espessura)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Espessura)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Largura)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Largura)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Altura)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Altura)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cor)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cor)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Fabricante)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Fabricante)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CodigoFabricante)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CodigoFabricante)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Preco)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Preco)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DataCadastro)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DataCadastro)
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
