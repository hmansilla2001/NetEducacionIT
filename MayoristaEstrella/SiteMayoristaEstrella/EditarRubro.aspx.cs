using Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMayoristaEstrella
{
    public partial class EditarRubro : System.Web.UI.Page
    {
        int RubroId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["rubroid"] != "")
                RubroId = Convert.ToInt16(Request.QueryString["rubroid"]);
            else
                Response.Redirect("Rubros.aspx");

            if (!IsPostBack)
            {
                FillRubroData();
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            RubroBussiness RubroBiz = new RubroBussiness();

            Entidades.Rubro Rubro = new Entidades.Rubro();
            Rubro.IdRubro = this.RubroId;

            Rubro.DescripcionRubro = this.txtDescripcion.Text;

            RubroBiz.EditarRubro(Rubro);

            // mostrar mensaje
            Response.Redirect("Rubros.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            // mostrar mensaje
            Response.Redirect("Rubros.aspx");
        }

        private void FillRubroData()
        {
            RubroBussiness RubroBiz = new RubroBussiness();

            Entidades.Rubro Rubro = new Entidades.Rubro();

            Rubro = RubroBiz.GetRubroData(RubroId);

            this.txtDescripcion.Text = Rubro.DescripcionRubro;
        }
    }
}