using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCPA {
    public partial class FrmLogin : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) return;

            if (Session["usuario"] != null && Session["usuario"].ToString().Equals("No encontrado")) 
                Response.Write("<script type='text/javascript'>alert('No has iniciado Sesión')</script");
        }
    }
}