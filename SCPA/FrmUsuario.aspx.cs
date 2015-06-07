using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmUsuario : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) return;

            //usuario user = (usuario)Session["usuario"];
            //if (user == null || (user.tipoUsuario.Equals(usuario.EnumTipoUsuario.GUEST) || 
            //    user.tipoUsuario.Equals(usuario.EnumTipoUsuario.CUSTOMER))) {
            //    Session["usuario"] = "No encontrado";
            //    Response.Redirect("FrmLogin.aspx");
            //} else {
            usuario obj = (usuario)Application["obj"];
            cargarComboFechas();
            cargarComboTipo();
            txtID.Enabled = false;
            if (obj != null) {
                txtNombre.Text = obj.nombre;
                txtApellidos.Text = obj.apellidos;
                txtCiudad.Text = obj.ciudad;
                txtDireccion.Text = obj.direccion;
                txtTelefono.Text = obj.telefono;
                txtID.Text = obj.Id+"";
                ddlMes.SelectedIndex = obj.fechaNacimiento.Month;
                ddlAnio.SelectedIndex = obj.fechaNacimiento.Year;
                ddlDia.SelectedIndex = obj.fechaNacimiento.Day;
                ddlTipoUsuario.Text = obj.tipoUsuario.ToString();
                lblTitulo.Text = "Actualizar sucursal";
            }
            //}
        }

        /// <summary>
        /// Se cargan todos los combobox de la interfaz tipo de usuario
        /// </summary>
        protected void cargarComboTipo() {
            List<usuario.EnumTipoUsuario> tipo = new List<usuario.EnumTipoUsuario>();
            tipo.Add(usuario.EnumTipoUsuario.ADMINISTRATOR);
            tipo.Add(usuario.EnumTipoUsuario.CUSTOMER);
            tipo.Add(usuario.EnumTipoUsuario.EMPLOYEE);
            tipo.Add(usuario.EnumTipoUsuario.GUEST);
            ddlTipoUsuario.DataSource = tipo;
            ddlTipoUsuario.DataBind();
        }

        /// <summary>
        /// Se cargan todos los combobox de la interfaz, dia, mes y anio
        /// </summary>
        protected void cargarComboFechas() {
            List<int> lista = new List<int>();
            for(int i=1;i<=31;i++){
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

        protected void btnRegresar_Click(object sender, EventArgs e) {
            Response.Redirect("FrmCatalogoUsuarios.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e) {
            usuario aux = (usuario)Application["obj"];
            usuario obj = new usuario();

            obj.nombre = txtNombre.Text;
            obj.apellidos = txtApellidos.Text;
            obj.direccion = txtDireccion.Text;
            obj.ciudad = txtCiudad.Text;
            obj.telefono = txtTelefono.Text;
            DateTime time = new DateTime(int.Parse(ddlAnio.SelectedValue),int.Parse(ddlMes.SelectedValue),int.Parse(ddlDia.SelectedValue));
            obj.fechaNacimiento = time;
            obj.tipoUsuario = (usuario.EnumTipoUsuario)ddlTipoUsuario.SelectedIndex;
            if (aux != null) {
                obj.Id = aux.Id;
                obj.Update();
                Response.Redirect("FrmCatalogoUsuarios.aspx?op=2");
            } else {
                obj.Create();
                Response.Redirect("FrmCatalogoUsuarios.aspx?op=1");
            }
        }
    }
}