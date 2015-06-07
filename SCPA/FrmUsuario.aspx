<%@ Page Title="Shonen: Usuario" Language="C#" MasterPageFile="~/MPAdministracion.Master" AutoEventWireup="true" CodeBehind="FrmUsuario.aspx.cs" Inherits="SCPA.FrmUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphLateral" runat="server">
    <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-default" OnClick="btnRegresar_Click" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <h2>
        <asp:Label ID="lblTitulo" runat="server" Text="Agregar Usuario"></asp:Label>
    </h2>
    <div class="form-group">
        <div class="col-sm-3"><label>ID</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtID" runat="server" ReadOnly="true"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Nombre</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Apellidos</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox></div>
    </div>
    <br />
    <div class="form-group">
        <div class="col-sm-3"><label>Fecha de Nacimiento</label></div>
        <div class="col-sm-9">
            Dia<asp:DropDownList ID="ddlDia" runat="server" CssClass="form-control" Width="40%">
            </asp:DropDownList>
            Mes<asp:DropDownList ID="ddlMes" runat="server" CssClass="form-control" Width="40%">
            </asp:DropDownList>
            Año<asp:DropDownList ID="ddlAnio" runat="server" CssClass="form-control" Width="40%">
            </asp:DropDownList>
        </div>
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
    <div class="form-group">
        <div class="col-sm-3"><label>Tipo de usuario</label></div>
        <div class="col-sm-9">
            <asp:DropDownList ID="ddlTipoUsuario" runat="server" CssClass="form-control" Width="40%"></asp:DropDownList>
        </div>
    </div>
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" />
</asp:Content>
