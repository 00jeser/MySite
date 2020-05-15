using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MySite.Models.Qualification;
using Wangkanai.Detection;

namespace MySite.Controllers
{
    public class QualificationController : Controller
    {
        readonly IDetection detection;
        private readonly IWebHostEnvironment _env;
        public QualificationController(IDetection d, IWebHostEnvironment env)
        {
            detection = d;
            _env = env;
        }

        private void setViewBag() 
        {
            ViewBag.Br = detection.Device.Type.ToString();
        }

        public IActionResult Index()
        {
            List<Work> works = new List<Work>();

            works.Add(new Work()
            {
                Title = "Бот говорун",
                Image = "https://sun9-63.userapi.com/vTZ8t8qLa2_JW8tXrG7CT2ho__1qr-yKREV_aA/XwAcSJPSkqc.jpg",
                URL = "../Qualification/Govorun",
                Description = "Это бот для бесед в ВК и Дискорд, который на основе прочитанных сообщений строит подобие нейронки и генерирует сообщения." +
                "Бот написан на микросерверной архитектуре. Модуль генерации сообщений написан на ASP.NET Core, а модуль ботов на Python."
            });
            works.Add(new Work()
            {
                Title = "Бот говорун",
                Image = "https://sun9-63.userapi.com/vTZ8t8qLa2_JW8tXrG7CT2ho__1qr-yKREV_aA/XwAcSJPSkqc.jpg",
                URL = "../Qualification/Govorun",
                Description = "Это бот для бесед в ВК и Дискорд, который на основе прочитанных сообщений строит подобие нейронки и генерирует сообщения"
            });

            ViewBag.works = works.ToArray();
            setViewBag();
            return View();
        }
    }
}