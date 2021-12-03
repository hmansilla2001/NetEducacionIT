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
    public partial class NuevoProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCombos();
            }
        }

        private void CargarCombos()
        {
            MarcaBussiness marcaBiz = new MarcaBussiness();
            RubroBussiness rubroBiz = new RubroBussiness();
            UnidadMedidaBussiness unidadMedidaBiz = new UnidadMedidaBussiness();

            this.comboMarca.DataSource = marcaBiz.GetMarcas();
            this.comboMarca.DataValueField = "IdMarca";
            this.comboMarca.DataTextField = "DescripcionMarca";
            this.comboMarca.DataBind();
            this.comboMarca.Items.Insert(0, new ListItem("Elija una opcion..", "0"));

            this.comboRubro.DataSource = rubroBiz.GetRubros();
            this.comboRubro.DataValueField = "IdRubro";
            this.comboRubro.DataTextField = "DescripcionRubro";
            this.comboRubro.DataBind();
            this.comboRubro.Items.Insert(0, new ListItem("Elija una opcion..", "0"));

            this.ComboUnidadMedida.DataSource = unidadMedidaBiz.GetUnidadMedidas();
            this.ComboUnidadMedida.DataValueField = "IdUnidadMedida";
            this.ComboUnidadMedida.DataTextField = "DescripcionUnidadMedida";
            this.ComboUnidadMedida.DataBind();
            this.ComboUnidadMedida.Items.Insert(0, new ListItem("Elija una opcion..", "0"));
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductoBussiness productoBiz = new ProductoBussiness();
            Producto producto = new Producto();

            producto.Descripcion = this.txtDescripcion.Text;
            producto.PVP = Convert.ToDecimal(this.txtPVP.Text);
            producto.Cantidad = Convert.ToInt32(this.txtCantidad.Text);
            producto.rubro = new Rubro();
            producto.rubro.IdRubro = int.Parse(this.comboRubro.SelectedValue);
            producto.Marca = new Marca();
            producto.Marca.IdMarca = int.Parse(this.comboMarca.SelectedValue);
            producto.UnidadMedida = new UnidadMedida();
            producto.UnidadMedida.IdUnidadMedida = int.Parse(this.ComboUnidadMedida.SelectedValue);

            productoBiz.CrearProducto(producto);

            Response.Redirect("~/Productos.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Productos.aspx");
        }
    }
}