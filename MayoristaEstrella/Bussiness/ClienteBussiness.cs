using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class ClienteBussiness
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;
        ClientesDAL clienteDal = new ClientesDAL();

        public List<Cliente> GetClientes()
        {
            return clienteDal.GetClientes(connectionString);
        }


        public Cliente GetClienteData(int IdCliente)
        {
            return clienteDal.GetClienteData(connectionString, IdCliente);
        }

        public void CrearCliente(Cliente Cliente)
        {
            clienteDal.CrearCliente(connectionString, Cliente);
        }

        public void EditarCliente(Cliente Cliente)
        {
            clienteDal.EditarCliente(connectionString, Cliente);
        }

        public void DeleteCliente(int ClienteId)
        {
            clienteDal.DeleteCliente(connectionString, ClienteId);
        }
    }
}
