using ApiEjemploMVC5.Data;
using ApiEjemploMVC5.Interfaces.Repositories;
using ApiEjemploMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEjemploMVC5.Repositories
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        private readonly AppDbContext _db;
        public ProductoRepository(AppDbContext context) : base(context)
        {
            _db = context;
        }

        public void Update(Producto producto)
        {
            var obj = _db.Productos.FirstOrDefault(x => x.Id == producto.Id);
            if (obj != null)
            {
                obj.Nombre = producto.Nombre;
                obj.Precio = producto.Precio;
                _db.SaveChanges();
            }
        }
    }
}
