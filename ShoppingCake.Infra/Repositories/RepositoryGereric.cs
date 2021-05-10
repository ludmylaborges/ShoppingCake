using Microsoft.EntityFrameworkCore;
using ShoppingCake.Domain;
using ShoppingCake.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCake.Infra.Repositories
{
    public abstract class RepositoryGereric<T> : IRepositoryGeneric<T> where T: class
    {
        private readonly DbContextShoppingCake _dbContext;
     

        protected RepositoryGereric(DbContextShoppingCake dbContext)
        {
            _dbContext = dbContext;
        
        }

        public int Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            return _dbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }
    }
}
