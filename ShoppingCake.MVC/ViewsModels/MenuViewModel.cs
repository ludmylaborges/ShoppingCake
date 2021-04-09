using ShoppingCake.MVC.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCake.MVC.ViewsModels
{
    public class MenuViewModel
    {
        public List<ProductModel> Products  { get; set; }
        public string Title { get; set; }
    }
}
