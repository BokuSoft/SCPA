using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmCategoria : System.Web.UI.Page {


        protected void Page_Load(object sender, EventArgs e) {
            // si se trata de una adicion hay que desaparecer el campo de ID, en cualquier caso el campo esta desabilitado
            validar_load();
            if (IsPostBack) return;
            string operacion = Request.QueryString["q"];

            if (operacion.Equals("update") || operacion.Equals("ver")) {
                int id = int.Parse(Request.QueryString["id"]);
                categoria c = new categoria(id);
                mostrar(c);
                if (operacion.Equals("update")) {
                    lblTitulo.Text = "Actualizar Categoría";
                } else {
                    lblTitulo.Text = "Ver Categoría";
                }
            } else {
                lblTitulo.Text = "Agregar Categoría";
            }
        }

        private void mostrar(categoria c) {
            txtID.Text = c.Id.ToString();
            txtNombre.Text = c.nombre;
        }

        private void validar_load() {
            // verificar cosas como que el usuario haya iniciado sesion y que sea un usuario administrador
        }

        protected void btnRegresar_Click(object sender, EventArgs e) {
            Response.Redirect("FrmCatalogoCategorias.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e) {

            int id = int.Parse(txtID.Text);
            string nombre = txtNombre.Text;

            try {
                categoria c = new categoria(id);
                c.nombre = nombre;
                c.Update();
            } catch(ApplicationException ex) {
                categoria c = new categoria();
                c.Id = 0;
                c.nombre = nombre;
                c.Create();
            }

            btnRegresar_Click(null, null);

        }

    }
}