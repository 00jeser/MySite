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

        public IActionResult Govorun()
        {
            setViewBag();
            return View("Index");
        }

        public IActionResult Index()
        {
            List<Work> works = new List<Work>();

            works.Add(new Work()
            {
                Title = "Бот говорун",
                Image = "https://sun9-63.userapi.com/vTZ8t8qLa2_JW8tXrG7CT2ho__1qr-yKREV_aA/XwAcSJPSkqc.jpg",
                URL = "../Qualification/Govorun",
                Description = "Это бот для бесед в ВК и Discord, который на основе прочитанных сообщений строит подобие нейронки и генерирует сообщения." +
                "Бот написан на микросерверной архитектуре. Модуль генерации сообщений написан на ASP.NET Core, а модуль ботов на Python."
            });
            works.Add(new Work()
            {
                Title = "GTA Compare",
                Image = "../images/works/gtacompare.png",
                URL = "../Qualification/GTACompare",
                Description = "Это мой 3 проект в Яндекс Лицее. Он написан на Flask."
            });
            works.Add(new Work()
            {
                Title = "Мой сайт",
                Image = "../images/MyLogo.png",
                URL = "../",
                Description = "Это мой сайт, который я сделал что бы познакомится с платформой ASP.NET Core."
            });
            works.Add(new Work()
            {
                Title = "Мой рюкзак",
                Image = "../images/works/.png",
                URL = "../",
                Description = "Это рюкзак с экраном 16x16 управляемый с платформы arduino. Прошивка написана полностью мной на С++."
            });
            works.Add(new Work()
            {
                Title = "VkStatusTranslator",
                Image = "../images/works/VkStatusTranslator.png",
                URL = "../",
                Description = "Это UWP приложение для Windows 10, позволяющее настроить трансляцию статуса в вк, на подобии того как это сделано в Discord."
            });
            works.Add(new Work()
            {
                Title = "DiscordGameBot",
                Image = "../images/works/DSGameBot.png",
                URL = "../",
                Description = "Это небольшой вспомогательный бот для моего сервера в Discord. Он написан на Node JS."
            });
            works.Add(new Work()
            {
                Title = "AllGameLauncher",
                Image = "../images/works/AGL.png",
                URL = "../",
                Description = "Это лаунчер игр с любой платформы, который я переписывал много раз на нескольких технологиях(WinForms, WPF, UWP), пока не вышел GOG Galaxy 2.0"
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
                name = "XAML",
                level = "",
                percent = 40
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

            List<Tech> teches = new List<Tech>();

            teches.Add(new Tech { name = "WPF", Level = 40 });
            teches.Add(new Tech { name = "Unity", Level = 30 });
            teches.Add(new Tech { name = "ASP.NET Core", Level = 25 });
            teches.Add(new Tech { name = "UWP", Level = 20 });
            teches.Add(new Tech { name = "PyQt5", Level = 20 });
            teches.Add(new Tech { name = "Flask", Level = 20 });
            teches.Add(new Tech { name = "Win Forms", Level = 19 });
            teches.Add(new Tech { name = "PyGame", Level = 15 });
            teches.Add(new Tech { name = "Unreal Engine", Level = 15 });

            ViewBag.teches = teches;

            ViewBag.DopJS = "../js/qualification.js";
            setViewBag();
            return View();
        }
    }
}