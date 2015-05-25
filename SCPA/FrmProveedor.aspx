<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministracion.Master" AutoEventWireup="true" CodeBehind="FrmProveedor.aspx.cs" Inherits="SCPA.FrmProveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphLateral" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Regresar" CssClass="btn btn-default" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <h2><b>Agregar Proveedor</b></h2>
    <div class="form-group">
        <div class="col-sm-3"><label>Nombre</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Jefe</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtJefe" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Dirección</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Ciudad</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Teléfono</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></div>
    </div>
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" />
</asp:Content>
