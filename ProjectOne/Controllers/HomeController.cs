﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
