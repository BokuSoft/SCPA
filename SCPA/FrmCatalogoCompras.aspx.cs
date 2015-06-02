using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmCatalogoCompras : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) return;

            usuario user = (usuario)Session["usuario"];
            //if (user == null || user.tipoUsuario.Equals(usuario.EnumTipoUsuario.GUEST) || 
            //    user.tipoUsuario.Equals(usuario.EnumTipoUsuario.CUSTOMER)) {
            //    Session["usuario"] = "No se tienen permisos para acceder.";
            //    Response.Redirect("FrmLogin.aspx");
            //} else {

            if (Request.QueryString["op"] != null) {
                if (Request.QueryString["op"].Equals("1")) {
                    Response.Write("<script>alert('Compra Efectuada')</script>");
                }
            }

            cargarDatos();
            //}
        }

        public void cargarDatos() {
            compra compra = new compra();

            grdListaCompras.DataSource = compra.GetAllcompra();
            grdListaCompras.DataBind();
            Application["grid"] = grdListaCompras.DataSource;
        }

        protected void btnBuscar_Click(object sender, EventArgs e) {
            List<compra> listaCompras = (List<compra>)Application["grid"];
            bool encontrado = false;
            foreach (compra com in listaCompras) {
                if (com.Id.ToString().Equals(txtBuscar.Text)) {
                    List<compra> aux = new List<compra>();
                    aux.Add(com);
                    grdListaCompras.DataSource = aux;
                    grdListaCompras.DataBind();
                    encontrado = true;
                }
            }
            if (!encontrado) Response.Write("<script>alert('Compra no Encontrada')</script>");
        }

        protected void btnLimpiar_Click(object sender, EventArgs e) {
            txtBuscar.Text = "";
            cargarDatos();
        }

        protected void btnAgregar_Click(object sender, EventArgs e) {
            compra obj = new compra();
            obj.idProveedor = 1;
            obj.idSucursal = 2;
            obj.idUsuario = 1;
            obj.total = 0;
            DateTime aux = DateTime.Now;
            obj.fecha = aux;
            obj.Create();
            List<compra> lista = obj.GetAllcompra();
            obj = lista[lista.Count - 1];
            Application["obj"] = obj;
            Response.Redirect("FrmCompra.aspx");
        }

        protected void grdCatalogo_RowUpdating(object sender, GridViewUpdateEventArgs e) {
            List<compra> listaCompra = (List<compra>)Application["grid"];
            Application["obj"] = listaCompra[e.RowIndex];
            Response.Redirect("FrmCompra.aspx");
        }

        protected void grdCatalogo_RowDeleting(object sender, GridViewDeleteEventArgs e) {
            List<compra> listaCompra = (List<compra>)Application["grid"];
            compra obj = listaCompra[e.RowIndex];
            obj.Delete();
            Response.Write("<script>alert('Compra Eliminada')</script>");
            cargarDatos();
        }

        protected void grdCatalogo_RowCommand(object sender, GridViewCommandEventArgs e) {
            if (e.CommandName.Equals("ver")) {
                List<compra> listaCompra = (List<compra>)Application["grid"];
                Application["obj"] = listaCompra[int.Parse(e.CommandArgument.ToString())];
                Response.Redirect("FrmCompra.aspx?id=ver");
            }
        }
    }
}