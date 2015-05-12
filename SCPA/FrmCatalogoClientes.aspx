<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministracion.Master" AutoEventWireup="true" CodeBehind="FrmCatalogoClientes.aspx.cs" Inherits="SCPA.FrmCatalogoClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphLateral" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Agregar" CssClass="btn btn-success" />
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="Buscar" CssClass="btn btn-default" />
    <br />
    <asp:Button ID="Button3" runat="server" Text="Limpiar Busqueda" CssClass="btn btn-default" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <h2>Catalogo de Clientes</h2>
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover">

    </asp:GridView>
</asp:Content>