<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneralSinLateral.Master" AutoEventWireup="true" CodeBehind="FrmRegistroUsuario.aspx.cs" Inherits="SCPA.FrmRegistroUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Registrar usuario</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphNav" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div class="col-md-2">
    </div>
    <div class="col-md-8">
        <div class="panel panel-danger">
            <div class="panel-heading">
                <asp:Label ID="Label1" runat="server" Text="Introduce tus datos para registrarte"></asp:Label>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <div class="col-sm-3">
                        <label>Nombre</label></div>
                    <div class="col-sm-9">
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></div>
                </div>
                <div class="form-group">
                    <div class="col-sm-3">
                        <label>Apellidos</label></div>
                    <div class="col-sm-9">
                        <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox></div>
                </div>
                <br />
                <div class="form-group">
                    <div class="col-sm-3">
                        <label>Fecha de Nacimiento</label></div>
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
                    <div class="col-sm-3">
                        <label>Dirección</label></div>
                    <div class="col-sm-9">
                        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox></div>
                </div>
                <div class="form-group">
                    <div class="col-sm-3">
                        <label>Ciudad</label></div>
                    <div class="col-sm-9">
                        <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox></div>
                </div>
                <div class="form-group">
                    <div class="col-sm-3">
                        <label>Teléfono</label></div>
                    <div class="col-sm-9">
                        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></div>
                </div>
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" />
            </div>
        </div>
    </div>
    <div class="col-md-2">
    </div>
</asp:Content>
