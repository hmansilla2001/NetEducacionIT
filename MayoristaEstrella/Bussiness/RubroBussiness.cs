using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Entidades;

namespace Bussiness
{
    public class RubroBussiness
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;
        RubroDAL RubroDal = new RubroDAL();

        public List<Rubro> GetRubros()
        {
            return RubroDal.GetRubros(connectionString);
        }


        public Rubro GetRubroData(int IdRubro)
        {
            return RubroDal.GetRubroData(connectionString, IdRubro);
        }

        public void CrearRubro(Rubro Rubro)
        {
            RubroDal.CrearRubro(connectionString, Rubro);
        }

        public void EditarRubro(Rubro Rubro)
        {
            RubroDal.EditarRubro(connectionString, Rubro);
        }

        public void DeleteRubro(int RubroId)
        {
            RubroDal.DeleteRubro(connectionString, RubroId);
        }

    }
}
