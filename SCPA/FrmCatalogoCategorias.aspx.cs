using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCPA {
    public partial class FrmCatalogoCategorias : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            // obtener lista de categorias
            grdCategorias.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e) {
            Response.Redirect("FrmCategoria.aspx");
        }
    }
}