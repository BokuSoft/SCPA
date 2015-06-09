using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmVenta : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            try {
                int idVenta = int.Parse(Request.QueryString["id"]);

                venta miventa = new venta(idVenta);
                txtFecha.Text = miventa.fecha.ToShortDateString();
                txtID.Text = miventa.Id.ToString();

                List<detalleventa> listaDetalles = new detalleventa().GetAlldetalleventa();
                List<detalleventa> misDetalles = new List<detalleventa>();

                foreach (detalleventa dv in listaDetalles) {
                    if (dv.idVenta == idVenta) {
                        misDetalles.Add(dv);
                    }
                }

                grdDetalles.DataSource = misDetalles;
                grdDetalles.DataBind();
            } catch (Exception ex) {
                btnRegresar_Click(null, null);
            }

        }

        protected void btnRegresar_Click(object sender, EventArgs e) {
            Response.Redirect("FrmCatalogoVentas.aspx");
        }
    }
}