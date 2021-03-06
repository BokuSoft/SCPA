﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneralSinLateral.Master" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="SCPA.FrmLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphNav" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphPrincipal" runat="server">
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
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-3">
                        <label>Password</label>
                    </div>
                    <div class="col-sm-9">
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
                <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" CssClass="btn btn-success" OnClick="btnLogin_Click" />
            </div>
        </div>
        <div class="text-center">
            <a class="btn btn-primary" href="FrmRegistroUsuario.aspx">¿No tienes cuenta? ¡Registrate!</a>
        </div>
    </div>
    <div class="col-md-4">
    </div>
</asp:Content>

<%-- LOL --%>