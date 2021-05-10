using Microsoft.EntityFrameworkCore;
using ShoppingCake.Domain.Purchases;
using ShoppingCake.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCake.Infra.Repositories
{
    public class PurchaseRepository : RepositoryGereric<Purchase>, IPurchaseRepository
    {
        private readonly DbContextShoppingCake _dbContext;
        private readonly DbSet<Purchase> _dbSet;

        public PurchaseRepository(DbContextShoppingCake dbContext)
           : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Purchase;
        }

        public List<Purchase> GetByPaymentType(int paymentTypeId) 
        {
            return _dbSet.Where(x => x.PaymentTypeID == paymentTypeId).ToList();
        }
    }
}
