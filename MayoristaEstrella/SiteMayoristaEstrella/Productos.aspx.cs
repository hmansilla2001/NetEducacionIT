using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussiness;

namespace SiteMayoristaEstrella
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillProductoGrid();
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            foreach (GridViewRow row in gridProductosList.Rows)
            {
                row.Attributes.Add("onclick", ClientScript.GetPostBackEventReference(gridProductosList, "Select$" + row.RowIndex.ToString(), true));
            }
            base.Render(writer);
        }

        protected void gridProductosList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("OnMouseOver", "this.style.cursor='pointer';");
                e.Row.ToolTip = "Click en la fila para seleccionarla";
            }
        }

        private void FillProductoGrid()
        {
            List<Producto> productoList = new List<Producto>();
            ProductoBussiness productoBiz = new ProductoBussiness();
            productoList = productoBiz.GetProductos();
            gridProductosList.DataSource = productoList;
            gridProductosList.DataBind();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NuevoProducto.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string productoId = null;
            if (gridProductosList.SelectedIndex != -1)
            {
                productoId = gridProductosList.SelectedRow.Cells[0].Text;
                Response.Redirect("~/EditarProducto.aspx?productoId="+productoId);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int productoId = 0;
            if (gridProductosList.SelectedIndex != -1)
            {
                productoId = Convert.ToInt32(gridProductosList.SelectedRow.Cells[0].Text);
                ProductoBussiness productoBiz = new ProductoBussiness();
                productoBiz.DeleteProducto(productoId);
                FillProductoGrid();
            }
        }
    }
}