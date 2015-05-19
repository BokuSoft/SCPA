<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneral.Master" AutoEventWireup="true" CodeBehind="FrmVerProductos.aspx.cs" Inherits="SCPA.FrmVerProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Shonen: Productos</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLateral" runat="server">
    <div class="list-group">
        <div class="list-group-item active">
            <h4 class="list-group-item-heading">Menu Lateral</h4>
        </div>
        <div class="list-group-item">Categoria A</div>
        <div class="list-group-item">Categoria B</div>
        <div class="list-group-item">Categoria C</div>
        <div class="list-group-item">Categoria D</div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div class="row">
        <div class="col-md-4">
            <div class="thumbnail">
                <img src="img/Emily-4.jpg" />
                <div class="caption">
                    <h3>Producto A</h3>
                    <p>$59.90</p>
                </div>
            </div>
        </div>
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
        </div>
        <asp:ListView ID="lsvProductos" runat="server">

        </asp:ListView>
    </div>
</asp:Content>
