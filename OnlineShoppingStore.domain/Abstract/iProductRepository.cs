using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShoppingStore.domain.Entities;

namespace OnlineShoppingStore.domain.Abstract
{
    public interface iProductRepository
    {
        IEnumerable<Product> Products { get; }

    }
}
