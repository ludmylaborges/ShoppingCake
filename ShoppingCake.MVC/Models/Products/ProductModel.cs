using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCake.MVC.Models.Products
{
    public class ProductModel
    {
        public ProductModel(int id, string description, string image, int price, string productName)
        {
            Id = id;
            Description = description;
            Image = image;
            Price = price;
            ProductName = productName;
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
