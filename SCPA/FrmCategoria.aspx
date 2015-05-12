<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministracion.Master" AutoEventWireup="true" CodeBehind="FrmCategoria.aspx.cs" Inherits="SCPA.FrmCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphLateral" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Regresar" CssClass="btn btn-default" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Agregar Categoria"></asp:Label>
    <div class="form-group">
        <div class="col-sm-3"><label>Clave</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtID" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Nombre</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></div>
    </div>
    <asp:Button ID="Button2" runat="server" Text="Guardar" CssClass="btn btn-success" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
