<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneralSinLateral.Master" AutoEventWireup="true" CodeBehind="FrmPrincipal.aspx.cs" Inherits="SCPA.FrmPrincipal" %>


<%-- <asp:Content ContentPlaceHolderID="cphLateral" runat="server">
    <div class="list-group">
        <div class="list-group-item active">
            <h4 class="list-group-item-heading">Menu Lateral</h4>
        </div>
        <div class="list-group-item">Categoria A</div>
        <div class="list-group-item">Categoria B</div>
        <div class="list-group-item">Categoria C</div>
        <div class="list-group-item">Categoria D</div>
    </div>
</asp:Content> --%>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Shonen Online</title>
</asp:Content>

<asp:Content ID="cphPrincipalI" ContentPlaceHolderID="cphPrincipal" runat="server">
    <!-- Carousel
    ================================================== -->
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <img class="first-slide" src="img/c_1.png" alt="First slide">
                <div class="container">
                    <div class="carousel-caption">
                        <h1>Example headline.</h1>
                        <p>Note: If you're viewing this page via a <code>file://</code> URL, the "next" and "previous" Glyphicon buttons on the left and right might not load/display properly due to web browser security rules.</p>
                        <p><a class="btn btn-lg btn-primary" href="#" role="button">Sign up today</a></p>
                    </div>
                </div>
            </div>
            <div class="item">
                <img class="second-slide" src="img/c_2.png" alt="Second slide">
                <div class="container">
                    <div class="carousel-caption">
                        <h1>Another example headline.</h1>
                        <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                        <p><a class="btn btn-lg btn-primary" href="#" role="button">Learn more</a></p>
                    </div>
                </div>
            </div>
            <div class="item">
                <img class="third-slide" src="img/c_3.png" alt="Third slide">
                <div class="container">
                    <div class="carousel-caption">
                        <h1>One more for good measure.</h1>
                        <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                        <p><a class="btn btn-lg btn-primary" href="#" role="button">Browse gallery</a></p>
                    </div>
                </div>
            </div>
        </div>
        <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
    <!-- /.carousel -->

    <div class="page-header">
        <h1 class="text-center">Novedades</h1>
    </div>
    <div class="row">
        <div class="col-md-3">
            <div class="thumbnail">
                <img src="img/Emily-4.jpg" />
                <div class="caption">
                    <h3>Producto A</h3>
                    <p>$59.90</p>
                </div>
            </div>
        </div>
    </div>
    <div class="page-header">
        <h1 class="text-center">Populares</h1>
    </div>

    <div class="page-header">
        <h1 class="text-center">Ofertas</h1>
    </div>
</asp:Content>
