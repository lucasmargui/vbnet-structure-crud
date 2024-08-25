@ModelType CrudVB.MaterialMovel
@Code
    ViewData("Title") = "Create"
End Code

@*<h2>Create</h2>*@

@*@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Material</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        <div class="form-group">
            @Html.LabelFor(Function(model) model.NomeMaterial, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.NomeMaterial, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.NomeMaterial, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.TipoMaterial, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.TipoMaterial, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.TipoMaterial, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Descricao, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Descricao, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.Descricao, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Espessura, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Espessura, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.Espessura, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Largura, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Largura, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.Largura, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Altura, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Altura, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.Altura, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Cor, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Cor, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.Cor, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Fabricante, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Fabricante, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.Fabricante, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CodigoFabricante, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CodigoFabricante, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.CodigoFabricante, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Preco, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Preco, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.Preco, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.DataCadastro, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.DataCadastro, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.DataCadastro, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using*@




@*<div>
    @Html.ActionLink("Back to List", "Index")
</div>*@



@Using (Html.BeginForm())
        @Html.AntiForgeryToken()
    @<section Class="h-100 bg-dark">
        <div Class="container py-5 h-100">
            <div Class="row d-flex justify-content-center align-items-center h-100">
                <div Class="col">
                    <div Class="card card-registration my-4">
                        <div Class="row g-0">
                            <div class="col-xl-6 d-none d-xl-block" style="background-image: url('https://fastly.picsum.photos/id/307/5000/3333.jpg?hmac=wQFGsFoqFNhjL7Vf3y12D-qiKGUAl-BuhTbFJthHH4I'); background-repeat: repeat; background-size: contain; border-top-left-radius: .25rem; border-bottom-left-radius: .25rem;">
                                <img src="https://fastly.picsum.photos/id/307/5000/3333.jpg?hmac=wQFGsFoqFNhjL7Vf3y12D-qiKGUAl-BuhTbFJthHH4I"
                                     alt="Sample photo" class="img-fluid"
                                     style="border-top-left-radius: .25rem; border-bottom-left-radius: .25rem; width: 100%; height: auto;" />
                            </div>
                            <div Class="col-xl-6">
                                <div Class="card-body p-md-5 text-black">
                                    <h3 Class="mb-5 text-uppercase">Material Form</h3>

                                    <div Class="row">
                                        <div Class="col-md-6 mb-4">
                                            @Html.ValidationMessageFor(Function(model) model.NomeMaterial, "", New With {.class = "text-danger"})

                                            <div data-mdb-input-init Class="form-outline">
                                               
                                                @Html.EditorFor(Function(model) model.NomeMaterial, New With {.htmlAttributes = New With {.class = "form-control form-control-lg"}})
                                                @Html.LabelFor(Function(model) model.NomeMaterial, htmlAttributes:=New With {.class = "form-label"})

                                              
                                            </div>
                                        </div>
                                        <div Class="col-md-6 mb-4">
                                            @Html.ValidationMessageFor(Function(model) model.TipoMaterial, "", New With {.class = "text-danger"})

                                            <div data-mdb-input-init Class="form-outline">
                                                @Html.EditorFor(Function(model) model.TipoMaterial, New With {.htmlAttributes = New With {.class = "form-control form-control-lg"}})
                                                @Html.LabelFor(Function(model) model.TipoMaterial, htmlAttributes:=New With {.class = "form-label"})
                                            </div>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-md-6 mb-4">
                                            @Html.ValidationMessageFor(Function(model) model.DataCadastro, "", New With {.class = "text-danger"})
                                            <div data-mdb-input-init class="form-outline">
                                                @Html.EditorFor(Function(model) model.DataCadastro, New With {.htmlAttributes = New With {.class = "form-control form-control-lg"}})
                                                @Html.LabelFor(Function(model) model.DataCadastro, htmlAttributes:=New With {.class = "form-label"})
                                            </div>
                                        </div>

                                        <div class="col-md-6 mb-4">
                                            @Html.ValidationMessageFor(Function(model) model.Espessura, "", New With {.class = "text-danger"})
                                            <div data-mdb-input-init class="form-outline">
                                                @Html.EditorFor(Function(model) model.Espessura, New With {.htmlAttributes = New With {.class = "form-control form-control-lg"}})
                                                @Html.LabelFor(Function(model) model.Espessura, htmlAttributes:=New With {.class = "form-label"})
                                            </div>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-md-6 mb-4">
                                            @Html.ValidationMessageFor(Function(model) model.Largura, "", New With {.class = "text-danger"})
                                            <div data-mdb-input-init class="form-outline">
                                                @Html.EditorFor(Function(model) model.Largura, New With {.htmlAttributes = New With {.class = "form-control form-control-lg"}})
                                                @Html.LabelFor(Function(model) model.Largura, htmlAttributes:=New With {.class = "form-label"})
                                            </div>
                                        </div>

                                        <div class="col-md-6 mb-4">
                                            @Html.ValidationMessageFor(Function(model) model.Altura, "", New With {.class = "text-danger"})
                                            <div data-mdb-input-init class="form-outline">
                                                @Html.EditorFor(Function(model) model.Altura, New With {.htmlAttributes = New With {.class = "form-control form-control-lg"}})
                                                @Html.LabelFor(Function(model) model.Altura, htmlAttributes:=New With {.class = "form-label"})
                                            </div>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-md-6 mb-4">
                                            @Html.ValidationMessageFor(Function(model) model.Cor, "", New With {.class = "text-danger"})
                                            <div data-mdb-input-init class="form-outline">
                                                @Html.EditorFor(Function(model) model.Cor, New With {.htmlAttributes = New With {.class = "form-control form-control-lg"}})
                                                @Html.LabelFor(Function(model) model.Cor, htmlAttributes:=New With {.class = "form-label"})
                                            </div>
                                        </div>

                                        <div class="col-md-6 mb-4">
                                            @Html.ValidationMessageFor(Function(model) model.Fabricante, "", New With {.class = "text-danger"})
                                            <div data-mdb-input-init class="form-outline">
                                                @Html.EditorFor(Function(model) model.Fabricante, New With {.htmlAttributes = New With {.class = "form-control form-control-lg"}})
                                                @Html.LabelFor(Function(model) model.Fabricante, htmlAttributes:=New With {.class = "form-label"})
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6 mb-4">
                                            @Html.ValidationMessageFor(Function(model) model.CodigoFabricante, "", New With {.class = "text-danger"})
                                            <div data-mdb-input-init class="form-outline">
                                                @Html.EditorFor(Function(model) model.CodigoFabricante, New With {.htmlAttributes = New With {.class = "form-control form-control-lg"}})
                                                @Html.LabelFor(Function(model) model.CodigoFabricante, htmlAttributes:=New With {.class = "form-label"})
                                            </div>
                                        </div>

                                        <div class="col-md-6 mb-4">
                                            @Html.ValidationMessageFor(Function(model) model.Preco, "", New With {.class = "text-danger"})
                                            <div data-mdb-input-init class="form-outline">
                                                @Html.EditorFor(Function(model) model.Preco, New With {.htmlAttributes = New With {.class = "form-control form-control-lg"}})
                                                @Html.LabelFor(Function(model) model.Preco, htmlAttributes:=New With {.class = "form-label"})
                                            </div>
                                        </div>
                                    </div>
                                    <div data-mdb-input-init Class="form-outline mb-4">
                                        @Html.ValidationMessageFor(Function(model) model.Descricao, "", New With {.class = "text-danger"})
                                        @Html.EditorFor(Function(model) model.Descricao, New With {.htmlAttributes = New With {.class = "form-control form-control-lg"}})
                                        @Html.LabelFor(Function(model) model.Descricao, htmlAttributes:=New With {.class = "form-label"})
                                    </div>



                                    <div Class="d-flex justify-content-end pt-3">
                                        <input type="submit" value="Create" class="btn btn-success" />
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

End Using



    @Section Scripts
        @Scripts.Render("~/bundles/jqueryval")
    End Section



