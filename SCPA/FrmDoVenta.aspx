<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneralSinLateral.Master" AutoEventWireup="true" CodeBehind="FrmDoVenta.aspx.cs" Inherits="SCPA.FrmDoVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphNav" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div class="col-md-3">
    </div>
    <div class="col-md-6">
        <div class="panel panel-danger text-center">
            <div class="panel-heading">
                <asp:Label ID="Label1" runat="server" Text="Finzalizar Compra"></asp:Label>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <div class="col-sm-3">
                        <label>Ingresa tu numero de Tarjeta</label>
                    </div>
                    <div class="col-sm-9">
                        <asp:TextBox CssClass="form-control" ID="txtTarjeta" runat="server"></asp:TextBox>
                    </div>
                </div>
                <asp:Button ID="btnCompletar" runat="server" Text="Completar compra" CssClass="btn btn-success" OnClick="btnCompletar_Click"/>
            </div>
        </div>
    </div>
    <div class="col-md-3">
    </div>
</asp:Content>
