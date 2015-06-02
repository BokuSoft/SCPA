<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministracion.Master" AutoEventWireup="true" CodeBehind="FrmCatalogoProductos.aspx.cs" Inherits="SCPA.FrmCatalogoProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLateral" runat="server">

    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="btnAgregar_Click" />
    <br />
    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-default" />
    <br />
    <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar Busqueda" CssClass="btn btn-default" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPrincipal" runat="server">

    <h2>Catalogo de Productos</h2>
    <asp:GridView ID="grdProductos" runat="server" CssClass="table table-hover" AutoGenerateColumns="False" OnRowCommand="grdProductos_RowCommand" OnRowDeleting="grdProductos_RowDeleting" OnRowUpdating="grdProductos_RowUpdating">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID" />
            <asp:BoundField DataField="idCategoria" HeaderText="Categoria" />
            <asp:BoundField DataField="idProveedor" HeaderText="Proveedor" />
            <asp:BoundField DataField="nombre" HeaderText="Descripción" />
            <asp:BoundField DataField="cantidad" HeaderText="Unidades en Existencia" />
            <asp:BoundField DataField="precio" HeaderText="Precio" />
            <asp:BoundField DataField="descontinuado" HeaderText="Esta descontinuado?" />

            <asp:ButtonField CommandName="Update" Text="Modificar">
                <ControlStyle CssClass="btn btn-warning"></ControlStyle>
            </asp:ButtonField>
            <asp:ButtonField CommandName="Delete" Text="Eliminar">
                <ControlStyle CssClass="btn btn-danger"></ControlStyle>
            </asp:ButtonField>
            <asp:ButtonField CommandName="Ver" Text="Ver">
                <ControlStyle CssClass="btn btn-default"></ControlStyle>
            </asp:ButtonField>
        </Columns>

    </asp:GridView>

</asp:Content>
