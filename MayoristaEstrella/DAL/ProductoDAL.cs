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
    public class ProductoDAL
    {
        public List<Producto> GetProductos(string connectionString)
        {
            List<Producto> ProductoList = new List<Producto>();
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "Select p.IdProducto, p.Descripcion, p.PVP, ";
            selectSQL += "p.IdMarca, m.DescripcionMarca, p.IdRubro, r.DescripcionRubro, ";
            selectSQL += "p.IdUnidadMedida, u.DescripcionUnidadMedida, p.Cantidad ";
            selectSQL += "from Producto p ";
            selectSQL += "inner join Rubro r on p.IdRubro = r.IdRubro ";
            selectSQL += "inner join Marca m on m.IdMarca = p.IdMarca ";
            selectSQL += "inner join UnidadMedida u on u.IdUnidadMedida = p.IdUnidadMedida ";
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Producto Producto = new Producto();
                    Producto.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                    Producto.Descripcion = Convert.ToString(dr["Descripcion"]);
                    Producto.PVP = Convert.ToDecimal(dr["PVP"]);
                    Producto.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    Producto.rubro = new Rubro();
                    Producto.rubro.IdRubro = Convert.ToInt32(dr["IdRubro"]);
                    Producto.rubro.DescripcionRubro = Convert.ToString(dr["DescripcionRubro"]);
                    Producto.UnidadMedida = new UnidadMedida();
                    Producto.UnidadMedida.IdUnidadMedida = Convert.ToInt32(dr["IdUnidadMedida"]);
                    Producto.UnidadMedida.DescripcionUnidadMedida = Convert.ToString(dr["DescripcionUnidadMedida"]);
                    Producto.Marca = new Marca();
                    Producto.Marca.IdMarca = Convert.ToInt32(dr["IdMarca"]);
                    Producto.Marca.DescripcionMarca = Convert.ToString(dr["DescripcionMarca"]);
                    ProductoList.Add(Producto);
                }
            }
            con.Close();
            return ProductoList;
        }

        public Producto GetProductoData(string connectionString, int ProductoId)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "Select p.IdProducto, p.Descripcion, p.PVP, ";
            selectSQL += "p.IdMarca, m.DescripcionMarca, p.IdRubro, r.DescripcionRubro, ";
            selectSQL += "p.IdUnidadMedida, u.DescripcionUnidadMedida, p.Cantidad ";
            selectSQL += "from Producto p ";
            selectSQL += "inner join Rubro r on p.IdRubro = r.IdRubro ";
            selectSQL += "inner join Marca m on m.IdMarca = p.IdMarca ";
            selectSQL += "inner join UnidadMedida u on u.IdUnidadMedida = p.IdUnidadMedida ";
            selectSQL += "where p.IdProducto = " + ProductoId;
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            Producto Producto = new Producto();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Producto.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                    Producto.Descripcion = Convert.ToString(dr["Descripcion"]);
                    Producto.PVP = Convert.ToDecimal(dr["PVP"]);
                    Producto.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    Producto.rubro = new Rubro();
                    Producto.rubro.IdRubro = Convert.ToInt32(dr["IdRubro"]);
                    Producto.rubro.DescripcionRubro = Convert.ToString(dr["DescripcionRubro"]);
                    Producto.UnidadMedida = new UnidadMedida();
                    Producto.UnidadMedida.IdUnidadMedida = Convert.ToInt32(dr["IdUnidadMedida"]);
                    Producto.UnidadMedida.DescripcionUnidadMedida = Convert.ToString(dr["DescripcionUnidadMedida"]);
                    Producto.Marca = new Marca();
                    Producto.Marca.IdMarca = Convert.ToInt32(dr["IdMarca"]);
                    Producto.Marca.DescripcionMarca = Convert.ToString(dr["DescripcionMarca"]);
                }
            }
            con.Close();
            return Producto;
        }

        public void CrearProducto(string connectionString, Producto Producto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("CrearProducto", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Descripcion", Producto.Descripcion));
                    cmd.Parameters.Add(new SqlParameter("@IdRubro", Producto.rubro.IdRubro));
                    cmd.Parameters.Add(new SqlParameter("@IdMarca", Producto.Marca.IdMarca));
                    cmd.Parameters.Add(new SqlParameter("@IdUnidadMedida", Producto.UnidadMedida.IdUnidadMedida));
                    cmd.Parameters.Add(new SqlParameter("@PVP", Producto.PVP));
                    cmd.Parameters.Add(new SqlParameter("@Cantidad", Producto.Cantidad));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void EditarProducto(string connectionString, Producto Producto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateProducto", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IdProducto", Producto.IdProducto));
                    cmd.Parameters.Add(new SqlParameter("@Descripcion", Producto.Descripcion));
                    cmd.Parameters.Add(new SqlParameter("@IdRubro", Producto.rubro.IdRubro));
                    cmd.Parameters.Add(new SqlParameter("@IdMarca", Producto.Marca.IdMarca));
                    cmd.Parameters.Add(new SqlParameter("@IdUnidadMedida", Producto.UnidadMedida.IdUnidadMedida));
                    cmd.Parameters.Add(new SqlParameter("@PVP", Producto.PVP));
                    cmd.Parameters.Add(new SqlParameter("@Cantidad", Producto.Cantidad));
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

        public void DeleteProducto(string connectionString, int IdProducto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteProducto", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IdProducto", IdProducto));;
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
