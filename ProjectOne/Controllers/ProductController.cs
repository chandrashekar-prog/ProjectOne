using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectOne.Models;
namespace ProjectOne.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Product> products = DataBase.GetProducts();

            return View(products);
        }
        public IActionResult Details(string slugLink)
        {
            Product product = DataBase.GetProduct(slugLink);
            return View(product);
        }
    }
}
