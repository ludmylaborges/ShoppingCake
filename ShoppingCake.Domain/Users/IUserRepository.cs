using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCake.Domain.Users
{
    public interface IUserRepository : IRepositoryGeneric<User>
    {
        User GetByEmail(string email);
    }
}
