using InventoryVet.ProductRegistration.BusinessObjects.POCOEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Ports
{
    public interface ICreateProductOutputPort
    {
            Task Handle(uint  Id);

    }
}
 