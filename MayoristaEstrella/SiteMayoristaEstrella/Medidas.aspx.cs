using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussiness;
using Entidades;

namespace SiteMayoristaEstrella
{
    public partial class Medidas : System.Web.UI.Page
    {
        List<UnidadMedida> UnidadMedidaList = new List<UnidadMedida>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
              FillMedidaGrid();
        }

        protected override void Render(HtmlTextWriter writer)
        {
            foreach (GridViewRow row in gridMedidasDataList.Rows)
            {
                row.Attributes.Add("onclick", ClientScript.GetPostBackEventReference(gridMedidasDataList, "Select$" + row.RowIndex.ToString(), true));
            }
            base.Render(writer);
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            // mostrar mensaje
            Response.Redirect("NuevaMedida.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string MedidaId = null;
            if (gridMedidasDataList.SelectedIndex != -1)
            {
                MedidaId = gridMedidasDataList.SelectedRow.Cells[0].Text;
                Response.Redirect("EditarMedida.aspx?medidaid=" + MedidaId);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int UnidadMedidaId = 0;
            if (gridMedidasDataList.SelectedIndex != -1)
            {
                UnidadMedidaId = Convert.ToInt32(gridMedidasDataList.SelectedRow.Cells[0].Text);
                // UnidadMedidaList.RemoveAll(c => c.IdUnidadMedida == UnidadMedidaId);
                /*Response.Redirect("EliminarUnidadMedida.aspx?UnidadMedidaid=" + UnidadMedidaId);*/
                UnidadMedidaBussiness UnidadMedidaBiz = new UnidadMedidaBussiness();
                UnidadMedidaBiz.DeleteUnidadMedida(UnidadMedidaId);
                FillMedidaGrid();
            }
        }

        protected void gridMedidasList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("OnMouseOver", "this.style.cursor='pointer';");
                e.Row.ToolTip = "Click en la fila para seleccionarla";
            }
        }

        private void FillMedidaGrid()
        {
            
            UnidadMedidaBussiness UnidadMedidaBiz = new UnidadMedidaBussiness();
            UnidadMedidaList = UnidadMedidaBiz.GetUnidadMedidas();

            gridMedidasDataList.DataSource = UnidadMedidaList;
            gridMedidasDataList.DataBind();
        }
    }
}