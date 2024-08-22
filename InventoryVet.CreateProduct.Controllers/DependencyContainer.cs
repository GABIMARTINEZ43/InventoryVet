using InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryVet.CreateProduct.Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddInventoriVetCreateProductControllers(
            this IServiceCollection services)
        {

            services.AddScoped<ICreateProductController, 
                CreateProductController>();

            return services;


        }

    }
}
