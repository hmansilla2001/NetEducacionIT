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
    public class RubroDAL
    {
        public List<Rubro> GetRubros(string connectionString)
        {
            List<Rubro> RubrosList = new List<Rubro>();

            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select IdRubro, DescripcionRubro from Rubro";

            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Rubro Rubro = new Rubro();
                    Rubro.IdRubro = Convert.ToInt32(dr["IdRubro"]);
                    Rubro.DescripcionRubro = Convert.ToString(dr["DescripcionRubro"]);
                    RubrosList.Add(Rubro);
                }
            }

            con.Close();

            return RubrosList;
        }


        public Rubro GetRubroData(string connectionString, int RubroId)
        {
            Rubro Rubro = new Rubro();

            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select IdRubro, DescripcionRubro from Rubro where IdRubro=" + RubroId;

            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Rubro.IdRubro = Convert.ToInt32(dr["IdRubro"]);
                    Rubro.DescripcionRubro = Convert.ToString(dr["DescripcionRubro"]);

                }
            }


            return Rubro;
        }

        public void CrearRubro(string connectionString, Rubro Rubro)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("CrearRubro", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@DescripcionRubro", Rubro.DescripcionRubro));

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

        public void EditarRubro(string connectionString, Rubro Rubro)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateRUBRO", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IdRubro", Rubro.IdRubro));

                    cmd.Parameters.Add(new SqlParameter("@DescripcionRubro", Rubro.DescripcionRubro));

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

        public void DeleteRubro(string connectionString, int RubroId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteRubro", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IdRubro", RubroId));

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
