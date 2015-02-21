[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(FactoryManagementSystem.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(FactoryManagementSystem.App_Start.NinjectWebCommon), "Stop")]

namespace FactoryManagementSystem.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using FactoryManagementSystem.Models;
    using MvcApplication3.Models;
    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<FactoryManagementSystem.Models.IrawmaterialRepo>().To<FactoryManagementSystem.Models.rawMaterialRepo>();
            kernel.Bind<IinventoryRepo>().To<InventoryRepo>();
            kernel.Bind<FactoryManagementSystem.Models.IEmployeeRepo>().To<FactoryManagementSystem.Models.EmployeeRepo>();
            kernel.Bind<IStockRepo>().To<StockRepo>();
            kernel.Bind<IProductRepo>().To<ProductRepo>();
            kernel.Bind<IDetails>().To<Details>();
            kernel.Bind<IGraph>().To<Graph>();
            kernel.Bind<IEdit>().To<Edit>();
        }        
    }
}
