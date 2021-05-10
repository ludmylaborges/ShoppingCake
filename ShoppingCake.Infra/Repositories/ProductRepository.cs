using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ShoppingCake.Domain.Products;
using ShoppingCake.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCake.Infra.Repositories
{
    public class ProductRepository : RepositoryGereric<Product>, IProductRepository
    {

        private readonly DbContextShoppingCake _dbContext;
        private readonly DbSet<Product> _dbSet;
        
        public ProductRepository(DbContextShoppingCake dbContext) 
            : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Product;
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _dbSet.Where(x => x.CategoryId == categoryId).ToList();
        }
    }

   
}
