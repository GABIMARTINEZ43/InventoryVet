using InventoriVet.EFCore.Repositories.DataContext;
using InventoryVet.ProductRegistration.BusinessObjects.POCOEntities;
using InventoryVet.ProductRegistration.BusinessObjects.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoriVet.EFCore.Repositories.Repositories
{
    public class InventoryVetCreateProductCommandsRepository : ICommandRepository
    {
        readonly InventoryVetProductRegistrationContext _context;

        public InventoryVetCreateProductCommandsRepository(InventoryVetProductRegistrationContext context)
        {
            _context = context;
        }

        public async Task CreateProduct(Product product)
        {
            await _context.AddAsync(product);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
