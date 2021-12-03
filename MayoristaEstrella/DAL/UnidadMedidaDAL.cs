using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UnidadMedidaDAL
    {
       public List<UnidadMedida> GetUnidadMedidas(string connectionString)
        {
            List<UnidadMedida> UnidadMedidaList = new List<UnidadMedida>();
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select IDUnidadMedida, DescripcionUnidadMedida from UnidadMedida";

            con.Open();
            SqlCommand command = new SqlCommand(selectSQL, con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    UnidadMedida unidadMedida = new UnidadMedida();
                    unidadMedida.IdUnidadMedida = Convert.ToInt32(dr["IDUnidadMedida"]);
                    unidadMedida.DescripcionUnidadMedida = Convert.ToString(dr["DescripcionUnidadMedida"]);
                    UnidadMedidaList.Add(unidadMedida);
                }
            }

            con.Close();

            return UnidadMedidaList;
        }

        public UnidadMedida GetUnidadMedidaData(string connectionString, int UnidadMedidaId)
        {
            UnidadMedida UnidadMedida = new UnidadMedida();

            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select IDUnidadMedida, DescripcionUnidadMedida from UnidadMedida where IDUnidadMedida=" + UnidadMedidaId;

            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    UnidadMedida.IdUnidadMedida = Convert.ToInt32(dr["IDUnidadMedida"]);
                    UnidadMedida.DescripcionUnidadMedida = Convert.ToString(dr["DescripcionUnidadMedida"]);

                }
            }

            con.Close();

            return UnidadMedida;
        }

        public void CrearUnidadMedida(string connectionString, UnidadMedida UnidadMedida)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("CrearUnidadMedida", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@DescripcionUnidadMedida", UnidadMedida.DescripcionUnidadMedida));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EditarUnidadMedida(string connectionString, UnidadMedida UnidadMedida)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateUnidadMedida", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IdUnidadMedida", UnidadMedida.IdUnidadMedida));

                    cmd.Parameters.Add(new SqlParameter("@DescripcionUnidadMedida", UnidadMedida.DescripcionUnidadMedida));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void DeleteUnidadMedida(string connectionString, int UnidadMedidaId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteUnidadMedida", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IdUnidadMedida", UnidadMedidaId));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
