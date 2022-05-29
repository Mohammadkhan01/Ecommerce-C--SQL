using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace OnlineShoppingStore.domain.Entities
{
    public class EfDbContext:DbContext
    {
        public DbSet<Product> Product { get; set; }

        public IEnumerable<Entities.Product> Products { get; set; }
    }
}
