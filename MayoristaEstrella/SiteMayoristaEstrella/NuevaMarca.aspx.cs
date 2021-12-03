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
    public partial class NuevaMarca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaBussiness marcaBiz = new MarcaBussiness();
            Marca marca = new Marca();
            marca.DescripcionMarca = this.txtDescripcion.Text;
            marcaBiz.CrearMarca(marca);

            Response.Redirect("~/Marcas.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Marcas.aspx");
        }
    }
}