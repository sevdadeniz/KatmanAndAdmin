using AdminPanel.Models;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager _userManager;
        private readonly CategoryManager _categoryManager;
        private readonly ProductManager _productManager;

        public HomeController()
        {
            _userManager = new UserManager();
            _categoryManager = new CategoryManager();
            _productManager = new ProductManager();
        }


        public IActionResult Index()
        {
            return View();

        }
   


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}