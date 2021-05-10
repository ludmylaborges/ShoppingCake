using Microsoft.EntityFrameworkCore;
using ShoppingCake.Domain.Users;
using ShoppingCake.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCake.Infra.Repositories
{
    public class UserRepository : RepositoryGereric<User>, IUserRepository
    {
        private readonly DbContextShoppingCake _dbContext;
        

        public UserRepository(DbContextShoppingCake dbContext)
             : base(dbContext)
        {
            _dbContext = dbContext;
           
        }

        public User GetByEmail(string email)
        {
            return _dbContext.User.Where(x => x.Email == email).FirstOrDefault();
        }

        
    }
}
