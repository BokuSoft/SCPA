<%@ Page Language="C#" MasterPageFile="~/MPGeneral.Master" AutoEventWireup="true" CodeBehind="FrmCarrito.aspx.cs" Inherits="SCPA.FrmCarrito" %>

<asp:Content ContentPlaceHolderID="cphPrincipal" runat="server">
    <asp:GridView ID="grdCarrito" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField HeaderText="Producto" />
            <asp:BoundField HeaderText="Cantidad" />
            <asp:BoundField HeaderText="Costo Unitario" />
            <asp:BoundField HeaderText="Importe" />
        </Columns>
    </asp:GridView>
</asp:Content>