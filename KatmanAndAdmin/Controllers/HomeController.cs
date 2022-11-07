
using BusinessLayer.Concrete;
using EntityLayer.Entities;
using KatmanAdminPresent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KatmanAdminPresent.Controllers
{
    public class HomeController : Controller
    {
        ProductManager _product = new ProductManager();
        CategoryManager _category = new CategoryManager();
        Product _singleProduct;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var category = _category.List(x => x.Id > 1);
            return View(category);
        }

        public IActionResult CategoryBar()
        {
            return RedirectToAction("Index");
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
