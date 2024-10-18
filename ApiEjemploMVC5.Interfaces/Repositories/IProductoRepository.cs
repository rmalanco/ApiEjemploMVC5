using ApiEjemploMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiEjemploMVC5.Interfaces.Repositories
{
    public interface IProductoRepository : IRepository<Producto>
    {
        void Update(Producto producto);
    }
}
