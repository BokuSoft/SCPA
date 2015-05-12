<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministracion.Master" AutoEventWireup="true" CodeBehind="FrmSucursal.aspx.cs" Inherits="SCPA.FrmSucursal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphLateral" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Regresar" CssClass="btn btn-default" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Registrar una nueva sucursal"></asp:Label>
    <div class="form-group">
        <div class="col-sm-3"><label>ID</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtID" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Nombre</label></div>
        <div class="col-sm-9"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Jefe</label></div>
        <div class="col-sm-9"><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Dirección</label></div>
        <div class="col-sm-9"><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Ciudad</label></div>
        <div class="col-sm-9"><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Teléfono</label></div>
        <div class="col-sm-9"><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></div>
    </div>
    <asp:Button ID="Button2" runat="server" Text="Guardar" CssClass="btn btn-success" />
</asp:Content>
