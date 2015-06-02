﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmSucursal : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) return;

            //usuario user = (usuario)Session["usuario"];
            //if (user == null || (user.tipoUsuario.Equals(usuario.EnumTipoUsuario.GUEST) || 
            //    user.tipoUsuario.Equals(usuario.EnumTipoUsuario.CUSTOMER))) {
            //    Session["usuario"] = "No encontrado";
            //    Response.Redirect("FrmLogin.aspx");
            //} else {
            sucursal obj = (sucursal)Application["obj"];
            if (obj != null) {
                txtNombre.Text = obj.nombre;
                txtJefe.Text = obj.nombreJefe;
                txtCiudad.Text = obj.ciudad;
                txtDireccion.Text = obj.direccion;
                txtTelefono.Text = obj.telefono;
                lblTitulo.Text = "Actualizar sucursal";
            }
            //}

        }

        protected void btnGuardar_Click(object sender, EventArgs e) {
            sucursal aux = (sucursal)Application["obj"];
            sucursal obj = new sucursal();

            obj.nombre = txtNombre.Text;
            obj.nombreJefe = txtJefe.Text;
            obj.direccion = txtDireccion.Text;
            obj.ciudad = txtCiudad.Text;
            obj.telefono = txtTelefono.Text;
            if (aux != null) {
                obj.Id = aux.Id;
                obj.Update();
                Response.Redirect("FrmCatalogoSucursales.aspx?op=2");
            } else {
                obj.Create();
                Response.Redirect("FrmCatalogoSucursales.aspx?op=1");
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e) {
            Response.Redirect("FrmCatalogoSucursales.aspx");
        }
    }
}