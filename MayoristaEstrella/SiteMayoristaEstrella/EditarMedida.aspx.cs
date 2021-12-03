using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussiness;

namespace SiteMayoristaEstrella
{
    public partial class EditarMedida : System.Web.UI.Page
    {
        int MedidaId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["medidaid"] != "")
                MedidaId = Convert.ToInt16(Request.QueryString["medidaid"]);
            else
                Response.Redirect("Medidas.aspx");

            if (!IsPostBack)
            {
                FillMedidasData();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            UnidadMedidaBussiness UnidadMedidaBiz = new UnidadMedidaBussiness();

            Entidades.UnidadMedida UnidadMedida = new Entidades.UnidadMedida();
            UnidadMedida.IdUnidadMedida = this.MedidaId;

            UnidadMedida.DescripcionUnidadMedida = this.txtDescripcion.Text;

            UnidadMedidaBiz.EditarUnidadMedida(UnidadMedida);

            // mostrar mensaje
            Response.Redirect("Medidas.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            // mostrar mensaje
            Response.Redirect("Medidas.aspx");
        }

        private void FillMedidasData()
        {
            UnidadMedidaBussiness UnidadMedidaBiz = new UnidadMedidaBussiness();

            Entidades.UnidadMedida UnidadMedida = new Entidades.UnidadMedida();

            UnidadMedida = UnidadMedidaBiz.GetUnidadMedidaData(MedidaId);

            this.txtDescripcion.Text = UnidadMedida.DescripcionUnidadMedida;
        }
    }
}