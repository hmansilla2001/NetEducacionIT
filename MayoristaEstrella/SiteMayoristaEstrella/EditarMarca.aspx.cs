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
    public partial class EditarMarca : System.Web.UI.Page
    {
        int marcaId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["marcaId"] != "")
            {
                marcaId = Convert.ToInt32(Request.QueryString["marcaId"]);
            }
            else
            {
                Response.Redirect("~/Marcas.aspx");
            }
            if (!IsPostBack)
            {
                FillMarcaData();
            }
        }
        private void FillMarcaData()
        {
            MarcaBussiness marcaBiz = new MarcaBussiness();
            Marca marca = new Marca();
            marca = marcaBiz.GetMarcaData(marcaId);
            this.txtDescripcion.Text = marca.DescripcionMarca;
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaBussiness marcaBiz = new MarcaBussiness();
            Marca marca = new Marca();
            marca.IdMarca = this.marcaId;
            marca.DescripcionMarca = this.txtDescripcion.Text;
            marcaBiz.EditarMarca(marca);

            Response.Redirect("~/Marcas.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Marcas.aspx");
        }
    }
}