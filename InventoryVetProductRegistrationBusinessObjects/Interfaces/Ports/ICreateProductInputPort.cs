using InventoryVet.ProductRegistration.BusinessObjects.DTOs.ProductRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Ports
{
    public interface ICreateProductInputPort
    {

        Task Handle(CreateProductDTO createProductDTO);


    }
}
