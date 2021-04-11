using ShoppingCake.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCake.Domain.ShoppingCarts
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public List<ShoppingCartProduct> ShoppingCartProducts { get; set; }
    }
}
