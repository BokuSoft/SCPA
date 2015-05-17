using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCPA {
    public partial class FrmCategoria : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            // si se trata de una adicion hay que desaparecer el campo de ID, en cualquier caso el campo esta desabilitado
            validar_load();
        }

        private void validar_load() {
            // verificar cosas como que el usuario haya iniciado sesion y que sea un usuario administrador
        }

        protected void btnRegresar_Click(object sender, EventArgs e) {
            Response.Redirect("FrmCatalogoCategorias.aspx");
        }

    }
}