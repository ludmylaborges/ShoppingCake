using Microsoft.EntityFrameworkCore;
using ShoppingCake.Domain.ShoppingCarts;
using ShoppingCake.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCake.Infra.Repositories
{
    public class ShoppingCartRepository : RepositoryGereric<ShoppingCart>, IShoppingCartRepository
    {
        private readonly DbContextShoppingCake _dbContext;
        private readonly DbSet<ShoppingCart> _dbSet;

        public ShoppingCartRepository(DbContextShoppingCake dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.ShoppingCart;
        }
    }
}
