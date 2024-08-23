<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-icons/1.10.5/font/bootstrap-icons.min.css">


    <style>
.navbar {
    border-radius: 0;
}

.navbar-inverse {
    background-color: #8e735b; 
    border-color: #8e735b;
}

.navbar-inverse .navbar-brand {
    color: #fff;
}

.navbar-inverse .navbar-nav > li > a {
    color: #fff;
}

.navbar-inverse .navbar-toggle {
    border-color: #fff;
}

.navbar-inverse .navbar-toggle .icon-bar {
    background-color: #fff;
}

.navbar-form .form-control {
    display: inline-block;
    width: auto;
    vertical-align: middle;
}

.navbar-form .icon {
    width: 24px;
    height: 24px;
    margin-left: 10px;
}


.navbar-nav > li > a {
    color: #fff; 
    padding: 15px 20px; 
    text-decoration: none; 
    transition: background-color 0.3s, color 0.3s, transform 0.3s; 
    display: inline-block; 
}


.navbar-nav > li > a:hover {
    background-color: #6c4f3d;
    color: #fff; 
    transform: scale(1.5); 
}


.navbar-nav > .active > a {
    background-color: #6c4f3d; 
    color: #fff; 
}

.icon {
    font-size: 24px;
    color: #fff; 
    transition: color 0.3s, transform 0.3s; 
}

.icon:hover {
    color: #6c4f3d; 
    transform: scale(1.2); 
}



    </style>
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="#">Logo da Empresa</a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("Material", "Index", "MaterialMovels")</li>
                    <li>@Html.ActionLink("Pedidos", "Index", "MovelPedidos")</li>
                    <li>@Html.ActionLink("Fornecedores", "Index", "Fornecedors")</li>
                </ul>
                @Html.Partial("_LoginPartial")
                <div class="navbar-form navbar-right">
                    <input type="text" class="form-control" placeholder="Buscar produtos...">
                    <a href="#cart"><i class="bi bi-cart icon"></i></a>
                </div>
            </div>
        </div>
    </div>

    <div class="content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
