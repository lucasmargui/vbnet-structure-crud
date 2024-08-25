﻿<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>

    <!-- To include bootstrap when creating the project -->
    @*@Styles.Render("~/Content/css")*@
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

    <link rel="stylesheet" href="https://cdn.datatables.net/2.1.4/css/dataTables.dataTables.css" />

</head>
<body>

    <!-- Navbar -->
    <header>
        <nav class="navbar navbar-expand-lg navbar-dark d-none d-lg-block" style="z-index: 2000; background-color: #5c4033; color: #f0e6d6; border-bottom: 1px solid #4a2c1c;">
            <div class="container-fluid">
                <!-- Navbar brand -->
                <a class="navbar-brand nav-link" target="_blank" href="">
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
                            <a class="nav-link" href="" rel="nofollow"
                               target="_blank">
                                <i class="fab fa-youtube"></i>
                            </a>
                        </li>
                        <li class="">
                            <a class="nav-link" href="" rel="nofollow" target="_blank">
                                <i class="fab fa-facebook-f"></i>
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="" rel="nofollow" target="_blank">
                                <i class="fab fa-twitter"></i>
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="" rel="nofollow" target="_blank">
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

     @Scripts.Render("~/bundles/jquery")
     @Scripts.Render("~/bundles/bootstrap")

    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/7.3.2/mdb.umd.min.js"></script>

    <script src="https://cdn.datatables.net/2.1.4/js/dataTables.js"></script>

    <script>
        $(document).ready(function () {
            $('#table').DataTable({});
        });

    </script>

    @RenderSection("scripts", required:=False)

</body>
</html>
