using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryVet.Entities
{
    public interface IUnitOfWork
    {
        Task SaveChanges();

    }
}
