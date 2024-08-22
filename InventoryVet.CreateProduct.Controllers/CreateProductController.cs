using InventoryVet.ProductRegistration.BusinessObjects.DTOs.ProductRegistration;
using InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Controllers;
using InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Ports;
using InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryVet.CreateProduct.Controllers
{
    public class CreateProductController : ICreateProductController
    {
        readonly ICreateProductInputPort _inputPort;
        readonly ICreateProductPresenter _presenter;

        public CreateProductController(ICreateProductInputPort inputPort, 
            ICreateProductPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<uint> CreateProduct(CreateProductDTO product)
        {
            await _inputPort.Handle(product);
            return _presenter.Id;
        }


    }
}
