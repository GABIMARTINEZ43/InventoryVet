using InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Ports;
using InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Presenters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryVet.CreateProduct.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresentersServices(
            this IServiceCollection services)
        {
            services.AddScoped<CreateProductPresenter>();


            services.AddScoped<ICreateProductPresenter>(
                provider => provider.GetService<CreateProductPresenter>());
                

            services.AddScoped<ICreateProductOutputPort>(
                provider => provider.GetService<CreateProductPresenter>());



            return services;


        }

    }
}
