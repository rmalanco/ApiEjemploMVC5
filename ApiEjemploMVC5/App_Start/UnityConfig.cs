using ApiEjemploMVC5.Data;
using ApiEjemploMVC5.Interfaces;
using ApiEjemploMVC5.Interfaces.Services;
using ApiEjemploMVC5.Models;
using ApiEjemploMVC5.Repositories;
using ApiEjemploMVC5.Services;
using System.Web.Http;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;

namespace ApiEjemploMVC5
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // Primero el DbContext
            container.RegisterType<AppDbContext>(new HierarchicalLifetimeManager());

            // Registrar repositorios
            RegisterRepositories(container);

            // Registrar servicios
            RegisterServices(container);

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        private static void RegisterRepositories(IUnityContainer container)
        {
            container.RegisterType<IRepository<Producto>, ProductoRepository>();
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<IUnitOfWorkService, UnitOfWorkService>();
            container.RegisterType<IProductoService, ProductoService>();
        }
    }
}