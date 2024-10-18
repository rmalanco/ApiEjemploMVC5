using ApiEjemploMVC5.Interfaces;
using ApiEjemploMVC5.Interfaces.Services;
using ApiEjemploMVC5.Models;
using System.Collections.Generic;

namespace ApiEjemploMVC5.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IUnitOfWorkService _unitOfWorkService;

        public ProductoService(IUnitOfWorkService unitOfWorkService)
        {
            _unitOfWorkService = unitOfWorkService;
        }

        public void CreateProducto(Producto producto)
        {
            _unitOfWorkService.Producto.Add(producto);
            _unitOfWorkService.Save();
        }

        public void DeleteProducto(int id)
        {
            var producto = _unitOfWorkService.Producto.GetById(id);
            _unitOfWorkService.Producto.Delete(producto);
            _unitOfWorkService.Save();
        }

        public IEnumerable<Producto> GetAllProductos()
        {
            return _unitOfWorkService.Producto.GetAll();
        }

        public Producto GetProductoById(int id)
        {
            return _unitOfWorkService.Producto.GetById(id);
        }

        public void UpdateProducto(Producto producto)
        {
            _unitOfWorkService.Producto.Update(producto);
            _unitOfWorkService.Save();
        }
    }
}
