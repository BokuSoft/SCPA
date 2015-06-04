<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneral.Master" AutoEventWireup="true" CodeBehind="FrmVerProductos.aspx.cs" Inherits="SCPA.FrmVerProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Shonen: Productos</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLateral" runat="server">
    <div class="list-group">
        <div class="list-group-item active">
            <h4 class="list-group-item-heading">Menu Lateral</h4>
        </div>
        <asp:ListView ID="lsvCategorias" runat="server">
            <ItemTemplate>
                <a href="FrmVerProductos.aspx?cid=<%# Eval("Id") %>">
                    <div class="list-group-item"><%# Eval("nombre") %></div>
                </a>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPrincipal" runat="server">
    <asp:ListView ID="lsvProductos" runat="server" OnItemCommand="lsvProductos_ItemCommand">
        <ItemTemplate>
            <div class="col-md-4">
                <div class="thumbnail">
                    <img src="img/Emily-4.jpg" />
                    <div class="caption">
                        <h3><%# Eval("nombre") %></h3>
                        <p>$<%# Eval("precio") %></p>
                        <asp:LinkButton CommandName="Add" CommandArgument='<%# Eval("Id") %>' runat="server" CssClass="btn btn-danger">
                            Agregar al carrito
                        </asp:LinkButton>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
