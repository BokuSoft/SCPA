using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmCarrito : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            List<int> carrito = (List<int>)Session["carrito"];
            List<producto> listaProductosCarrito = new List<producto>();

            double total = 0.0;

            foreach (int i in carrito) {
                producto p = new producto(i);
                listaProductosCarrito.Add(p);
                total += p.precio;

            }

            if (Session["usuario"] != null) {
                btnComprar.Text = "Comprar";
            }

            grdCarrito.DataSource = listaProductosCarrito;
            grdCarrito.DataBind();

            lblTotal.Text = total.ToString("C2");

        }

        protected void btnComprar_Click(object sender, EventArgs e) {
            if (Session["usuario"] != null) {
                Response.Redirect("FrmDoVenta.aspx");
            } else {
                Response.Redirect("FrmLogin.aspx");
            }
        }
    }
}