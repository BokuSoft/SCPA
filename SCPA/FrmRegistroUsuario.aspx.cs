using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmRegistroUsuario : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnRegistro_Click(object sender, EventArgs e) {

            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string direccion = txtDireccion.Text;
            string ciudad = txtCiudad.Text;
            string telefono = txtTelefono.Text;
            DateTime fechaNac = DateTime.Now;
            
            usuario c = new usuario();
            c.nombre = nombre;
            c.apellidos = apellidos;
            c.ciudad = ciudad;
            c.direccion = direccion;
            c.telefono = telefono;
            c.fechaNacimiento = fechaNac; 
            c.Create();

            Response.Redirect("FrmLogin.aspx");
        }
    }
}