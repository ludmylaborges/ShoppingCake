using ShoppingCake.Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCake.Domain.ShoppingCarts
{
    public class ShoppingCartProduct
    {
        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
