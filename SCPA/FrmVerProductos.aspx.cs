using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmVerProductos : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            List<categoria> listaCategorias = new categoria().GetAllcategoria();
            lsvCategorias.DataSource = listaCategorias;
            lsvCategorias.DataBind();
            List<producto> listaProductos = new producto().GetAllproducto();
            string strCid = Request.QueryString["cid"];
            int cid = 0;
            if (int.TryParse(Request.QueryString["cid"], out cid)) {
                List<producto> listaFiltrada = new List<producto>();
                foreach (producto p in listaProductos) {
                    if (p.idCategoria == cid) {
                        listaFiltrada.Add(p);
                    }
                }
                listaProductos = listaFiltrada;
            }
            lsvProductos.DataSource = listaProductos;
            lsvProductos.DataBind();
        }

        

        protected void lsvProductos_ItemCommand(object sender, ListViewCommandEventArgs e) {
            switch (e.CommandName) {
                case "Add":
                    if (Session["carrito"] == null) {
                        Session["carrito"] = new List<int>();
                    }
                    List<int> carrito = (List<int>)Session["carrito"];
                    int pid = int.Parse(e.CommandArgument.ToString());
                    carrito.Add(pid);

                    MPGeneralSinLateral mpgsl = (MPGeneralSinLateral)Master.Master;
                    mpgsl.lblCarritoCount.Text = carrito.Count.ToString();

                    break;
            }
        }
    }
}