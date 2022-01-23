using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Webinar_Register.Models;

namespace Webinar_Register.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public ViewResult RegisterForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RegisterForm(WebinarRegisters guests)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guests);


                return View("ThankYou", guests);
            }
            else
            {
                return View();
            }
        }
         
        public ViewResult ListsGuests()
        {
            return View(Repository.Responses.Where(r => r.WillJoin == true) );
        }


    }
}
