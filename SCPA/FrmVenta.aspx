<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministracion.Master" AutoEventWireup="true" CodeBehind="FrmVenta.aspx.cs" Inherits="SCPA.FrmVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphLateral" runat="server">
    <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-info" OnClick="btnRegresar_Click" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    ID: <asp:TextBox ID="txtID" runat="server" Enabled="false"></asp:TextBox>
    Fecha: <asp:TextBox ID="txtFecha" runat="server" Enabled="false"></asp:TextBox>
    <asp:GridView ID="grdDetalles" runat="server" CssClass="table table-condensed" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
