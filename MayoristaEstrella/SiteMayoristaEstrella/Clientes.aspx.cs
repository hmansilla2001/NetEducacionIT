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
    public partial class Clientes : System.Web.UI.Page
    {
        List<Entidades.Cliente> clienteList = new List<Entidades.Cliente>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FillClienteGrid();
        }

        protected override void Render(HtmlTextWriter writer)
        {
            foreach (GridViewRow row in gridClientesDataList.Rows)
            {
                row.Attributes.Add("onclick", ClientScript.GetPostBackEventReference(gridClientesDataList, "Select$" + row.RowIndex.ToString(), true));
            }
            base.Render(writer);
        }

        protected void gridClientesDataList_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        private void FillClienteGrid()
        {

            ClienteBussiness clienteBiz = new ClienteBussiness();
            clienteList = clienteBiz.GetClientes();

            gridClientesDataList.DataSource = clienteList;
            gridClientesDataList.DataBind();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevoCliente.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string clienteID = null;
            if (gridClientesDataList.SelectedIndex != -1)
            {
                clienteID = gridClientesDataList.SelectedRow.Cells[0].Text;
                Response.Redirect("EditarCliente.aspx?clienteid=" + clienteID);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int ClienteId = 0;
            if (gridClientesDataList.SelectedIndex != -1)
            {
                ClienteId = Convert.ToInt32(gridClientesDataList.SelectedRow.Cells[0].Text);
                // ClienteList.RemoveAll(c => c.IdCliente == ClienteId);
                /*Response.Redirect("EliminarCliente.aspx?Clienteid=" + ClienteId);*/
                ClienteBussiness ClienteBiz = new ClienteBussiness();
                ClienteBiz.DeleteCliente(ClienteId);
                FillClienteGrid();
            }
        }
    }
}