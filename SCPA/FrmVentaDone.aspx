<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneralSinLateral.Master" AutoEventWireup="true" CodeBehind="FrmVentaDone.aspx.cs" Inherits="SCPA.FrmVentaDone" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Venta Finalizada</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphNav" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-6">
                <div class="panel panel-success">
                    <div class="panel-heading">
                        Finzalizada!
                    </div>
                    <div class="panel-body">
                        <div class="text-center">
                            <img src="img/imgOK.png" />
                            <h2>Ya compraste</h2>
                        </div>
                        <div class="text-center">
                            ¡Gracias por comprar en Shonen!
                        </div>
                        <div class="text-center">
                            <asp:Button CssClass="btn btn-info" ID="btnVolver" runat="server" Text="Regresar al Catálogo" OnClick="btnVolver_Click" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-3"></div>


        </div>
    </div>
</asp:Content>
