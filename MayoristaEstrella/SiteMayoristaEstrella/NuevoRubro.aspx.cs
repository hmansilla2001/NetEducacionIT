using Bussiness;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMayoristaEstrella
{
    public partial class NuevoRubro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            RubroBussiness RubroBiz = new RubroBussiness();

            Entidades.Rubro Rubro = new Entidades.Rubro();

            Rubro.DescripcionRubro = this.txtDescripcion.Text;

            RubroBiz.CrearRubro(Rubro);

            // mostrar mensaje
            Response.Redirect("Rubros.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

            // mostrar mensaje
            Response.Redirect("Rubros.aspx");
        }
    }
}