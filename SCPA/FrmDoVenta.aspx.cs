using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SCPA.WST;

namespace SCPA {
    public partial class FrmDoVenta : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnCompletar_Click(object sender, EventArgs e) {
            string tRetiro = txtTarjeta.Text;
            string tDeposito = "Hardcode";
            int cantidad = 0;
            string concepto = "Compra en Shonen";

            WSTransaccionesSoapClient client = new WSTransaccionesSoapClient();
            client.realizarTransaccion(tRetiro, tDeposito, cantidad, concepto);

            Response.Redirect("FrmPrincipal.aspx");
        }
    }
}