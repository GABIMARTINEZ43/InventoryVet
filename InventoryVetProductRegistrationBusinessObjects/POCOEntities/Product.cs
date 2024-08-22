using InventoryVet.ProductRegistration.BusinessObjects.DTOs.ProductRegistration;
using InventoryVet.ProductRegistration.BusinessObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryVet.ProductRegistration.BusinessObjects.POCOEntities
{
    public class Product
    {

        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category IdCategory { get; set; } 
        public uint MinStock { get; set; }
        public decimal Price { get; set; }
        public DateOnly ExpirationDate { get; set; }


    }
}
