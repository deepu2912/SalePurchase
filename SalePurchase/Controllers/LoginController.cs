using Microsoft.AspNetCore.Mvc;
using SalePurchase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalePurchase.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserAuth user)
        {
            return View();
        }
    }
}
