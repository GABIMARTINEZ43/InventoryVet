using InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Ports;
using InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Presenters;
using InventoryVet.ProductRegistration.BusinessObjects.POCOEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryVet.CreateProduct.Presenters
{
    public class CreateProductPresenter : ICreateProductPresenter
    {
        public uint Id { get; private set; }

        public Task Handle(uint _id)
        {
            Id = _id;
            return Task.CompletedTask;
        }
    }
}
