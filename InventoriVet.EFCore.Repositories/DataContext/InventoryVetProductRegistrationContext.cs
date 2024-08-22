using InventoryVet.ProductRegistration.BusinessObjects.POCOEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InventoriVet.EFCore.Repositories.DataContext
{
    public class InventoryVetProductRegistrationContext : DbContext
    {
        public InventoryVetProductRegistrationContext(
            DbContextOptions<InventoryVetProductRegistrationContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }

    }
}
