<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneral.Master" AutoEventWireup="true" CodeBehind="FrmProducto.aspx.cs" Inherits="SCPA.FrmProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLateral" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">
            Menú
        </div>
        <div class="panel-body">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success btn-block" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger btn-block" OnClick="btnCancelar_Click" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPrincipal" runat="server">
    <asp:Label ID="lblTitulo" runat="server" Text="Agregar Producto"></asp:Label>
    <div class="form-group">
        <div class="col-sm-3"><label>ID</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtID" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Nombre</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Precio</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Cantidad</label></div>
        <div class="col-sm-9"><asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox></div>
    </div>
    <div class="form-group">
        <div class="col-sm-3"><label>Descontinuado</label></div>
        <div class="col-sm-9">
            <asp:CheckBox ID="chkDescontinuado" runat="server" />
        </div>
    </div>
</asp:Content>
