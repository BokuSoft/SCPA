using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmCatalogoProveedores : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) return;


            usuario user = (usuario)Session["usuario"];
            if (user == null && (user.tipoUsuario.Equals(usuario.EnumTipoUsuario.GUEST) || 
                user.tipoUsuario.Equals(usuario.EnumTipoUsuario.CUSTOMER))) {
                Session["usuario"] = "No encontrado";
                Response.Redirect("FrmLogin.aspx");
            } else {

                if (Request.QueryString["op"] != null) {
                    if (Request.QueryString["op"].Equals("1")) {
                        Response.Write("<script>alert('Proveedor Insertado')</script>");
                    } else {
                        Response.Write("<script>alert('Proveedor Actualizado')</script>");
                    }
                }

                cargarDatos();
            }            
        }
        
        public void cargarDatos() {
            proveedor proveedor = new proveedor();
            grdListaProveedores.DataSource = proveedor.GetAllproveedor();
            grdListaProveedores.DataBind();
            Application["grid"] = grdListaProveedores.DataSource;
        }

        protected void grdListaProveedores_RowUpdating(object sender, GridViewUpdateEventArgs e) {
            List<proveedor> listaProveedor = (List<proveedor>)Application["grid"];
            Application["obj"] = listaProveedor[e.RowIndex];
            Response.Redirect("FrmProveedor.aspx");
        }

        protected void grdListaProveedores_RowDeleting(object sender, GridViewDeleteEventArgs e) {
            List<proveedor> listaProveedor = (List<proveedor>)Application["grid"];
            proveedor obj = listaProveedor[e.RowIndex];
            obj.Delete();
            Response.Write("<script>alert('Proveedor Eliminado')</script>");
            cargarDatos();
        }

        protected void btnAgregar_Click(object sender, EventArgs e) {
            Application["obj"] = null;
            Response.Redirect("FrmProveedor.aspx");
        }

        protected void btnLimpiarBusqueda_Click(object sender, EventArgs e) {
            txtBuscar.Text = "";
            cargarDatos();
        }

        protected void btnBuscar_Click(object sender, EventArgs e) {
            List<proveedor> listaProveedor = (List<proveedor>)Application["grid"];
            bool encontrado=false;
            foreach (proveedor pro in listaProveedor) {
                if (pro.nombre.Equals(txtBuscar.Text)) {
                    List<proveedor> aux = new List<proveedor>();
                    aux.Add(pro);
                    grdListaProveedores.DataSource = aux;
                    grdListaProveedores.DataBind();
                    encontrado = true;
                }
            }
            if (!encontrado) Response.Write("<script>alert('Proveedor no Encontrado')</script>");
        }
    }
}