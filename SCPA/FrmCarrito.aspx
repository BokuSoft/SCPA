<%@ Page Language="C#" MasterPageFile="~/MPGeneral.Master" AutoEventWireup="true" CodeBehind="FrmCarrito.aspx.cs" Inherits="SCPA.FrmCarrito" %>

<asp:Content ContentPlaceHolderID="cphPrincipal" runat="server">
    <asp:GridView ID="grdCarrito" CssClass="table table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
        <Columns>
            <asp:BoundField HeaderText="Producto" DataField="nombre" />
            <asp:TemplateField HeaderText="Precio">
                <ItemTemplate>
                    <%# double.Parse(Eval("precio").ToString()).ToString("C2") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
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
    <div class="text-right">
        <h3>
            <div class="text-right label label-warning">
                Total en el carrito:
            <asp:Label ID="lblTotal" runat="server" Text="$$$"></asp:Label>
            </div>
        </h3>
        <asp:Button CssClass="btn btn-success" ID="btnComprar" runat="server" Text="Para poder comprar necesitas iniciar sesion" OnClick="btnComprar_Click" />
    </div>
</asp:Content>
