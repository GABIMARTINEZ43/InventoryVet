using InventoryVet.CreateProduct.UseCases.CreateProduct;
using InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Ports;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryVet.CreateProduct.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(
            this IServiceCollection services)
        {

            services.AddScoped<ICreateProductInputPort, CreateProductInteractor>();
            return services;


        }

    }
}
