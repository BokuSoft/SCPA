using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmProducto : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(IsPostBack) return;
            validar_load();

            List<proveedor> listaProveedores = new proveedor().GetAllproveedor();
            List<categoria> listaCategorias = new categoria().GetAllcategoria();
            ddlCategoria.DataSource = listaCategorias;
            ddlProveedor.DataSource = listaProveedores;
            ddlCategoria.DataBind();
            ddlProveedor.DataBind();

            string operacion = Request.QueryString["q"];

            if (operacion != null && (operacion.Equals("update") || operacion.Equals("ver"))) {
                int id = int.Parse(Request.QueryString["id"]);
                producto c = new producto(id);
                mostrar(c);
                if (operacion.Equals("update")) {
                    lblTitulo.Text = "Actualizar Producto";
                } else {
                    lblTitulo.Text = "Ver Producto";
                }
            } else {
                lblTitulo.Text = "Agregar Producto";
            }

        }

        private void mostrar(producto p) {
            txtID.Text = p.Id.ToString();
            txtNombre.Text = p.nombre;
            txtCantidad.Text = p.cantidad.ToString();
            txtPrecio.Text = p.precio.ToString();
            chkDescontinuado.Checked = p.descontinuado != 0;
            ddlCategoria.SelectedValue = p.idCategoria.ToString();
            ddlProveedor.SelectedValue = p.idProveedor.ToString();
        }

        private void validar_load() {

        }

        protected void btnGuardar_Click(object sender, EventArgs e) {
            int id = 0;
            int.TryParse(txtID.Text, out id);
            string nombre = txtNombre.Text;
            double precio = double.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            short descontinuado = chkDescontinuado.Checked ? (short)1 : (short)0;
            int idCategoria = int.Parse(ddlCategoria.SelectedValue);
            int idProveedor = int.Parse(ddlProveedor.SelectedValue);

            try {
                producto p = new producto(id);
                p.nombre = nombre;
                p.cantidad = cantidad;
                p.precio = precio;
                p.descontinuado = descontinuado;
                p.idCategoria = idCategoria;
                p.idProveedor = idProveedor;
                p.Update();
            } catch (ApplicationException ex) {
                producto p = new producto();
                p.nombre = nombre;
                p.cantidad = cantidad;
                p.precio = precio;
                p.descontinuado = descontinuado;
                p.idCategoria = idCategoria;
                p.idProveedor = idProveedor;
                p.Create();
            }

            btnCancelar_Click(null, null);
        }

        protected void btnCancelar_Click(object sender, EventArgs e) {
            Response.Redirect("FrmCatalogoProductos.aspx");

        }
    }
}