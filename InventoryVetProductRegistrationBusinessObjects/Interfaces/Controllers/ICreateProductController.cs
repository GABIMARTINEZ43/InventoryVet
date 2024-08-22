using InventoryVet.ProductRegistration.BusinessObjects.DTOs.ProductRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Controllers
{
    public interface ICreateProductController
    {
        ValueTask<uint> CreateProduct(CreateProductDTO product);   

    }
}
