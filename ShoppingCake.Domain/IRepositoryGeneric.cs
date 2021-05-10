using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCake.Domain
{
    public interface IRepositoryGeneric <T> where T: class
    {
        
        List<T> GetAll();
        T GetById(int id);
        int Add(T entity);

    }
}
