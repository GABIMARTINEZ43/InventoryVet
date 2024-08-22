using InventoryVet.Entities;
using InventoryVet.ProductRegistration.BusinessObjects.POCOEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryVet.ProductRegistration.BusinessObjects.Repositories
{
    public interface ICommandRepository : IUnitOfWork
    {
        Task CreateProduct(Product product);

    }
}
