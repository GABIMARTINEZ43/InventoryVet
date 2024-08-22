using InventoriVet.EFCore.Repositories.DataContext;
using InventoriVet.EFCore.Repositories.Repositories;
using InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Ports;
using InventoryVet.ProductRegistration.BusinessObjects.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoriVet.EFCore.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services,
            IConfiguration configuration,
            string connectionStringName)
        {
            services.AddDbContext<InventoryVetProductRegistrationContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString(connectionStringName)));


            services.AddScoped<ICommandRepository,
                InventoryVetCreateProductCommandsRepository>();
            return services;


        }

    }
}
