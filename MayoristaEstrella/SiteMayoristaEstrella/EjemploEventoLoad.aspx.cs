using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMayoristaEstrella
{
    public partial class EjemploEventoLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblBienvenida.Text = "Bienvenidos al curso de .Net Asp.net C#";
        }

        protected void btnMostrarMensaje_Click(object sender, EventArgs e)
        {
            this.lblBienvenida2.Text = "Bienvenido: " + txtNombre.Text;

        }
    }
}