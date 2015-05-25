<%@ Page Title="Shonen: Proveedores" Language="C#" MasterPageFile="~/MPAdministracion.Master" AutoEventWireup="true" CodeBehind="FrmCatalogoProveedores.aspx.cs" Inherits="SCPA.FrmCatalogoProveedores" %>



<asp:Content ID="Content1" ContentPlaceHolderID="cphLateral" runat="server">
    <div class="row" >
        <div class="col-lg-12">
            <div class="input-group">
                
                <span class="input-group-btn">
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-default" OnClick="btnBuscar_Click"/>
                </span>

                <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" placeholder="Nombre Proveedor" Width="100%"/>
            </div>
        </div>
    </div>
    <div>
        <asp:Button ID="btnLimpiarBusqueda" runat="server" Text="Limpiar Busqueda" CssClass="btn btn-info" OnClick="btnLimpiarBusqueda_Click"/>
    </div>
    <br />
    <div>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="btnAgregar_Click" />
    </div>
</asp:Content>

      

<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <h2>Catalogo de Proveedores</h2>
         

        <asp:GridView ID="grdListaProveedores" runat="server" CssClass="table" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnRowDeleting="grdListaProveedores_RowDeleting" OnRowUpdating="grdListaProveedores_RowUpdating">
            <Columns>
                <asp:TemplateField></asp:TemplateField>
                <asp:BoundField DataField="nombre" HeaderText="nombre" />
                <asp:BoundField DataField="nombreJefe" HeaderText="nombreJefe" />
                <asp:BoundField DataField="direccion" HeaderText="direccion" />
                <asp:BoundField DataField="ciudad" HeaderText="ciudad" />
                <asp:BoundField DataField="telefono" HeaderText="telefono" />
                <asp:ButtonField CommandName="update" Text="Actualizar" ControlStyle-CssClass="btn btn-warning" >
    <ControlStyle CssClass="btn btn-warning"></ControlStyle>
                </asp:ButtonField>
                <asp:ButtonField CommandName="delete" Text="Eliminar" ControlStyle-CssClass="btn btn-danger" >
    <ControlStyle CssClass="btn btn-danger"></ControlStyle>
                </asp:ButtonField>
            </Columns>
            <EmptyDataTemplate>
                No se encontraron registros.
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
</asp:Content>
