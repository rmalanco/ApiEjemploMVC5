using ApiEjemploMVC5.Data;
using ApiEjemploMVC5.Interfaces.Repositories;
using ApiEjemploMVC5.Interfaces.Services;
using ApiEjemploMVC5.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEjemploMVC5.Services
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly AppDbContext _db;
        public IProductoRepository Producto { get; private set; }

        public UnitOfWorkService(AppDbContext db)
        {
            _db = db;
            Producto = new ProductoRepository(_db);
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
