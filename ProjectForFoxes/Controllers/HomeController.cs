using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectForFoxes.Models;

namespace ProjectForFoxes.Controllers
{
    public class HomeController : Controller
    {
        private IFox foxService;

        public HomeController(IFox foxService)
        {
            this.foxService = foxService;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/Login")]
        public IActionResult Login(string name)
        {
            //foxService.AddFox(name);
            foreach (var item in foxService.ListOfFoxes)
            {
                if (name != null && item.Name == name)
                {
                    return RedirectToAction("Show", new { name = name });
                }
            }
            Fox fox = new Fox(name);
            foxService.AddFox(name);
            return RedirectToAction("Show", "Home", new { name = name});
        }

        [Route("Show")]
        public IActionResult Show(string name)
        {
            return View(foxService.GetFoxByName(name));
        }
    }
}