using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCake.Domain.Products
{
    public interface IProductRepository : IRepositoryGeneric<Product>
    {
        List<Product> GetByCategory(int categoryId);
    }
}
