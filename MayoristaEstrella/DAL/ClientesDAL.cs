using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class ClientesDAL
    {
        public List<Cliente> GetClientes(string connectionString)
        {
            List<Cliente> clientesList = new List<Cliente>();
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select [IdCliente],[NombreApellido],[Domicilio],[DNI],[Telefono],[Celular],[Mail] from Cliente";

            con.Open();
            SqlCommand command = new SqlCommand(selectSQL, con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    cliente.NombreApellido = Convert.ToString(dr["NombreApellido"]);
                    cliente.Domicilio = Convert.ToString(dr["Domicilio"]);
                    cliente.DNI = Convert.ToString(dr["DNI"]);
                    cliente.Telefono = Convert.ToString(dr["Telefono"]);
                    cliente.Celular = Convert.ToString(dr["Celular"]);
                    cliente.Mail = Convert.ToString(dr["Mail"]);
                    clientesList.Add(cliente);
                }
            }

            con.Close();

            return clientesList;
        }

        public Cliente GetClienteData(string connectionString, int clienteId)
        {
            Cliente cliente = new Cliente();

            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select [IdCliente],[NombreApellido],[Domicilio],[DNI],[Telefono],[Celular],[Mail] from Cliente where IdCliente=" + clienteId;

            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    cliente.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    cliente.NombreApellido = Convert.ToString(dr["NombreApellido"]);
                    cliente.Domicilio = Convert.ToString(dr["Domicilio"]);
                    cliente.DNI = Convert.ToString(dr["DNI"]);
                    cliente.Telefono = Convert.ToString(dr["Telefono"]);
                    cliente.Celular = Convert.ToString(dr["Celular"]);
                    cliente.Mail = Convert.ToString(dr["Mail"]);

                }
            }

            con.Close();

            return cliente;
        }

        public void CrearCliente(string connectionString, Cliente cliente)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("CrearCliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@NombreApellido", cliente.NombreApellido));
                    cmd.Parameters.Add(new SqlParameter("@Domicilio", cliente.Domicilio));
                    cmd.Parameters.Add(new SqlParameter("@DNI", cliente.DNI));
                    cmd.Parameters.Add(new SqlParameter("@Telefono", cliente.Telefono));
                    cmd.Parameters.Add(new SqlParameter("@Celular", cliente.Celular));
                    cmd.Parameters.Add(new SqlParameter("@mail", cliente.Mail));

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

        public void EditarCliente(string connectionString, Cliente cliente)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateCliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IdCliente", cliente.IdCliente));
                    cmd.Parameters.Add(new SqlParameter("@NombreApellido", cliente.NombreApellido));
                    cmd.Parameters.Add(new SqlParameter("@Domicilio", cliente.Domicilio));
                    cmd.Parameters.Add(new SqlParameter("@DNI", cliente.DNI));
                    cmd.Parameters.Add(new SqlParameter("@Telefono", cliente.Telefono));
                    cmd.Parameters.Add(new SqlParameter("@Celular", cliente.Celular));
                    cmd.Parameters.Add(new SqlParameter("@mail", cliente.Mail));

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

        public void DeleteCliente(string connectionString, int clienteId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteCliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IdCliente", clienteId));

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
