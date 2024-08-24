<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css/css")
    @Scripts.Render("~/bundles/modernizr")
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-icons/1.10.5/font/bootstrap-icons.min.css">
    <!-- Font Awesome -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css"
          rel="stylesheet" />
    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap"
          rel="stylesheet" />
    <!-- MDB -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/7.3.2/mdb.min.css"
          rel="stylesheet" />

</head>
<body>
    @*<div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="#">Logo</a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("Material", "Index", "MaterialMovels")</li>
                    <li>@Html.ActionLink("Orders", "Index", "MovelPedidos")</li>
                    <li>@Html.ActionLink("Suppliers", "Index", "Fornecedors")</li>
                </ul>
                @Html.Partial("_LoginPartial")
                <div class="navbar-form navbar-right">
                    <input type="text" class="form-control" placeholder="Search products...">
                    <a href="#cart"><i class="bi bi-cart icon"></i></a>
                </div>
            </div>
        </div>
    </div>*@

    <!-- Navbar -->
    <header>
        <nav class="navbar navbar-expand-lg navbar-dark d-none d-lg-block" style="z-index: 2000; background-color: #5c4033; color: #f0e6d6; border-bottom: 1px solid #4a2c1c;">
            <div class="container-fluid">
                <!-- Navbar brand -->
                <a class="navbar-brand nav-link" target="_blank" href="https://mdbootstrap.com/docs/standard/">
                    <strong>LOGO</strong>
                </a>
                <button class="navbar-toggler" type="button" data-mdb-collapse-init data-mdb-target="#navbarExample01"
                        aria-controls="navbarExample01" aria-expanded="false" aria-label="Toggle navigation">
                    <i class="fas fa-bars"></i>
                </button>
                <div class="collapse navbar-collapse" id="navbarExample01">
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                        <li class="nav-item">
                            <a class="nav-link" href="@Url.Action("Index", "Home")">Home</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="@Url.Action("Index", "MaterialMovels")">Material</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="@Url.Action("Index", "MovelPedidos")">Orders</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="@Url.Action("Index", "Fornecedors")">Suppliers</a>
                        </li>
                    </ul>

                    <ul class="navbar-nav list-inline">
                        @Html.Partial("_LoginPartial")
                        <!-- Icons -->
                        <li class="">
                            <a class="nav-link" href="https://www.youtube.com/channel/UC5CF7mLQZhvx8O5GODZAhdA" rel="nofollow"
                               target="_blank">
                                <i class="fab fa-youtube"></i>
                            </a>
                        </li>
                        <li class="">
                            <a class="nav-link" href="https://www.facebook.com/mdbootstrap" rel="nofollow" target="_blank">
                                <i class="fab fa-facebook-f"></i>
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="https://twitter.com/MDBootstrap" rel="nofollow" target="_blank">
                                <i class="fab fa-twitter"></i>
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="https://github.com/mdbootstrap/mdb-ui-kit" rel="nofollow" target="_blank">
                                <i class="fab fa-github"></i>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>
    <!-- Navbar -->

        <div>
            @RenderBody()
            <hr />
            <footer>
                <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
            </footer>
        </div>


        @*@Scripts.Render("~/bundles/jquery")
            @Scripts.Render("~/bundles/bootstrap")*@
        @RenderSection("scripts", required:=False)
        <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/7.3.2/mdb.umd.min.js"></script>
</body>
</html>
