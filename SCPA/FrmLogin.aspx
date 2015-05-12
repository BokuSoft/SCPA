<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneral.Master" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="SCPA.FrmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphNav" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphLateral" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphPrincipal" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Iniciar Sesión"></asp:Label>
    <div class="form-group">
        <div class="col-sm-3"><label>Clave</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtID" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Nombre</label></div>
        <div class="col-sm-9"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></div>
    </div>
    <asp:Button ID="Button2" runat="server" Text="Guardar" CssClass="btn btn-success" />
</asp:Content>

<%-- LOL --%>