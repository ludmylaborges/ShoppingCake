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
            List<ProductModel> products = new List<ProductModel>();
            products.Add(new ProductModel(1,"Maravilhoro bolo de chocolate","https://dummyimage.com/350x350/e02661/0015ff", 100,  "Bolo de Chocolate"));
            products.Add(new ProductModel(2, "Delicioso bolo de casadinho", "https://dummyimage.com/350x350/e02661/0015ff", 120, "Bolo de Casadinho"));
            products.Add(new ProductModel(3, "Expetacular bolo de churros", "https://dummyimage.com/350x350/e02661/0015ff", 110, "Bolo de Churros"));
            products.Add(new ProductModel(4, "Expetacular bolo de ninho", "https://dummyimage.com/350x350/e02661/0015ff", 125, "Bolo de ninho"));
            viewModel.Title = "Cardapio";
            viewModel.Products = products;
            return View(viewModel);
        }

        public IActionResult Detail(int id)
        {
            List<ProductModel> products = new List<ProductModel>();
            products.Add(new ProductModel(1, "Maravilhoro bolo de chocolate", "https://dummyimage.com/350x350/e02661/0015ff", 100, "Bolo de Chocolate"));
            products.Add(new ProductModel(2, "Delicioso bolo de casadinho", "https://dummyimage.com/350x350/e02661/0015ff", 120, "Bolo de Casadinho"));
            products.Add(new ProductModel(3, "Expetacular bolo de churros", "https://dummyimage.com/350x350/e02661/0015ff", 110, "Bolo de Churros"));
            products.Add(new ProductModel(4, "Expetacular bolo de ninho", "https://dummyimage.com/350x350/e02661/0015ff", 125, "Bolo de ninho"));
            var result = products.Where(x => x.Id == id).FirstOrDefault();
            return View(result);

        }

    }
}