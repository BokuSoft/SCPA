<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneral.Master" AutoEventWireup="true" CodeBehind="FrmProducto.aspx.cs" Inherits="SCPA.FrmProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLateral" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">
            Menú
        </div>
        <div class="panel-body">
            <asp:button id="btnGuardar" runat="server" text="Guardar" cssclass="btn btn-success btn-block" onclick="btnGuardar_Click" />
            <asp:button id="btnCancelar" runat="server" text="Cancelar" cssclass="btn btn-danger btn-block" onclick="btnCancelar_Click" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPrincipal" runat="server">
    <asp:label id="lblTitulo" runat="server" text="Agregar Producto"></asp:label>
    <div class="form-group">
        <div class="col-sm-3">
            <label>ID</label>
        </div>
        <div class="col-sm-9">
            <asp:textbox id="txtID" runat="server" CssClass="form-control"></asp:textbox>
        </div>
    </div>
    <div class="form-group">
        <div class="col-sm-3">
            <label>Nombre</label>
        </div>
        <div class="col-sm-9">
            <asp:textbox id="txtNombre" runat="server" CssClass="form-control"></asp:textbox>
        </div>
    </div>
    <div class="form-group">
        <div class="col-sm-3">
            <label>Precio</label>
        </div>
        <div class="col-sm-9">
            <asp:textbox id="txtPrecio" runat="server" CssClass="form-control"></asp:textbox>
        </div>
    </div>
    <div class="form-group">
        <div class="col-sm-3">
            <label>Cantidad</label>
        </div>
        <div class="col-sm-9">
            <asp:textbox id="txtCantidad" runat="server" CssClass="form-control"></asp:textbox>
        </div>
    </div>
    <div class="form-group">
        <div class="col-xs-3">
            <label>Proveedor</label>
        </div>
        <div class="col-xs-9">
            <asp:dropdownlist runat="server" id="ddlProveedor" DataTextField="nombre" DataValueField="Id"></asp:dropdownlist>
        </div>
    </div>
    <div class="form-group">
        <div class="col-xs-3">
            <label>Categoría</label>
        </div>
        <div class="col-xs-9">
            <asp:dropdownlist runat="server" DataTextField="nombre" DataValueField="Id" id="ddlCategoria"></asp:dropdownlist>
        </div>
    </div>
    <div class="form-group">
        <div class="col-sm-3">
            <label>Descontinuado</label>
        </div>
        <div class="col-sm-9">
            <asp:checkbox id="chkDescontinuado" runat="server" />
        </div>
    </div>
</asp:Content>
