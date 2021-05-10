using Microsoft.EntityFrameworkCore;
using ShoppingCake.Domain.Purchases;
using ShoppingCake.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCake.Infra.Repositories
{
    public class PaymentTypeRepository : RepositoryGereric<PaymentType>, IPaymentTypeRepository
    { 
        private readonly DbContextShoppingCake _dbContext;
        private readonly DbSet<PaymentType> _dbSet;

        public PaymentTypeRepository(DbContextShoppingCake dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.PaymentType;
        }
    }
}
