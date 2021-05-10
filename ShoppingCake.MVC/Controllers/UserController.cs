
using Microsoft.AspNetCore.Mvc;
using ShoppingCake.Domain.Users;
using ShoppingCake.MVC.Models.Users;

namespace ShoppingCake.MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Save(UserViewModel userViewModel)
        {

            userRepository.Add(new User {
                Name = userViewModel.Name, 
                BirthDate=userViewModel.BirthDate, 
                Email=userViewModel.Email, 
                Password=userViewModel.Password,
                Telephone = userViewModel.Telephone
            }); 
            return View("Success");
        }
    }
}