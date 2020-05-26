using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySite.Models.Social;

namespace MySite.Controllers
{
    public class SocialController : Controller
    {
        public void SetViewBag()
        {
            ViewBag.DopCSS = "../css/Social.css";
        }
        public IActionResult Index()
        {
            SetViewBag();
            return View();
        }
        public IActionResult game()
        {
            SetViewBag();
            var gms = new List<Game>();
            gms.Add(new Game
            {
                name = "The Walking Dead A new Frontier",
                url = "http://www.aumanack.etc.br/wp-content/uploads/2017/02/LOGO170222_103530.png",
                ocen = 52
            });
            gms.Add(new Game
            {
                name = "Journey",
                url = "https://cdn2.unrealengine.com/Diesel%2Fproduct%2Fjourney%2Flogo%2FJourney_logo_nopadding-14427x2744-26a719c36434ee7073ab4fb9f48aa3df8f563f33.png?h=270&resize=1&w=480",
                ocen = 98
            });
            gms.Add(new Game
            {
                name = "Quantum Break",
                url = "http://images.vfl.ru/ii/1460217328/b3137ade/12219745.png",
                ocen = -1
            });
            gms.Add(new Game
            {
                name = "We Happy Few",
                url = "https://steamuserimages-a.akamaihd.net/ugc/967619871315315906/D4B57E02F67C01D4A5E5459F627F3095898D8811/",
                ocen = -1
            });
            gms.Add(new Game
            {
                name = "A Plague Tale: Innocence",
                url = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/88b6f848-7f22-44b7-a036-8e65d20a4e3d/db1i095-94e4599b-00f1-41a7-82e9-c0c332892389.png/v1/fill/w_512,h_512,strp/a_plague_tale__innocence_icon__2__by_malfacio_db1i095-fullview.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9NTEyIiwicGF0aCI6IlwvZlwvODhiNmY4NDgtN2YyMi00NGI3LWEwMzYtOGU2NWQyMGE0ZTNkXC9kYjFpMDk1LTk0ZTQ1OTliLTAwZjEtNDFhNy04MmU5LWMwYzMzMjg5MjM4OS5wbmciLCJ3aWR0aCI6Ijw9NTEyIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmltYWdlLm9wZXJhdGlvbnMiXX0.OB0XaJDegVREL94t-hxTdlSoizaO0l36kNJgMBghT3U",
                ocen = 98
            });
            gms.Add(new Game
            {
                name = "ancestors the humankind odyssey",
                url = "http://d.radikal.ru/d28/1908/35/fcd085ef2446.png",
                ocen = 50
            });
            gms.Add(new Game
            {
                name = "BeamNG.drive",
                url = "https://yt3.ggpht.com/a/AATXAJx0r6A9yH2L-bHpGm8_nOPv6Se_2D0DT00u2Q=s900-c-k-c0xffffffff-no-rj-mo",
                ocen = 51
            });
            gms.Add(new Game
            {
                name = "Bioshock infinit",
                url = "http://gtamania.ru/_nw/82/40787621.png",
                ocen = 89
            });
            gms.Add(new Game
            {
                name = "Black Desert",
                url = "https://s1.pearlcdn.com/RU/Upload/Community/165aa2c527920181013221400318.jpg",
                ocen = 76
            });
            gms.Add(new Game
            {
                name = "Brothers - A Tale of Two Sons",
                url = "https://trophy01.np.community.playstation.net/trophy/np/NPWR05896_00_01C5EEF9A15B941317B8EAECFAEC8FB57AC2F2E584/92B6B9CFF03CE64AD026E545B51C21767C94E23B.PNG",
                ocen = 96
            });
            gms.Add(new Game
            {
                name = "Cities Skiline",
                url = "https://www.v2.fi/images/games/news/23957/pic1.jpg",
                ocen = 73
            });
            gms.Add(new Game
            {
                name = "CityBattle  Virtual Earth",
                url = "",
                ocen = 30
            });
            gms.Add(new Game
            {
                name = "Clash Of Clans",
                url = "",
                ocen = 30
            });
            gms.Add(new Game
            {
                name = "Clash Royal",
                url = "",
                ocen = 32
            });
            gms.Add(new Game
            {
                name = "COD Mobile",
                url = "",
                ocen = 70
            });
            gms.Add(new Game
            {
                name = "Counter-Strike Global Offensive",
                url = "",
                ocen = 40
            });
            gms.Add(new Game
            {
                name = "Crossout",
                url = "",
                ocen = 62
            });
            gms.Add(new Game
            {
                name = "Dead Space",
                url = "",
                ocen = 74
            });
            gms.Add(new Game
            {
                name = "Destiny 2",
                url = "",
                ocen = 69
            });
            gms.Add(new Game
            {
                name = "EVE Online",
                url = "",
                ocen = 51
            });
            gms.Add(new Game
            {
                name = "Far Cry 3",
                url = "",
                ocen = 68
            });
            gms.Add(new Game
            {
                name = "Game Dev Tycoon",
                url = "",
                ocen = 41
            });
            gms.Add(new Game
            {
                name = "GTA V",
                url = "",
                ocen = 50
            });
            gms.Add(new Game
            {
                name = "GTA SA",
                url = "",
                ocen = 70
            });
            gms.Add(new Game
            {
                name = "Half-Life 2",
                url = "",
                ocen = 79
            });
            gms.Add(new Game
            {
                name = "Hearthstone",
                url = "",
                ocen = 75
            });
            gms.Add(new Game
            {
                name = "Heavy Rain",
                url = "",
                ocen = 86
            });
            gms.Add(new Game
            {
                name = "Hellblade",
                url = "",
                ocen = 98
            });
            gms.Add(new Game
            {
                name = "Just Cause 4",
                url = "",
                ocen = 73
            });
            gms.Add(new Game
            {
                name = "Kingdom Come Deliverance",
                url = "",
                ocen = 98
            });
            gms.Add(new Game
            {
                name = "Life Is Strange",
                url = "",
                ocen = 99
            });
            gms.Add(new Game
            {
                name = "Life is Strange Before the Storm",
                url = "",
                ocen = 99
            });
            gms.Add(new Game
            {
                name = "Mafia II",
                url = "",
                ocen =90
            });
            gms.Add(new Game
            {
                name = "My Friend Pedro",
                url = "",
                ocen = 76
            });
            gms.Add(new Game
            {
                name = "Need for Speed: Most Wanted",
                url = "",
                ocen = 66
            });
            gms.Add(new Game
            {
                name = "Niear Automata",
                url = "",
                ocen = 78
            });
            gms.Add(new Game
            {
                name = "Ori and the Blind Forest",
                url = "",
                ocen = 99
            });
            gms.Add(new Game
            {
                name = "Outlast",
                url = "",
                ocen = 28
            });
            gms.Add(new Game
            {
                name = "Paladins",
                url = "",
                ocen = 30
            });
            gms.Add(new Game
            {
                name = "PayDay 2",
                url = "",
                ocen = 61
            });
            gms.Add(new Game
            {
                name = "Portal 2",
                url = "",
                ocen = 73
            });
            gms.Add(new Game
            {
                name = "Prince of Persia: The Two Thrones",
                url = "",
                ocen = 75
            });
            gms.Add(new Game
            {
                name = "Prison Architect",
                url = "",
                ocen = 31
            });
            gms.Add(new Game
            {
                name = "RimWorld",
                url = "",
                ocen = 99
            });
            gms.Add(new Game
            {
                name = "S.T.A.L.K.E.R.",
                url = "",
                ocen = 77
            });
            gms.Add(new Game
            {
                name = "Scrap Mechanic",
                url = "",
                ocen = 49
            });
            gms.Add(new Game
            {
                name = "SimCity 5",
                url = "",
                ocen = 59
            });
            gms.Add(new Game
            {
                name = "Space Engineers",
                url = "",
                ocen = 61
            });
            gms.Add(new Game
            {
                name = "Spore",
                url = "",
                ocen = 53
            });
            gms.Add(new Game
            {
                name = "Star Conflict",
                url = "",
                ocen = 45
            });
            gms.Add(new Game
            {
                name = "Startup Company",
                url = "",
                ocen = 32
            });
            gms.Add(new Game
            {
                name = "Surviving Mars",
                url = "",
                ocen = 68
            });
            gms.Add(new Game
            {
                name = "Team Fortress 2",
                url = "",
                ocen = 30
            });
            gms.Add(new Game
            {
                name = "The Forest",
                url = "",
                ocen = 54
            });
            gms.Add(new Game
            {
                name = "The Last of Us",
                url = "",
                ocen = 100
            });
            gms.Add(new Game
            {
                name = "The Walking Dead",
                url = "",
                ocen = 100
            });
            gms.Add(new Game
            {
                name = "The Walking Dead - Season 2",
                url = "",
                ocen = 97
            });
            gms.Add(new Game
            {
                name = "The Walking Dead a final season",
                url = "",
                ocen = 89
            });
            gms.Add(new Game
            {
                name = "This War Of Mine",
                url = "",
                ocen = 92
            });
            gms.Add(new Game
            {
                name = "Total War Warhammer 2",
                url = "",
                ocen = 57
            });
            gms.Add(new Game
            {
                name = "Transport Fever",
                url = "",
                ocen = 56
            });
            gms.Add(new Game
            {
                name = "Undertale",
                url = "",
                ocen = 97
            });
            gms.Add(new Game
            {
                name = "The Witcher 3",
                url = "http://discord-gamer.pp.ua/Witcher.png",
                ocen = 98
            });
            gms.Add(new Game
            {
                name = "War Thunder",
                url = "",
                ocen = 57
            });
            gms.Add(new Game
            {
                name = "Watch Dogs",
                url = "",
                ocen = 83
            });
            gms.Add(new Game
            {
                name = "Watch Dogs 2",
                url = "",
                ocen = 85
            });
            gms.Add(new Game
            {
                name = "What Remains of Edith Finch",
                url = "",
                ocen = 100
            });
            gms.Add(new Game
            {
                name = "Overcooked",
                url = "",
                ocen = 85
            });
            gms.Add(new Game
            {
                name = "mutant year zero: road to eden",
                url = "",
                ocen = 68
            });
            gms.Add(new Game
            {
                name = "Last Day of June",
                url = "",
                ocen = 67
            });
            gms.Add(new Game
            {
                name = "Kingdom New Lands",
                url = "",
                ocen = 90
            });
            gms.Add(new Game
            {
                name = "Fortnite",
                url = "",
                ocen = 67
            });
            gms.Add(new Game
            {
                name = "Everyhing",
                url = "",
                ocen = 80
            });
            gms.Add(new Game
            {
                name = "The Wolf Among Us",
                url = "",
                ocen = 99
            });
            gms.Add(new Game
            {
                name = "Tales From the Borderlands",
                url = "",
                ocen = 97
            });
            gms.Add(new Game
            {
                name = "Firewatch",
                url = "",
                ocen = 100
            });
            Game[] gmss = gms.ToArray();
            Array.Sort(gmss);
            Array.Reverse(gmss);
            ViewBag.games = gmss;
            return View();
        }
    }
}