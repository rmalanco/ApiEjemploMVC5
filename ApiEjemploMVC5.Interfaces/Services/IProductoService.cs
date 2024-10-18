using ApiEjemploMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEjemploMVC5.Interfaces.Services
{
    public interface IProductoService
    {
        IEnumerable<Producto> GetAllProductos();
        Producto GetProductoById(int id);
        void CreateProducto(Producto producto);
        void UpdateProducto(Producto producto);
        void DeleteProducto(int id);
    }
}
