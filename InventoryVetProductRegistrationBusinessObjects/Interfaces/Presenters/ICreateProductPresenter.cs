using InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Presenters
{
    public interface ICreateProductPresenter : ICreateProductOutputPort
    {
        uint Id { get; }

    }
}
