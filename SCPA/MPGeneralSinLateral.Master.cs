using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCPA {
    public partial class MPGeneralSinLateral : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["carrito"] == null) {
                Session["carrito"] = new List<int>();
            }
            List<int> carrito = (List<int>)Session["carrito"];

            lblCarritoCount.Text = carrito.Count.ToString();


        }
    }
}