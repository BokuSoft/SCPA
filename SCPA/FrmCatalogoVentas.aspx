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
            <asp:GridView ID="grdVentas" runat="server" CssClass="table table-hover" AutoGenerateColumns="False" BorderWidth="0" OnRowCommand="grdCategorias_RowCommand" OnRowDeleting="grdCategorias_RowDeleting" OnRowUpdating="grdCategorias_RowUpdating">
                <Columns>
                    <asp:BoundField HeaderText="Id" DataField="Id" />
                    <asp:BoundField HeaderText="Cliente" DataField="idCliente" />
                    <asp:BoundField HeaderText="Usuario" DataField="idUsuario" />
                    <asp:BoundField HeaderText="Sucursal" DataField="idSucursal" />
                    <asp:BoundField HeaderText="Fecha" DataField="fecha" />
                    <asp:BoundField HeaderText="Total" DataField="total" />
                    <asp:ButtonField CommandName="Update" Text="Modificar">
                        <ControlStyle CssClass="btn btn-warning"></ControlStyle>
                    </asp:ButtonField>
                    <asp:ButtonField CommandName="Delete" Text="Eliminar">
                        <ControlStyle CssClass="btn btn-danger"></ControlStyle>
                    </asp:ButtonField>
                    <asp:ButtonField CommandName="Ver" Text="Ver">
                        <ControlStyle CssClass="btn btn-default"></ControlStyle>
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
