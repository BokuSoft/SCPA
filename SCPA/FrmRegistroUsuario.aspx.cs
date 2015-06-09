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
            cargarComboFechas();
        }

        /// <summary>
        /// Se cargan todos los combobox de la interfaz, dia, mes y anio
        /// </summary>
        protected void cargarComboFechas() {
            List<int> lista = new List<int>();
            for (int i = 1; i <= 31; i++) {
                lista.Add(i);
            }
            ddlDia.DataSource = lista;
            ddlDia.SelectedIndex = 0;
            ddlDia.DataBind();
            lista.Clear();

            for (int i = 1; i <= 12; i++) {
                lista.Add(i);
            }
            ddlMes.DataSource = lista;
            ddlMes.SelectedIndex = 0;
            ddlMes.DataBind();
            lista.Clear();

            for (int i = 2015; i >= 1940; i--) {
                lista.Add(i);
            }
            ddlAnio.DataSource = lista;
            ddlAnio.DataBind();
            ddlAnio.SelectedIndex = 0;
            lista.Clear();
        }

        protected void btnRegistro_Click(object sender, EventArgs e) {

            
        }

        protected void btnGuardar_Click(object sender, EventArgs e) {
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string direccion = txtDireccion.Text;
            string ciudad = txtCiudad.Text;
            string telefono = txtTelefono.Text;
            DateTime time = new DateTime(int.Parse(ddlAnio.SelectedValue), int.Parse(ddlMes.SelectedValue), int.Parse(ddlDia.SelectedValue));

            usuario c = new usuario();
            c.nombre = nombre;
            c.apellidos = apellidos;
            c.ciudad = ciudad;
            c.direccion = direccion;
            c.telefono = telefono;
            c.fechaNacimiento = time;
            c.tipoUsuario = usuario.EnumTipoUsuario.CUSTOMER;
            c.Create();

            Response.Redirect("FrmLogin.aspx");
        }
    }
}