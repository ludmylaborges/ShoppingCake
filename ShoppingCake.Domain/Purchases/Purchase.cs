using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCake.Domain.Purchases
{
    public class Purchase
    {
        public int Id { get; set; }
        public int PaymentTypeID { get; set; }
        public PaymentType PaymentType { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
