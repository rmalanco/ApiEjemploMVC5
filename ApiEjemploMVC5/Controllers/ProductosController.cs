using ApiEjemploMVC5.Interfaces.Services;
using ApiEjemploMVC5.Models;
using System.Web.Http;

namespace ApiEjemploMVC5.Controllers
{
    public class ProductosController : ApiController
    {
        private readonly IProductoService _productoService;

        public ProductosController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        // GET: api/Productos
        [HttpGet]
        [Route("api/Productos")]
        public IHttpActionResult GetAllProductos()
        {
            var productos = _productoService.GetAllProductos();

            if (productos == null)
            {
                return NotFound();
            }

            return Ok(new { IsSuccess = true, Data = productos });
        }

        // GET: api/Productos/1
        [HttpGet]
        [Route("api/Productos/{id}")]
        public IHttpActionResult GetProductoById(int id)
        {
            var producto = _productoService.GetProductoById(id);

            if (producto == null)
            {
                return NotFound();
            }

            return Ok(new { IsSuccess = true, Data = producto });
        }

        // POST: api/Productos
        [HttpPost]
        [Route("api/Productos")]
        public IHttpActionResult CreateProducto([FromBody] Producto producto)
        {
            if (producto == null)
            {
                return BadRequest();
            }

            _productoService.CreateProducto(producto);

            return Ok(new { IsSuccess = true, Message = "Producto creado correctamente" });
        }

        // POST: api/Productos/1
        [HttpPut]
        [Route("api/Productos/{id}")]
        public IHttpActionResult UpdateProducto(int id, [FromBody] Producto producto)
        {
            if (producto == null)
            {
                return BadRequest();
            }

            var productoExistente = _productoService.GetProductoById(id);

            if (productoExistente == null)
            {
                return NotFound();
            }

            producto.Id = id;
            _productoService.UpdateProducto(producto);

            return Ok(new { IsSuccess = true, Message = "Producto actualizado correctamente" });
        }

        // DELETE: api/Productos/1
        [HttpDelete]
        [Route("api/Productos/{id}")]
        public IHttpActionResult DeleteProducto(int id)
        {
            var producto = _productoService.GetProductoById(id);

            if (producto == null)
            {
                return NotFound();
            }

            _productoService.DeleteProducto(id);

            return Ok(new { IsSuccess = true, Message = "Producto eliminado correctamente" });
        }
    }
}
