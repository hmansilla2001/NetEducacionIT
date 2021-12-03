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
    public class UnidadMedidaBussiness
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;
        UnidadMedidaDAL UnidadMedidaDal = new UnidadMedidaDAL();

        public List<UnidadMedida> GetUnidadMedidas()
        {
            return UnidadMedidaDal.GetUnidadMedidas(connectionString);
        }


        public UnidadMedida GetUnidadMedidaData(int IdUnidadMedida)
        {
            return UnidadMedidaDal.GetUnidadMedidaData(connectionString, IdUnidadMedida);
        }

        public void CrearUnidadMedida(UnidadMedida UnidadMedida)
        {
            UnidadMedidaDal.CrearUnidadMedida(connectionString, UnidadMedida);
        }

        public void EditarUnidadMedida(UnidadMedida UnidadMedida)
        {
            UnidadMedidaDal.EditarUnidadMedida(connectionString, UnidadMedida);
        }

        public void DeleteUnidadMedida(int UnidadMedidaId)
        {
            UnidadMedidaDal.DeleteUnidadMedida(connectionString, UnidadMedidaId);
        }
    }
}
