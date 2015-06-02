<%@ Page Title="Shonen: Contacto" Language="C#" MasterPageFile="~/MPGeneral.Master" AutoEventWireup="true" CodeBehind="FrmContacto.aspx.cs" Inherits="SCPA.FrmContacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphNav" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphLateral" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div style="width:70%;text-align:center" class="panel panel-success">
        <div class="panel-heading" >
            <h2>Información del contacto</h2>
        </div>
        <div class="panel-body" >
            <figure class="img-responsive">
                <a href="FrmPrincipal.aspx" class="table-hover">
                    <img src="img/banner.png" style="display:inline-block;"class="img-responsive" />
                </a>
                <a href="http://www.mahousoft.com" class="table-hover">
                    <img src="img/MahouSoft.png" style="display:inline-block" class="img-responsive"/>
                </a>
            </figure>
        </div>
        <div class="panel-footer">
            <p>
                Shonen Web Page<br/>
                Version 1.0<br/>
                © 2015 MahouSoft<br />
                Todos los derechos reservados.
            </p>
        </div>
    </div>
</asp:Content>
