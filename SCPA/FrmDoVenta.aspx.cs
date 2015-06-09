using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SCPA.WST;
using Datos;

namespace SCPA {
    public partial class FrmDoVenta : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        private int getLastID() {
            List<venta> lv = new venta().GetAllventa();
            return lv[lv.Count - 1].Id;
        }

        protected void btnCompletar_Click(object sender, EventArgs e) {
            string tRetiro = txtTarjeta.Text;
            string tDeposito = "1234000099991357";

            List<detalleventa> detalles = new List<detalleventa>();

            venta vvv = new venta();
            vvv.fecha = DateTime.Now;
            vvv.idCliente = 1;
            vvv.idSucursal = 3;
            vvv.idUsuario = 1;

            List<int> carrito = (List<int>)Session["carrito"];
            double total = 0;
            foreach (int i in carrito) {

                producto pp = new producto(i);

                detalleventa di = new detalleventa();
                di.cantidad = 1;
                di.idProducto = i;
                di.precio = pp.precio;
                detalles.Add(di);

                total += pp.precio;
            }

            int cantidad = (int)total;
            string concepto = "Compra en Shonen";

            vvv.total = total;
            vvv.Create();

            int ultimo = getLastID();

            foreach (detalleventa ddd in detalles) {
                ddd.idVenta = ultimo;
                ddd.Create();
            }




            WSTransaccionesSoapClient client = new WSTransaccionesSoapClient();
            client.realizarTransaccion(tRetiro, tDeposito, cantidad, concepto);

            carrito.Clear();
            Response.Redirect("FrmVentaDone.aspx");


        }
    }
}