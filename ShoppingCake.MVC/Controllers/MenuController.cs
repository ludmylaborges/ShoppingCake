using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCake.MVC.Models.Products;
using ShoppingCake.MVC.ViewsModels;

namespace ShoppingCake.MVC.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new MenuViewModel();
            List<ProductModel> productModel = new List<ProductModel>();
            productModel.Add(new ProductModel(1,"Maravilhoro bolo de chocolate","https://dummyimage.com/350x350/e02661/0015ff", 100,  "Bolo de Chocolate"));
            productModel.Add(new ProductModel(2, "Delicioso bolo de casadinho", "https://dummyimage.com/350x350/e02661/0015ff", 120, "Bolo de Casadinho"));
            productModel.Add(new ProductModel(3, "Expetacular bolo de churros", "https://dummyimage.com/350x350/e02661/0015ff", 110, "Bolo de Churros"));
            viewModel.Title = "Cardapio";
            viewModel.Products = productModel;
            return View(viewModel);
        }
    }
}