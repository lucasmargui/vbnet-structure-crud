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
                            <div Class="col-xl-6 d-none d-xl-block">
                                <img src = "https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-registration/img4.webp"
                                     alt="Sample photo" class="img-fluid"
                                     style="border-top-left-radius: .25rem; border-bottom-left-radius: .25rem;" />
                            </div>
                            <div Class="col-xl-6">
                                <div Class="card-body p-md-5 text-black">
                                    <h3 Class="mb-5 text-uppercase">Student registration form</h3>

                                    <div Class="row">
                                        <div Class="col-md-6 mb-4">
                                            @Html.ValidationMessageFor(Function(model) model.NomeMaterial, "", New With {.class = "text-danger"})

                                            <div data-mdb-input-init Class="form-outline">
                                               
                                                @Html.EditorFor(Function(model) model.NomeMaterial, New With {.htmlAttributes = New With {.class = "form-control form-control-lg"}})
                                                @Html.LabelFor(Function(model) model.NomeMaterial, htmlAttributes:=New With {.class = "form-label"})

                                              
                                            </div>
                                        </div>
                                        <div Class="col-md-6 mb-4">
                                            <div data-mdb-input-init Class="form-outline">
                                                <input type = "text" id="form3Example1n" Class="form-control form-control-lg" />
                                                <Label Class="form-label" for="form3Example1n">Last name</label>
                                            </div>
                                        </div>
                                    </div>

                                    <div Class="row">
                                        <div Class="col-md-6 mb-4">
                                            <div data-mdb-input-init Class="form-outline">
                                                <input type = "text" id="form3Example1m1" Class="form-control form-control-lg" />
                                                <Label Class="form-label" for="form3Example1m1">Mother's name</label>
                                            </div>
                                        </div>
                                        <div Class="col-md-6 mb-4">
                                            <div data-mdb-input-init Class="form-outline">
                                                <input type = "text" id="form3Example1n1" Class="form-control form-control-lg" />
                                                <Label Class="form-label" for="form3Example1n1">Father's name</label>
                                            </div>
                                        </div>
                                    </div>

                                    <div data-mdb-input-init Class="form-outline mb-4">
                                        <input type = "text" id="form3Example8" Class="form-control form-control-lg" />
                                        <Label Class="form-label" for="form3Example8">Address</label>
                                    </div>

                                    <div Class="d-md-flex justify-content-start align-items-center mb-4 py-2">

                                        <h6 Class="mb-0 me-4">Gender: </h6>

                                        <div Class="form-check form-check-inline mb-0 me-4">
                                            <input Class="form-check-input" type="radio" name="inlineRadioOptions" id="femaleGender"
                                                   value="option1" />
                                            <Label Class="form-check-label" for="femaleGender">Female</label>
                                        </div>

                                        <div Class="form-check form-check-inline mb-0 me-4">
                                            <input Class="form-check-input" type="radio" name="inlineRadioOptions" id="maleGender"
                                                   value="option2" />
                                            <Label Class="form-check-label" for="maleGender">Male</label>
                                        </div>

                                        <div Class="form-check form-check-inline mb-0">
                                            <input Class="form-check-input" type="radio" name="inlineRadioOptions" id="otherGender"
                                                   value="option3" />
                                            <Label Class="form-check-label" for="otherGender">Other</label>
                                        </div>

                                    </div>

                                    <div Class="row">
                                        <div Class="col-md-6 mb-4">

                                            <select data-mdb-Select-init>
                                                <option value = "1" > State</Option>
                                                <option value = "2" >Option 1</option>
                                                <option value = "3" >Option 2</option>
                                                <option value = "4" >Option 3</option>
                                            </select>

                                        </div>
                                        <div Class="col-md-6 mb-4">

                                            <select data-mdb-Select-init>
                                                <option value = "1" > City</Option>
                                                <option value = "2" >Option 1</option>
                                                <option value = "3" >Option 2</option>
                                                <option value = "4" >Option 3</option>
                                            </select>

                                        </div>
                                    </div>

                                    <div data-mdb-input-init Class="form-outline mb-4">
                                        <input type = "text" id="form3Example9" Class="form-control form-control-lg" />
                                        <Label Class="form-label" for="form3Example9">DOB</label>
                                    </div>

                                    <div data-mdb-input-init Class="form-outline mb-4">
                                        <input type = "text" id="form3Example90" Class="form-control form-control-lg" />
                                        <Label Class="form-label" for="form3Example90">Pincode</label>
                                    </div>

                                    <div data-mdb-input-init Class="form-outline mb-4">
                                        <input type = "text" id="form3Example99" Class="form-control form-control-lg" />
                                        <Label Class="form-label" for="form3Example99">Course</label>
                                    </div>

                                    <div data-mdb-input-init Class="form-outline mb-4">
                                        <input type = "text" id="form3Example97" Class="form-control form-control-lg" />
                                        <Label Class="form-label" for="form3Example97">Email ID</label>
                                    </div>

                                    <div Class="d-flex justify-content-end pt-3">
                                        <Button type = "button" data-mdb-button-init data-mdb-ripple-init Class="btn btn-light btn-lg">Reset all</button>
                                        <Button type = "button" data-mdb-button-init data-mdb-ripple-init Class="btn btn-warning btn-lg ms-2">Submit form</button>
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



