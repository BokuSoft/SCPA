<%@ Page Title="Shonen: Usuarios" Language="C#" MasterPageFile="~/MPAdministracion.Master" AutoEventWireup="true" CodeBehind="FrmCatalogoUsuarios.aspx.cs" Inherits="SCPA.FrmCatalogoUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphLateral" runat="server">
    <div class="row" >
        <div class="col-lg-12">
            <div class="input-group">
                <span class="input-group-btn">
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-default" OnClick="btnBuscar_Click"/>
                </span>
                <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" placeholder="Nombre Sucursal" Width="100%"/>   
            </div>
        </div>
    </div>
    <div>
        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar Busqueda" CssClass="btn btn-info" OnClick="btnLimpiar_Click" />
    </div>
    <br />
    <div>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="btnAgregar_Click" />
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
     <script>
        $(document).ready(function () {
            $("#grid").hide();
            $("#grid").show("drop",3000);
        });
    </script>

    <h2>Catalogo de Usuarios</h2>

    <div id="grid">
        <asp:GridView ID="grdListaUsuarios" runat="server" CssClass="table" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnRowDeleting="grdListaUsuarios_RowDeleting" OnRowUpdating="grdListaUsuarios_RowUpdating">
            <Columns>
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                <asp:BoundField DataField="direccion" HeaderText="Direccion" />
                <asp:BoundField DataField="ciudad" HeaderText="Ciudad" />
                <asp:BoundField DataField="fechaNacimiento" HeaderText="FechaNacimiento" />
                <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                <asp:BoundField DataField="tipoUsuario" HeaderText="TipoUsuario" />
                <asp:ButtonField CommandName="update" Text="Actualizar" ControlStyle-CssClass="btn btn-warning" />
                <asp:ButtonField CommandName="delete" Text="Eliminar" ControlStyle-CssClass="btn btn-danger" />
                <asp:TemplateField></asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                No se encontraron registros de Usuarios
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
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
