<%@ Page Title="Shonen: Compras" Language="C#" MasterPageFile="~/MPAdministracion.Master" AutoEventWireup="true" CodeBehind="FrmCompra.aspx.cs" Inherits="SCPA.FrmCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphLateral" runat="server">
    <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-default" OnClick="btnRegresar_Click" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <script>
        $(document).ready(function () {
            $("#grid").hide();
            $("#grid").show("drop",3000);
        });
    </script>

    <h2>
        <asp:Label ID="lblTitulo" runat="server" Text="Registrar una nueva compra"></asp:Label>
    </h2>

    <div id="grid" style="display:inline-block;">
        <asp:GridView ID="grdListaCompras" runat="server" CssClass="table" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnRowDeleting="grdListaCompras_RowDeleting" OnRowUpdating="grdListaCompras_RowUpdating">
            <Columns>
                <asp:TemplateField></asp:TemplateField>
                <asp:ButtonField CommandName="update" Text="Actualizar" ControlStyle-CssClass="btn btn-warning" >
<ControlStyle CssClass="btn btn-warning"></ControlStyle>
                </asp:ButtonField>
                <asp:ButtonField CommandName="delete" Text="Eliminar" ControlStyle-CssClass="btn btn-danger" >
<ControlStyle CssClass="btn btn-danger"></ControlStyle>
                </asp:ButtonField>
            </Columns>
            <EmptyDataTemplate>
                No se han registrado Compras.
            </EmptyDataTemplate>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />

        </asp:GridView>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server">
        </asp:EntityDataSource>
    </div>

     <div id="formulario2" style="display:inline-block;" > 
        <div class="form-group">
            <div class="col-sm-3"><label>Producto:</label></div>
            <div class="col-sm-9" style="width:70%"><asp:DropDownList ID="cboProductos" CssClass="form-control" runat="server"></asp:DropDownList></div>
        </div>
        <br />
        <div class="form-group">
            <div class="col-sm-3"><label>Cantidad:</label></div>
            <div class="col-sm-9" style="width:40%"><asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control" Text="0.0" OnTextChanged="txtCantidad_TextChanged"></asp:TextBox></div>
        </div>
        <br />
         <div class="form-group">
            <div class="col-sm-3"><label>Precio:</label></div>
            <div class="col-sm-9" style="width:50%"><asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" Text="0.0" OnTextChanged="txtPrecio_TextChanged"></asp:TextBox></div>
        </div>
        <br />
         <div class="form-group">
            <div class="col-sm-3"><label>Total:</label></div>
            <div class="col-sm-9" style="width:50%"><asp:TextBox ID="txtTotal" runat="server" CssClass="form-control" Text="0.0" ReadOnly="true"></asp:TextBox></div>
        </div>
         <br />
         <div>
             <asp:Button ID="btnAccion" runat="server" CssClass="btn btn-info" Text="Agregar" OnClick="btnAccion_Click" />
         </div>         

        </div>
    <hr />
    <div>
             <asp:Button ID="btnGuardar" runat="server" Text="Listo" CssClass="btn btn-success" OnClick="btnGuardar_Click" />
         </div>
</asp:Content>
