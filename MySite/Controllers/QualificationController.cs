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
            ViewBag.DopCSS = "../css/Works.css";
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
                Title = "GTA Compare",
                Image = "../images/works/gtacompare.png",
                URL = "../Qualification/GTACompare",
                Description = "Это мой 3 проект в Яндекс Лицее. Он написан на Flask."
            });

            ViewBag.works = works.ToArray();


            List<language> langs = new List<language>();

            langs.Add(new language()
            {
                name = "C#",
                level = "Junior",
                percent = 35
            });
            langs.Add(new language()
            {
                name = "Python",
                level = "Junior",
                percent = 25
            });
            langs.Add(new language()
            {
                name = "Java",
                level = "Стажер",
                percent = 10
            });
            langs.Add(new language()
            {
                name = "HTML/CSS",
                level = "Стажер",
                percent = 10
            });
            langs.Add(new language()
            {
                name = "JavaScript",
                level = "Стажер",
                percent = 8
            });
            langs.Add(new language()
            {
                name = "c++",
                level = "Стажер",
                percent = 8
            });
            langs.Add(new language()
            {
                name = "c",
                level = "HelloWorld",
                percent = 5
            });
            langs.Add(new language()
            {
                name = "Assembler",
                level = "HelloWorld",
                percent = 1
            });

            ViewBag.Langs = langs.ToArray();


            ViewBag.DopJS = "../js/qualification.js";
            setViewBag();
            return View();
        }
    }
}