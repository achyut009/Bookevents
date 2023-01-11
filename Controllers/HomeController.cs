using BooksEvents.Data.Repos;
using BooksEvents.Models;
using BooksEvents.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BooksEvents.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IEventsRepo _eventsRepo;
        private readonly IEmailService _emailService;

        public HomeController(ILogger<HomeController> logger, IEventsRepo eventsRepo, IEmailService emailService)
        {
            _logger = logger;
            _eventsRepo = eventsRepo;
           
        }

        public async Task<ViewResult> Index(EventModel events)
        {
           

            ViewData["data"] = await _eventsRepo.GetAllEvent();
            return View();

        }

        public IActionResult AboutUs()
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
