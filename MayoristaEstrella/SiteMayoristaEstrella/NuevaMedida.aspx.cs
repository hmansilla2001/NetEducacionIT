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
    public partial class NuevaMedida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            UnidadMedidaBussiness UnidadMedidaBiz = new UnidadMedidaBussiness();

            Entidades.UnidadMedida UnidadMedida = new Entidades.UnidadMedida();

            UnidadMedida.DescripcionUnidadMedida = this.txtDescripcion.Text;

            UnidadMedidaBiz.CrearUnidadMedida(UnidadMedida);

            // mostrar mensaje
            Response.Redirect("Medidas.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            // mostrar mensaje
            Response.Redirect("Medidas.aspx");
        }
    }
}