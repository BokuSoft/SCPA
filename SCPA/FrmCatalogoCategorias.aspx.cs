﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace SCPA {
    public partial class FrmCatalogoCategorias : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            categoria c = new categoria();
            List<categoria> listaCategorias = c.GetAllcategoria();

            grdCategorias.DataSource = listaCategorias;
            grdCategorias.DataBind();
        }

        public void cargarLista() {
            categoria c = new categoria();
            List<categoria> listaCategorias = c.GetAllcategoria();
            grdCategorias.DataSource = listaCategorias;
            grdCategorias.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e) {
            Response.Redirect("FrmCategoria.aspx");
        }

        protected void grdCategorias_RowUpdating(object sender, GridViewUpdateEventArgs e) {
            int id = int.Parse(grdCategorias.Rows[e.RowIndex].Cells[0].Text);
            Response.Redirect("FrmCategoria.aspx?q=update&id=" + id);
        }

        protected void grdCategorias_RowDeleting(object sender, GridViewDeleteEventArgs e) {
            int id = int.Parse(grdCategorias.Rows[e.RowIndex].Cells[0].Text);
            categoria.Delete(id);
            cargarLista();
        }

        protected void grdCategorias_RowCommand(object sender, GridViewCommandEventArgs e) {
            if (e.CommandName.Equals("Ver")) {
                int rowIndex = int.Parse(e.CommandArgument.ToString());
                int id = int.Parse(grdCategorias.Rows[rowIndex].Cells[0].Text);
                Response.Redirect("FrmCategoria.aspx?q=ver&id=" + id);
            }
        }
    }
}