using InventoryVet.ProductRegistration.BusinessObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryVet.ProductRegistration.BusinessObjects.DTOs.ProductRegistration
{
    public class CreateProductDTO
    {
        public string Name { get; }
        public string Description { get; }
        public Category IdCategory { get; }
        public uint MinStock { get; }
        public decimal Price { get; }
        public DateOnly ExpirationDate { get; }

      public CreateProductDTO(string name,
      string description,
      Category idCategory,
      uint minStock,
      decimal price,
      DateOnly expirationDate)
        {
            Name = name;
            Description = description;
            IdCategory = idCategory;
            MinStock = minStock;
            Price = price;
            ExpirationDate = expirationDate;

        }


    }
}
