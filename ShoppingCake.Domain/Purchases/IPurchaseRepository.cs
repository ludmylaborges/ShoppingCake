using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCake.Domain.Purchases
{
    public interface IPurchaseRepository : IRepositoryGeneric<Purchase>
    {
        List<Purchase> GetByPaymentType(int paymentTypeId);
    }
}
