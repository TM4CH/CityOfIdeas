using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BL;
using BL.InterfaceManagers.IPlatformManagers;
using BL.Managers;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UI_MVC.Models;

namespace UI_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlatformManager _platformManager;
        
        //IS VOOR BACKEND - MOET VERWIJDERD WORDEN BIJ FRONT-END
        
        private readonly  UserManager<User> _userManager;

        //TOT HIER
        
        public HomeController(UserManager<User> userManager)
        {
            //IS VOOR BACKEND - MOET VERWIJDERD WORDEN BIJ FRONT-END
            
            _platformManager = new PlatformManager();
            _userManager = userManager;
            
            //TOT HIER
        }
        public async Task<IActionResult> Index()
        {
            //IS VOOR BACKEND - MOET VERWIJDERD WORDEN BIJ FRONT-END
            
                //ADD
                    _platformManager.AddPlatform(
                        "Hoboken",
                        new Collection<User>()
                        {
                            await _userManager.FindByEmailAsync("admin@localhost")
                        });
                //GET
                    /*Console.WriteLine(_platformManager.GetPlatformByName("Hoboken"));
                //SET
                    _platformManager.SetPlatform(ID, "Wilrijk");
                //REMOVE
                    _platformManager.RemovePlatform(_platformManager.GetPlatformByName("Wilrijk").Id);*/
            
            //TOT HIER
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Project()
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
