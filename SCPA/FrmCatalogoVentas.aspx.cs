using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmCatalogoVentas : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            venta c = new venta();
            List<venta> listaVentas = c.GetAllventa();

            grdVentas.DataSource = listaVentas;
            grdVentas.DataBind();
        }

        public void cargarLista() {
            venta c = new venta();
            List<venta> listaCategorias = c.GetAllventa();
            grdVentas.DataSource = listaCategorias;
            grdVentas.DataBind();
        }

        protected void grdVenta_RowCommand(object sender, GridViewCommandEventArgs e) {
            if (e.CommandName.Equals("Ver")) {
                int rowIndex = int.Parse(e.CommandArgument.ToString());
                int id = int.Parse(grdVentas.Rows[rowIndex].Cells[0].Text);
                Response.Redirect("FrmVenta.aspx?q=ver&id=" + id);
            }
        }
    }
}