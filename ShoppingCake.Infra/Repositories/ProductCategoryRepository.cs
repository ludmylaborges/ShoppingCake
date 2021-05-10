using Microsoft.EntityFrameworkCore;
using ShoppingCake.Domain.Products;
using ShoppingCake.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCake.Infra.Repositories
{
   public class ProductCategoryRepository : RepositoryGereric<ProductCategory>, IProductCategoryRepository
    {
        private readonly DbContextShoppingCake _dbContext;
        private readonly DbSet<ProductCategory> _dbSet;

        public ProductCategoryRepository(DbContextShoppingCake dbContext) 
            : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.ProductCategory;
        }
    }
}
