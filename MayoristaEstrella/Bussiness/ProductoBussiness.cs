using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Entidades;
using DAL;

namespace Bussiness
{
    public class ProductoBussiness
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;
        ProductoDAL ProductoDAL = new ProductoDAL();

        public List<Producto> GetProductos()
        {
            return ProductoDAL.GetProductos(connectionString);
        }


        public Producto GetProductoData(int IdProducto)
        {
            return ProductoDAL.GetProductoData(connectionString, IdProducto);
        }

        public void CrearProducto(Producto Producto)
        {
            ProductoDAL.CrearProducto(connectionString, Producto);
        }

        public void EditarProducto(Producto Producto)
        {
            ProductoDAL.EditarProducto(connectionString, Producto);
        }

        public void DeleteProducto(int ProductoId)
        {
            ProductoDAL.DeleteProducto(connectionString, ProductoId);
        }
    }
}
