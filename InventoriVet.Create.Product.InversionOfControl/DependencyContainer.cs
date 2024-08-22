using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using InventoriVet.EFCore.Repositories;
using InventoryVet.CreateProduct.UseCases;
using InventoryVet.CreateProduct.Presenters;
using InventoryVet.CreateProduct.Controllers;

namespace InventoriVet.Create.Product.InversionOfControl
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddInventoriVetCreateProductServices(
            this IServiceCollection services,
            IConfiguration configuration,
            string connectionStringName)
        {

            services
                .AddRepositories(configuration, connectionStringName)
                .AddUseCasesServices()
                .AddPresentersServices()
                .AddInventoriVetCreateProductControllers();

            return services;


        }

    }
}





