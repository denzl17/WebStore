using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Title = "Hello World";
            ViewData["Title"] = "Hello Home!";

            return View();
        }

        public IActionResult AnotherAction()
        {
            return Content("Another action result");
        }
    }
}