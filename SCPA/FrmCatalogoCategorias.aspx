<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministracion.Master" AutoEventWireup="true" CodeBehind="FrmCatalogoCategorias.aspx.cs" Inherits="SCPA.FrmCatalogoCategorias" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <title>Shonen: Catalogo de Categorias</title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphLateral" runat="server">
    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="btnAgregar_Click" />
    <br />
    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-default" />
    <br />
    <asp:Button ID="btnClear" runat="server" Text="Limpiar Busqueda" CssClass="btn btn-default" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <h2>Catalogo de Categorias</h2>
    <asp:GridView ID="grdCategorias" runat="server" CssClass="table table-hover">
    </asp:GridView>
</asp:Content>