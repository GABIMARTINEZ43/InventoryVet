using InventoryVet.ProductRegistration.BusinessObjects.Enums;
using InventoryVet.ProductRegistration.BusinessObjects.POCOEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace InventoriVet.EFCore.Repositories.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> product)
        {
            product.Property(p => p.Id)
                .IsRequired();


            product.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);


            product.Property(p => p.Description)
                .IsRequired()
            .HasMaxLength(100);


            product.Property(p => p.IdCategory)
                .IsRequired()
                  .IsRequired()
            .HasConversion(
                v => (int)v,  // Convierte el valor del enum a int para almacenarlo en la base de datos
                v => (Category)v);  // Convierte el valor int de la base de datos de vuelta al enum


            product.Property(p => p.MinStock)
                .IsRequired();


            product.Property(p => p.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");


            product.Property(p => p.ExpirationDate)
                .IsRequired()
                .HasColumnType("date");




        }
    }
}
