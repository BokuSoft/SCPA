using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCPA {
    public partial class FrmVentaDone : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void btnVolver_Click(object sender, EventArgs e) {
            Response.Redirect("FrmVerProductos.aspx");
        }
    }
}