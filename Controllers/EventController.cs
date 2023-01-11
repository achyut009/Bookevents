using BooksEvents.Data.Repos;
using BooksEvents.Models;
using BooksEvents.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksEvents.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventsRepo _eventsRepo;
        private readonly IEmailService _emailService;


        public EventController(IEventsRepo eventsRepo, IEmailService emailService)
        {
            _eventsRepo = eventsRepo;

            _emailService = emailService;
        }

        public async Task<ViewResult> GetAllEvents()
        {
            ViewData["data"] = await _eventsRepo.GetAllEvent();
            return View();
        }

        public async Task<ViewResult> GetMyEvents()
        {
            ViewData["data"] = await _eventsRepo.GetMyEvents();
            return View();
        }

        public IActionResult CreateEvent(bool isSuccess , int EventId, EventModel eventModel)
        {
            ViewBag.isSuccess = isSuccess;
            ViewBag.EventId = EventId;
          
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent(EventModel eventModel)
        {


            if (ModelState.IsValid)
            {
                int id = await _eventsRepo.AddNewEvent(eventModel);
               


                UserEmailOptionModel userEmailOption = new UserEmailOptionModel
                {
                    ToEmails = eventModel.InvitedBy,
                    PlaceHolders = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string,string>("{{UserName}}","anmol")
                }
                };
               await _emailService.SendTestEmail(userEmailOption);

                if (id > 0)
                {
                    return RedirectToAction(nameof(CreateEvent), new { isSuccess = true, EventId = id });

                }
            }
           

            return View();
        }

        [HttpGet]
        public async Task<ViewResult> Edit(int id)
        {
            var data = await _eventsRepo.GetEventById(id);

            EventModel eventModel = new EventModel()
            {
                Id = data.Id,
                Name = data.Name,
                Date = data.Date,
                Location = data.Location,
                Time = data.Time,
                Duration = data.Duration,
                Description = data.Description,
                OtherDetail = data.Description,
                Type = data.Type,
                InvitedBy = data.InvitedBy,
            };

            return View(eventModel);

        }
        [HttpPost]
        public async Task<ActionResult> Edit(EventModel eventModel)
        {
            if (ModelState.IsValid)
            {
                int id = await _eventsRepo.Update(eventModel);

                UserEmailOptionModel userEmailOption = new UserEmailOptionModel
                {
                    ToEmails = eventModel.InvitedBy,
                    PlaceHolders = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string,string>("{{UserName}}","anmol")
                }
                };
                await _emailService.SendTestEmail(userEmailOption);

                if (id > 0)
                {
                    return RedirectToAction(nameof(CreateEvent), new { isSuccess = true, EventId = id });

                }
            }
            return View();
        }

        public async Task<IActionResult> InvitedTo(EventModel eventModel)
        {
            ViewData["data"] = await _eventsRepo.InvitedTo(eventModel);
            return View();
        }

        public async Task<ActionResult> GetAEvent(int id)
        {
            var data = await _eventsRepo.GetEventById(id);

            return View(data);
        }
    }
}
