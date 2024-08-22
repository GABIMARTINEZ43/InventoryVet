using InventoryVet.ProductRegistration.BusinessObjects.DTOs.ProductRegistration;
using InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Ports;
using InventoryVet.ProductRegistration.BusinessObjects.POCOEntities;
using InventoryVet.ProductRegistration.BusinessObjects.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryVet.CreateProduct.UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        readonly ICreateProductOutputPort _presenter;
        readonly ICommandRepository _repository;

        public CreateProductInteractor(ICreateProductOutputPort outputPort, ICommandRepository repository)
        {
            _presenter = outputPort;
            _repository = repository;
        }
        public async Task Handle(CreateProductDTO createProductDTO)
        {
            Product product = new Product()
            {
                Name = createProductDTO.Name,
                Description = createProductDTO.Description,
                IdCategory = createProductDTO.IdCategory,
                MinStock = createProductDTO.MinStock,
                Price = createProductDTO.Price,
                ExpirationDate = createProductDTO.ExpirationDate,

            };

            await _repository.CreateProduct(product);
            await _repository.SaveChanges();
            await _presenter.Handle(product.Id);

        }
    }
}
