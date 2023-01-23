using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZayShop.Models;

namespace ZayShop.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}