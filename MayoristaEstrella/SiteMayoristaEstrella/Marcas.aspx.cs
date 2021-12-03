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
    public partial class Marcas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillMarcaGrid();
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            foreach (GridViewRow row in gridMarcasList.Rows)
            {
                row.Attributes.Add("onclick", ClientScript.GetPostBackEventReference(gridMarcasList, "Select$" + row.RowIndex.ToString(), true));
            }
            base.Render(writer);
        }

        private void FillMarcaGrid()
        {
            List<Marca> marcaList = new List<Marca>();
            MarcaBussiness marcaBiz = new MarcaBussiness();
            marcaList = marcaBiz.GetMarcas();
            gridMarcasList.DataSource = marcaList;
            gridMarcasList.DataBind();
        }

        protected void gridMarcasList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("OnMouseOver", "this.style.cursor='pointer';");
                e.Row.ToolTip = "Click en la fila para seleccionarla";
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NuevaMarca.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string marcaId = null;
            if (gridMarcasList.SelectedIndex != -1)
            {
                marcaId = gridMarcasList.SelectedRow.Cells[0].Text;
                Response.Redirect("~/EditarMarca?marcaId="+marcaId);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int marcaId = 0;
            if (gridMarcasList.SelectedIndex != -1)
            {
                marcaId = Convert.ToInt32(gridMarcasList.SelectedRow.Cells[0].Text);
                MarcaBussiness marcaBiz = new MarcaBussiness();
                marcaBiz.DeleteMarca(marcaId);
                FillMarcaGrid();
            }
        }
    }
}