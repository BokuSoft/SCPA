<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministracion.Master" AutoEventWireup="true" CodeBehind="FrmCategoria.aspx.cs" Inherits="SCPA.FrmCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphLateral" runat="server">
    <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-default" OnClick="btnRegresar_Click" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <asp:Label ID="lblTitulo" runat="server" Text="Agregar Categoria"></asp:Label>
        </div>
        <div class="panel-body">
            <div class="form-group">
                <div class="col-sm-3">
                    <label>Clave</label>
                </div>
                <div class="col-sm-9">
                    <asp:TextBox CssClass="form-control" ID="txtID" runat="server" Enabled="False"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-3">
                    <label>Nombre</label>
                </div>
                <div class="col-sm-9">
                    <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server"></asp:TextBox>
                </div>
            </div>
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
