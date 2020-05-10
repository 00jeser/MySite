using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySite.Models;

namespace MySite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ImagePath = $"images/me/{(new Random()).Next(1, 3)}.jpg";
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactModel c) 
        {
            ViewBag.Title = "sended";
            return View();
        }
    }
}