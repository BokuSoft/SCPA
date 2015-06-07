using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmCatalogoUsuarios : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) return;

            //usuario user = (usuario)Session["usuario"];
            //if (user == null || !(user.tipoUsuario.Equals(usuario.EnumTipoUsuario.ADMINISTRATOR))) {
            //    Session["usuario"] = "No se tienen permisos para acceder.";
            //    Response.Redirect("FrmLogin.aspx");
            //} else {

            if (Request.QueryString["op"] != null) {
                if (Request.QueryString["op"].Equals("1")) {
                    Response.Write("<script>alert('Usuario Insertado')</script>");
                } else {
                    Response.Write("<script>alert('Usuario Actualizado')</script>");
                }
            }

            cargarDatos();
            //}
        }

        public void cargarDatos() {
            usuario usuarios = new usuario();
            grdListaUsuarios.DataSource = usuarios.GetAllusuario();
            grdListaUsuarios.DataBind();
            Application["grid"] = grdListaUsuarios.DataSource;
        }

        protected void grdListaUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e) {
            List<usuario> listaUsuario = (List<usuario>)Application["grid"];
            Application["obj"] = listaUsuario[e.RowIndex];
            Response.Redirect("FrmUsuario.aspx");
        }

        protected void grdListaUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e) {
            List<usuario> listaUsuario = (List<usuario>)Application["grid"];
            usuario obj = listaUsuario[e.RowIndex];
            obj.Delete();
            Response.Write("<script>alert('Usuario Eliminado')</script>");
            cargarDatos();
        }

        protected void btnBuscar_Click(object sender, EventArgs e) {
            List<usuario> listaUsuario = (List<usuario>)Application["grid"];
            bool encontrado = false;
            foreach (usuario su in listaUsuario) {
                if (su.nombre.Equals(txtBuscar.Text)) {
                    List<usuario> aux = new List<usuario>();
                    aux.Add(su);
                    grdListaUsuarios.DataSource = aux;
                    grdListaUsuarios.DataBind();
                    encontrado = true;
                }
            }
            if (!encontrado) Response.Write("<script>alert('Usuario no Encontrado')</script>");
        }

        protected void btnAgregar_Click(object sender, EventArgs e) {
            Application["obj"] = null;
            Response.Redirect("FrmUsuario.aspx");
        }

        protected void btnLimpiar_Click(object sender, EventArgs e) {
            txtBuscar.Text = "";
            cargarDatos();
        }
    }
}