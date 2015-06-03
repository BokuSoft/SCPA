using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmCatalogoSucursales : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) return;

            //usuario user = (usuario)Session["usuario"];
            //if (user == null || !(user.tipoUsuario.Equals(usuario.EnumTipoUsuario.ADMINISTRATOR))) {
            //    Session["usuario"] = "No se tienen permisos para acceder.";
            //    Response.Redirect("FrmLogin.aspx");
            //} else {

                if (Request.QueryString["op"] != null) {
                   if (Request.QueryString["op"].Equals("1")) {
                        Response.Write("<script>alert('Sucursal Insertada')</script>");
                    } else {
                        Response.Write("<script>alert('Sucursal Actualizada')</script>");
                    }
                }

                cargarDatos();
            //}
        }

        public void cargarDatos() {
            sucursal sucursal = new sucursal();
            grdListaSucursales.DataSource = sucursal.GetAllsucursal();
            grdListaSucursales.DataBind();
            Application["grid"] = grdListaSucursales.DataSource;
        }

        protected void btnLimpiar_Click(object sender, EventArgs e) {
            txtBuscar.Text = "";
            cargarDatos();
        }

        protected void btnAgregar_Click(object sender, EventArgs e) {
            Application["obj"] = null;
            Response.Redirect("FrmSucursal.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e) {
            List<sucursal> listaSucursal = (List<sucursal>)Application["grid"];
            bool encontrado = false;
            foreach (sucursal su in listaSucursal) {
                if (su.nombre.Equals(txtBuscar.Text)) {
                    List<sucursal> aux = new List<sucursal>();
                    aux.Add(su);
                    grdListaSucursales.DataSource = aux;
                    grdListaSucursales.DataBind();
                    encontrado = true;
                }
            }
            if (!encontrado) Response.Write("<script>alert('Sucursal no Encontrada')</script>");
        }

        protected void grdCatalogo_RowUpdating(object sender, GridViewUpdateEventArgs e) {
            List<sucursal> listaSucursal = (List<sucursal>)Application["grid"];
            Application["obj"] = listaSucursal[e.RowIndex];
            Response.Redirect("FrmSucursal.aspx");
        }

        protected void grdCatalogo_RowDeleting(object sender, GridViewDeleteEventArgs e) {
            List<sucursal> listaSucursal = (List<sucursal>)Application["grid"];
            sucursal obj = listaSucursal[e.RowIndex];
            obj.Delete();
            Response.Write("<script>alert('Sucursal Eliminada')</script>");
            cargarDatos();
        }
    }
}