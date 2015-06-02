using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmCompra : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) return;

            //usuario user = (usuario)Session["usuario"];
            //if (user == null || (user.tipoUsuario.Equals(usuario.EnumTipoUsuario.GUEST) || 
            //    user.tipoUsuario.Equals(usuario.EnumTipoUsuario.CUSTOMER))) {
            //    Session["usuario"] = "No encontrado";
            //    Response.Redirect("FrmLogin.aspx");
            //} else {
            if (Request.QueryString["id"] != null) {
                if (Request.QueryString["id"].Equals("ver")) {
                    grdListaCompras.Enabled = false;
                    btnAccion.Enabled = false;
                    btnGuardar.Enabled = false;
                    txtCantidad.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtTotal.Enabled = false;
                }
            }

            compra obj = (compra)Application["obj"];
            if (obj != null) {
                cargarDatos(obj);
                
            } else {
                grdListaCompras.DataSource = null;
                grdListaCompras.DataBind();
            }
                cargarCombo();
            //}

        }

        public void cargarCombo() {
            producto obj = new producto();
            List<producto> listaproducto = obj.GetAllproducto();
            List<String> productos = new List<String>();
            foreach (producto pro  in listaproducto) {
                productos.Add(pro.nombre);
            }
            cboProductos.DataSource = productos;
            cboProductos.DataBind();
        }

        public void cargarDatos(compra obj) {
            List<compraDetallePersonalizada> listaCompraDetalle = new List<compraDetallePersonalizada>();
            //-------------- Obtener el detalleventa
            detallecompra detalle = new detallecompra();
            List<detallecompra> listaDetalle = detalle.GetAlldetallecompra();
            foreach (detallecompra det in listaDetalle) {
                if (det.idCompra == obj.Id) {
                    detalle = det;

                    //------------- Obtener el Producto
                    producto producto = new producto();
                    List<producto> listaProducto = producto.GetAllproducto();
                    foreach (producto pro in listaProducto) {
                        if (pro.Id == detalle.idProducto) {
                            producto = pro;

                            //Anadir a la lista de compraDetalle
                            listaCompraDetalle.Add(new compraDetallePersonalizada(detalle.Id,producto.nombre,detalle.cantidad,detalle.precio,obj.total));
                        }
                    }
                }
            }
            Application["grid"] = listaCompraDetalle;
            grdListaCompras.DataSource = listaCompraDetalle;
            grdListaCompras.DataBind();
        }

        protected void btnRegresar_Click(object sender, EventArgs e) {
            Response.Redirect("FrmCatalogoCompras.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e) {
            actualizarTotal();
            aumentarInventario();
            Response.Redirect("FrmCatalogoCompras.aspx?op=1");
        }

        protected void aumentarInventario() {
            List<compraDetallePersonalizada> lista = (List<compraDetallePersonalizada>)Application["grid"];
            foreach(compraDetallePersonalizada aux in lista){
                producto producto = new producto();
                List<producto> listaProducto = producto.GetAllproducto();
                foreach (producto pro in listaProducto) {
                    if (pro.nombre.Equals(aux.Producto)) {
                        pro.cantidad += aux.Cantidad;
                        pro.Update();
                        break;
                    }
                }
            }
        }

        protected void actualizarTotal() {
            List<compraDetallePersonalizada> lista = (List<compraDetallePersonalizada>)Application["grid"];
            compra obj = (compra)Application["obj"];
            double contador = 0.0;
            foreach (compraDetallePersonalizada aux in lista) {
                contador += (aux.Total);
            }
            obj.total = contador;
            obj.Update();
        }

        protected void grdListaCompras_RowDeleting(object sender, GridViewDeleteEventArgs e) {
            List<compraDetallePersonalizada> listaCompraDetalle = (List<compraDetallePersonalizada>)Application["grid"];
            listaCompraDetalle[e.RowIndex].deleteDetalleCompra();
            Response.Write("<script>alert('Detalle de compra Eliminada.')</script>");
            compra obj = (compra)Application["obj"];
            cargarDatos(obj);
        }

        protected void grdListaCompras_RowUpdating(object sender, GridViewUpdateEventArgs e) {
            List<compraDetallePersonalizada> listaCompraDetalle = (List<compraDetallePersonalizada>)Application["grid"];
            compraDetallePersonalizada obj = listaCompraDetalle[e.RowIndex];
            cboProductos.SelectedValue = obj.Producto;
            txtCantidad.Text = obj.Cantidad.ToString();
            txtPrecio.Text = obj.Precio.ToString();
            txtTotal.Text = (obj.Cantidad * obj.Precio) + "";
            btnAccion.Text = "Actualizar";
            Application["id"] = e.RowIndex;
        }

        protected void btnAccion_Click(object sender, EventArgs e) {
            compra com = (compra)Application["obj"];
            if(btnAccion.Text.Equals("Agregar")){
                compraDetallePersonalizada obj = new compraDetallePersonalizada(-1,cboProductos.SelectedValue,int.Parse(txtCantidad.Text),
                    double.Parse(txtPrecio.Text),(double.Parse(txtPrecio.Text) * double.Parse(txtCantidad.Text)));
                obj.insertDetalleCompra(com.Id);
                Response.Write("<script>alert('Detalle de compra Agragada.')</script>");
            } else {
                List<compraDetallePersonalizada> lista = (List<compraDetallePersonalizada>)Application["grid"];
                int id = (int)Application["id"];
                lista[id].Producto = cboProductos.Text;
                lista[id].Cantidad = int.Parse(txtCantidad.Text);
                lista[id].Precio = double.Parse(txtPrecio.Text);
                lista[id].Total = lista[id].Precio * lista[id].Cantidad;
                lista[id].updateDetalleCompra(com.Id);
                Response.Write("<script>alert('Detalle de compra Actualizada.')</script>");            
            }
            txtTotal.Text = "0.0";
            txtCantidad.Text = "0";
            txtPrecio.Text = "0.0";
            cboProductos.SelectedIndex = 0;
            btnAccion.Text.Equals("Agregar");
            cargarDatos(com);
        }

        protected void txtCantidad_TextChanged(object sender, EventArgs e) {
            try {
                txtTotal.Text = "" + double.Parse(txtCantidad.Text) * double.Parse(txtPrecio.Text);
            } catch (Exception ex) { txtCantidad.Text = 0+""; }
        }

        protected void txtPrecio_TextChanged(object sender, EventArgs e) {
            try {
                txtTotal.Text = "" + double.Parse(txtCantidad.Text) * double.Parse(txtPrecio.Text);
            } catch (Exception ex) { txtPrecio.Text = 0.0 + ""; }
        }
    }

    class compraDetallePersonalizada {
        public String Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }
        public int Id { get; set; }

        public compraDetallePersonalizada(int id,String _producto, int _cantidad, double _precio, double _total) {
            Id = id;
            Producto = _producto;
            Cantidad = _cantidad;
            Precio = _precio;
            Total = _cantidad*_precio;
        }

        public void deleteDetalleCompra() {
            detallecompra detalleCompra = new detallecompra();
            detalleCompra.Id = Id;
            detalleCompra.Delete();
        }

        public void insertDetalleCompra(int idCompra){
            detallecompra detalleCompra = new detallecompra();
            detalleCompra.idCompra = idCompra;
            detalleCompra.idProducto = obtenerIdProducto(Producto);
            detalleCompra.precio = Precio;
            detalleCompra.cantidad = Cantidad;
            detalleCompra.Create();
        }

        public void updateDetalleCompra(int idCompra){
            detallecompra detalleCompra = new detallecompra();
            detalleCompra.Id = Id;
            detalleCompra.idCompra = idCompra;
            detalleCompra.idProducto = obtenerIdProducto(Producto);
            detalleCompra.precio = Precio;
            detalleCompra.cantidad = Cantidad;
            detalleCompra.Update();
        }

        public int obtenerIdProducto(String Producto){
            producto obj = new producto();
            List<producto> lista = obj.GetAllproducto();
            foreach (producto pro in lista) {
                if (pro.nombre.Equals(Producto)) return pro.Id;
            }
            return 0;
        }
    }
}