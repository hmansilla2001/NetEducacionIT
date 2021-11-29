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
    public partial class Rubros : System.Web.UI.Page
    {
        List<Rubro> RubroList = new List<Rubro>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillRubroGrid();
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            foreach(GridViewRow row in gridRubroDataList.Rows)
            {
                row.Attributes.Add("onclick", ClientScript.GetPostBackEventReference(gridRubroDataList, "Select$" + row.RowIndex.ToString(), true));
            }
            base.Render(writer);
        }

        protected void gridRubroDataList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("OnMouseOver", "this.style.cursor='pointer';");
                e.Row.ToolTip = "Click en la fila para seleccionarla";
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            // mostrar mensaje
            Response.Redirect("NuevoRubro.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string RubroId = null;
            if (gridRubroDataList.SelectedIndex != -1)
            {
                RubroId = gridRubroDataList.SelectedRow.Cells[0].Text;
                Response.Redirect("EditarRubro.aspx?rubroid=" + RubroId);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int RubroId = 0;
            if (gridRubroDataList.SelectedIndex != -1)
            {
                RubroId = Convert.ToInt32(gridRubroDataList.SelectedRow.Cells[0].Text);
                // RubroList.RemoveAll(c => c.IdRubro == RubroId);
                /*Response.Redirect("EliminarRubro.aspx?rubroid=" + RubroId);*/
                RubroBussiness RubroBiz = new RubroBussiness();
                RubroBiz.DeleteRubro(RubroId);
                FillRubroGrid();
            }
        }

        private void FillRubroGrid()
        {
            //List<Rubro> RubroList = new List<Rubro>();
            //Rubro rubro = new Rubro();
            //rubro.IdRubro = 1;
            //rubro.DescripcionRubro = "Gaseosa";
            //rubro.activo = true;
            //RubroList.Add(rubro);

            //rubro = new Rubro();
            //rubro.IdRubro = 2;
            //rubro.DescripcionRubro = "Galletitas";
            //rubro.activo = true;
            //RubroList.Add(rubro);

            //rubro = new Rubro();
            //rubro.IdRubro = 3;
            //rubro.DescripcionRubro = "Lacteos";
            //rubro.activo = true;
            //RubroList.Add(rubro);

            //rubro = new Rubro();
            //rubro.IdRubro = 4;
            //rubro.DescripcionRubro = "Carnes";
            //rubro.activo = true;
            //RubroList.Add(rubro);

            //rubro = new Rubro();
            //rubro.IdRubro = 5;
            //rubro.DescripcionRubro = "Quesos";
            //rubro.activo = true;
            //RubroList.Add(rubro);
            RubroBussiness RubroBiz = new RubroBussiness();
            RubroList = RubroBiz.GetRubros();
           
            gridRubroDataList.DataSource = RubroList;
            gridRubroDataList.DataBind();
        }
    }
}