using BooksEvents.Models;
using BooksEvents.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BooksEvents.Data.Repos
{
    public class EventsRepo : IEventsRepo
    {
        private readonly BookEventsContext _bookEventsContext;
        private readonly UserManager<UserModel> _userManager;
        private readonly IHttpContextAccessor _httpContext;
        private readonly IUserServices _userServices;

        public EventsRepo(BookEventsContext bookEventsContext, UserManager<UserModel> userManager, IHttpContextAccessor httpContext, IUserServices userServices)
        {
            _bookEventsContext = bookEventsContext;
            _userManager = userManager;
            _httpContext = httpContext;
            _userServices = userServices;
        }
        public async Task<int> AddNewEvent(EventModel eventModel)
        {
            var newEvent = new Events()
            {
                Id = eventModel.Id,
                Name = eventModel.Name,
                Date = eventModel.Date,
                Description = eventModel.Description,
                Duration = eventModel.Duration,
                OtherDetail = eventModel.OtherDetail,
                InvitedBy = eventModel.InvitedBy,
                Type = eventModel.Type,
                Location = eventModel.Location,
                Time = eventModel.Time,
                UserId = _userServices.GetId(),

            };

            await _bookEventsContext.Event.AddAsync(newEvent);
            await _bookEventsContext.SaveChangesAsync();

            return newEvent.Id;

        }

        public async Task<List<EventModel>> GetAllEvent()
        {
            var AllEvents = new List<EventModel>();

            var userID = _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);

            var data = await _bookEventsContext.Event.OrderByDescending(x => x.Id).ToListAsync();

            if (data?.Any() == true)
            {
                foreach (var events in data)
                {
                    AllEvents.Add(new EventModel()
                    {
                        Id = events.Id,
                        Name = events.Name,
                        Date = events.Date,
                        Description = events.Description,
                        Duration = events.Duration,
                        OtherDetail = events.OtherDetail,
                        InvitedBy = events.InvitedBy,
                        Type = events.Type,
                        Location = events.Location,
                        Time = events.Time,
                        UserId = events.UserId,
                    });
                }
            }
          
            return AllEvents;
        }

        public async Task<List<EventModel>> GetMyEvents()
        {
            var AllEvents = new List<EventModel>();

            var userID = _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);

            var data = await _bookEventsContext.Event.OrderByDescending(x => x.Id).Where(x => x.UserId == userID).ToListAsync();

            if (data?.Any() == true)
            {
                foreach (var events in data)
                {
                    AllEvents.Add(new EventModel()
                    {
                        Id = events.Id,
                        Name = events.Name,
                        Date = events.Date,
                        Description = events.Description,
                        Duration = events.Duration,
                        OtherDetail = events.OtherDetail,
                        InvitedBy = events.InvitedBy,
                        Type = events.Type,
                        Location = events.Location,
                        Time = events.Time,
                        UserId = events.UserId,
                    });
                }
            }

            return AllEvents;
        }

        public async Task<EventModel> GetEventById(int id)
        {
         
            var userID = _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);

            return await _bookEventsContext.Event.Where(x => x.Id == id).Select(events => new EventModel()
            {
                Id = events.Id,
                Name = events.Name,
                Date = events.Date,
                Description = events.Description,
                Duration = events.Duration,
                OtherDetail = events.OtherDetail,
                Type = events.Type,
                Location = events.Location,
                InvitedBy = events.InvitedBy,
                Time = events.Time,
                UserId = events.UserId,

            }).FirstOrDefaultAsync();

          


        }

        public async Task<int> Update(EventModel eventModel)
        {
            var newEvent = new Events()
            {
                Id = eventModel.Id,
                Name = eventModel.Name,
                Date = eventModel.Date,
                Description = eventModel.Description,
                Duration = eventModel.Duration,
                OtherDetail = eventModel.OtherDetail,
                InvitedBy = eventModel.InvitedBy,
                Type = eventModel.Type,
                Location = eventModel.Location,
                Time = eventModel.Time,
                UserId = _userServices.GetId(),

            };
             _bookEventsContext.Event.Update(newEvent);
             await _bookEventsContext.SaveChangesAsync();

            return newEvent.Id;

        }

        public async Task<List<EventModel>> InvitedTo(EventModel eventModel)
        {
              var data = await _bookEventsContext.Event.OrderByDescending(x => x.Id).Select(m => new EventModel() {
                  Id = m.Id,
                  Name = m.Name,
                  Date = m.Date,
                  Description = m.Description,
                  Duration = m.Duration,
                  OtherDetail = m.OtherDetail,
                  InvitedBy = m.InvitedBy,
                  Type = m.Type,
                  Location = m.Location,
                  Time = m.Time,
                  UserId = _userServices.GetId(),
              }).ToListAsync();

            var Id = _userServices.GetId();

            var user = await _userManager.FindByIdAsync(Id);

            var list = new List<EventModel>();

            foreach(var datum in data)
            {
                if (datum.InvitedBy != null)
                {
                    ArrayList Email = new ArrayList(datum.InvitedBy.Split(','));
                    if (Email.Contains(user.Email))
                    {
                        list.Add(datum);
                        Email = null;
                    }
                    else
                    {
                        Email = null;
                    }

                }
            }
            return list;
        }
    }
}
