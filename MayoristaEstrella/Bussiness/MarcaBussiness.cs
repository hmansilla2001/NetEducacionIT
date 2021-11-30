using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DAL;
using Entidades;

namespace Bussiness
{
    public class MarcaBussiness
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;
        MarcaDAL MarcaDal = new MarcaDAL();
        public List<Marca> GetMarcas()
        {
            return MarcaDal.GetMarcas(connectionString);
        }

        public void CrearMarca(Marca marca)
        {
            MarcaDal.CrearMarca(connectionString, marca);
        }

        public Marca GetMarcaData(int MarcaId)
        {
            return MarcaDal.GetMarcaData(connectionString, MarcaId);
        }

        public void EditarMarca(Marca marca)
        {
            MarcaDal.EditarMarca(connectionString, marca);
        }

        public void DeleteMarca(int MarcaId)
        {
            MarcaDal.DeleteMarca(connectionString, MarcaId);
        }
    }
}
