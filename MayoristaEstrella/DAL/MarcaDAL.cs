using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MarcaDAL
    {
        public List<Marca> GetMarcas(string connectionString)
        {
            List<Marca> marcaList = new List<Marca>();
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select IdMarca, DescripcionMarca from Marca";
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Marca marca = new Marca();
                    marca.IdMarca = Convert.ToInt32(dr["IdMarca"]);
                    marca.DescripcionMarca = Convert.ToString(dr["DescripcionMarca"]);
                    marcaList.Add(marca);
                }
            }
            con.Close();
            return marcaList;
        }

        public Marca GetMarcaData(string connectionString, int marcaId)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select IdMarca, DescripcionMarca from Marca where IdMarca = " + marcaId;
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            Marca marca = new Marca();
            if (dr != null)
            {
                while (dr.Read())
                {

                    marca.IdMarca = Convert.ToInt32(dr["IdMarca"]);
                    marca.DescripcionMarca = Convert.ToString(dr["DescripcionMarca"]);
                }
            }
            con.Close();
            return marca;
        }

        public void EditarMarca(string connectionString, Marca marca)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateMarca", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IDMarca", marca.IdMarca));
                    cmd.Parameters.Add(new SqlParameter("@DescripcionMarca", marca.DescripcionMarca));

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

        public void CrearMarca(string connectionString, Marca marca)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("CrearMarca", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@DescripcionMarca", marca.DescripcionMarca));

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

        public void DeleteMarca(string connectionString, int marcaId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteMarca", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IDMarca", marcaId));

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
