using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySite.Models;
using Wangkanai.Detection;

namespace MySite.Controllers
{
    public class HomeController : Controller
    {
        readonly IDetection detection;
        public HomeController(IDetection d) 
        {
            detection = d;
        }
        public IActionResult Index()
        {
            ViewBag.ImagePath = $"https://gavrilenko.herokuapp.com/images/me/{(new Random()).Next(1, 3)}.jpg";
            ViewBag.Br = detection.Device.Type.ToString();
            ViewBag.Description = "";
            ViewBag.Keywords = "Гавриленко, Сергей, Константинович";
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactModel c)
        {
            ViewBag.ImagePath = $"https://gavrilenko.herokuapp.com/images/me/{(new Random()).Next(1, 3)}.jpg";
            ViewBag.Br = detection.Device.Type.ToString();
            MailAddress from = new MailAddress("boss.gavrilenko@yandex.ru", "Гавриленко Сергей");
            MailAddress to = new MailAddress("boss.gavrilenko@bk.ru");
            MailMessage m = new MailMessage(from, to);
            m.Subject = c.name + " :-: " + c.email;
            m.Body = c.message;
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 25);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("boss.gavrilenko@yandex.ru", "Cam25151519");
            smtp.EnableSsl = true;
            smtp.Send(m);
            return View();
        }
    }
}