using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMayoristaEstrella
{
    public partial class Bienvenidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DropDownList1.Items.Add("Ezeiza");
                DropDownList1.Items.Add("Lomas de zamora");
                DropDownList1.Items.Add("Lanus");
                DropDownList1.Items.Add("CABA");
            }
          
        }

        protected void btnBienvenida_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Bienvenido " + txtNombre.Text;
        }
    }
}