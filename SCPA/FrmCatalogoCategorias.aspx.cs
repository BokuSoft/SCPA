using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmCatalogoCategorias : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            //categoria c = new categoria();
            //List<categoria> listaCategorias = c.GetAllcategoria();

            categoria a = new categoria();
            a.Id = 1;
            a.nombre = "Cartas de Yu-gi-oh";

            categoria b = new categoria();
            b.Id = 2;
            b.nombre = "Lolis";

            List<categoria> listaCategorias = new List<categoria>();
            listaCategorias.Add(a);
            listaCategorias.Add(b);

            grdCategorias.DataSource = listaCategorias;
            grdCategorias.DataBind();
        }

        public void cargarLista() {
            categoria c = new categoria();
            List<categoria> listaCategorias = c.GetAllcategoria();
            grdCategorias.DataSource = listaCategorias;
            grdCategorias.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e) {
            Response.Redirect("FrmCategoria.aspx");
        }

        protected void grdCategorias_RowUpdating(object sender, GridViewUpdateEventArgs e) {
            int id = int.Parse(grdCategorias.Rows[e.RowIndex].Cells[0].ToString());
            Response.Redirect("FrmCategoria.aspx?q=update&id=" + id);
        }

        protected void grdCategorias_RowDeleting(object sender, GridViewDeleteEventArgs e) {
            int id = int.Parse(grdCategorias.Rows[e.RowIndex].Cells[0].ToString());
            categoria.Delete(id);
            cargarLista();
        }

        protected void grdCategorias_RowCommand(object sender, GridViewCommandEventArgs e) {
            if (e.CommandName.Equals("Ver")) {
                int rowIndex = int.Parse(e.CommandArgument.ToString());
                int id = int.Parse(grdCategorias.Rows[0].Cells[0].ToString());
                Response.Redirect("FrmCategoria.aspx?q=ver&id=" + id);
            }
        }
    }
}