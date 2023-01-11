using BooksEvents.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksEvents.Data.Repos
{
    public interface IEventsRepo
    {
        Task<int> AddNewEvent(EventModel eventModel);

        Task <List<EventModel>> GetAllEvent();

        Task<EventModel> GetEventById(int id);

        Task<int> Update(EventModel eventModel);

        Task<List<EventModel>> GetMyEvents();

        Task<List<EventModel>> InvitedTo(EventModel eventModel);
    }
}