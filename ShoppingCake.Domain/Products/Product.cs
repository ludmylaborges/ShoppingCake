using ShoppingCake.Domain.ShoppingCarts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCake.Domain.Products
{
   public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public ProductCategory Category { get; set; }
        public int CategoryId { get; set; }
        public List<ShoppingCartProduct> ShoppingCartProducts { get; set; }
    }
}
