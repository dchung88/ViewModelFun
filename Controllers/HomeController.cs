using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            Message message = new Message
            {
                message = "Welcome to this page!"
            };
            return View("Message", message);
        }

        [Route("users")]
        [HttpGet]
        public IActionResult Users_List()
        {
            User James = new User
            {
                FirstName = "James",
                LastName = "Harden"
            };

            User Lebron = new User
            {
                FirstName = "Lebron",
                LastName = "James"
            };

            User Kyrie = new User
            {
                FirstName = "Kyire",
                LastName = "Irving"
            };

            User Curry = new User
            {
                FirstName = "Steph",
                LastName = "Curry"
            };

            User Zion = new User
            {
                FirstName = "Zion",
                LastName = "Williamson"
            };

            List<User> viewModel = new List<User>()
            {
                James, Lebron, Kyrie, Curry, Zion
            };

            return View("Users_List", viewModel);
        }

        [Route("user")]
        [HttpGet]
        public IActionResult SomeUser()
        {
            User someUser = new User
            {
                FirstName = "Kobe",
                LastName = "Bryant"
            };
            return View("User", someUser);
        }

        [Route("numbers")]
        [HttpGet]
        public IActionResult Number()
        {
            int[] numbers = new int[]
            {
                1, 2, 3, 10, 43, 5
            };

            return View("Numbers", numbers);
            
        }


    }
}
