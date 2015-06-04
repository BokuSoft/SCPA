<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneralSinLateral.Master" AutoEventWireup="true" CodeBehind="FrmRegistroUsuario.aspx.cs" Inherits="SCPA.FrmRegistroUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Registrar usuario</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphNav" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div class="col-md-4">
    </div>
    <div class="col-md-4">
        <div class="panel panel-danger text-center">
            <div class="panel-heading">
                <asp:Label ID="Label1" runat="server" Text="Iniciar Sesión"></asp:Label>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <div class="col-sm-3">
                        <label>Nombre</label>
                    </div>
                    <div class="col-sm-9">
                        <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-3">
                        <label>Apellidos</label>
                    </div>
                    <div class="col-sm-9">
                        <asp:TextBox CssClass="form-control" ID="txtApellidos" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-3">
                        <label>Direccion</label>
                    </div>
                    <div class="col-sm-9">
                        <asp:TextBox CssClass="form-control" ID="txtDireccion" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-3">
                        <label>Ciudad</label>
                    </div>
                    <div class="col-sm-9">
                        <asp:TextBox CssClass="form-control" ID="txtCiudad" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-3">
                        <label>Telefono</label>
                    </div>
                    <div class="col-sm-9">
                        <asp:TextBox CssClass="form-control" ID="txtTelefono" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-3">
                        <label>Fecha de Nac.</label>
                    </div>
                    <div class="col-sm-9">
                        <asp:TextBox CssClass="form-control" ID="txtNacimiento" runat="server"></asp:TextBox>
                    </div>
                </div>
                <asp:Button ID="btnRegistro" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="btnRegistro_Click" />
            </div>
        </div>
    </div>
    <div class="col-md-4">
    </div>
</asp:Content>
