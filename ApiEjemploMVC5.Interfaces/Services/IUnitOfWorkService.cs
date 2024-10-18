using ApiEjemploMVC5.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEjemploMVC5.Interfaces.Services
{
    public interface IUnitOfWorkService : IDisposable
    {
        IProductoRepository Producto { get; }
        void Save();
    }
}
