using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmLogin : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) return;



            if (Session["usuario"] != null && Session["usuario"].ToString().Equals("No encontrado")) 
                Response.Write("<script type='text/javascript'>alert('No has iniciado Sesión')</script");
        }

        protected void btnLogin_Click(object sender, EventArgs e) {
            List<usuario> listaUsuarios = new usuario().GetAllusuario();
            foreach (usuario u in listaUsuarios) {
                if (u.nombre.Equals(txtID.Text)) {
                    Session["usuario"] = u.Id;
                    Session["tipo"] = u.tipoUsuario;
                    Response.Redirect("FrmVerProductos.aspx");
                }
            }
        }
    }
}