<%@ Page Language="C#" MasterPageFile="~/MPGeneral.Master" AutoEventWireup="true" CodeBehind="FrmCarrito.aspx.cs" Inherits="SCPA.FrmCarrito" %>

<asp:Content ContentPlaceHolderID="cphPrincipal" runat="server">
    <asp:GridView ID="grdCarrito" CssClass="table table-hover" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField HeaderText="Producto" DataField="nombre" />
            <asp:BoundField HeaderText="Precio" DataField="precio" />
        </Columns>
    </asp:GridView>
    <div class="text-right">
        <h3>
            <div class="text-right label label-warning">
                Total en el carrito:
            <asp:Label ID="lblTotal" runat="server" Text="$$$"></asp:Label>
            </div>
        </h3>
        <asp:Button CssClass="btn btn-success" ID="btnComprar" runat="server" Text="Para poder comprar necesitas iniciar sesion" OnClick="btnComprar_Click" />
    </div>
</asp:Content>
