using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMayoristaEstrella
{
    public partial class Compras : System.Web.UI.Page
    {
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                this.lblMensaje.Text = "sin un mecanismo auxiliar es imposible mantener el estado de la variable";
            }
        }

        protected void btnPostback_Click(object sender, EventArgs e)
        {
            i++;
            this.lblContador.Text = "Valor de la variable: " + i.ToString();
        }
    }
}