﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalePurchase.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.FirmName = "Govind Traders";
            ViewBag.UserName = "Bhavishey Ahuja";

            return View();
        }
    }
}
