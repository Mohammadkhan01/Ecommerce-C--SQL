using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShoppingStore.domain.Abstract;
using OnlineShoppingStore.domain.Entities;
namespace OnlineShoppingStore.domain.Concrete
{
    public class EFProductRepository:iProductRepository

    {
        private readonly EfDbContext context = new EfDbContext();
        public IEnumerable <Product > Products
        {
            get { return context .Products  ; }
        }
    }
}
