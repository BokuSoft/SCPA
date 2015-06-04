using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmCatalogoProductos : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) return;
            validarLoad();
            cargarLista();
        }

        private void validarLoad() {
            
        }

        private void cargarLista() {
            producto p = new producto();
            List<producto> listaProductos = p.GetAllproducto();
            grdProductos.DataSource = listaProductos;
            grdProductos.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e) {
            Response.Redirect("FrmProducto.aspx");
        }

        protected void grdProductos_RowCommand(object sender, GridViewCommandEventArgs e) {
            if (e.CommandName.Equals("Ver")) {
                int rowIndex = int.Parse(e.CommandArgument.ToString());
                int id = int.Parse(grdProductos.Rows[rowIndex].Cells[0].Text);
                Response.Redirect("FrmProducto.aspx?q=ver&id=" + id);
            }
        }

        protected void grdProductos_RowDeleting(object sender, GridViewDeleteEventArgs e) {
            int id = int.Parse(grdProductos.Rows[e.RowIndex].Cells[0].Text);
            producto.Delete(id);
        }

        protected void grdProductos_RowUpdating(object sender, GridViewUpdateEventArgs e) {
            int id = int.Parse(grdProductos.Rows[e.RowIndex].Cells[0].Text);
            Response.Redirect("FrmProducto.aspx?q=update&id=" + id);
        }
    }
}