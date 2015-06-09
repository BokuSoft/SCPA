<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministracion.Master" AutoEventWireup="true" CodeBehind="FrmCatalogoVentas.aspx.cs" Inherits="SCPA.FrmCatalogoVentas" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <title>Shonen: Catalogo de Ventas</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="cphLateral" runat="server">
    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-default" />
    <br />
    <asp:Button ID="btnClear" runat="server" Text="Limpiar Busqueda" CssClass="btn btn-default" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div class="panel panel-primary">
        <div class="panel-heading">
            Catalogo de Ventas
        </div>
        <div class="panel-body">
            <asp:GridView ID="grdVentas" runat="server" CssClass="table table-hover" AutoGenerateColumns="False" BorderWidth="0" OnRowCommand="grdVenta_RowCommand" >
                <Columns>
                    <asp:BoundField HeaderText="Id" DataField="Id" />
                    <asp:BoundField HeaderText="Fecha" DataField="fecha" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <%# double.Parse(Eval("total").ToString()).ToString("C2") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:ButtonField CommandName="Ver" Text="Ver">
                        <ControlStyle CssClass="btn btn-default"></ControlStyle>
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
