using System.Threading.Tasks;

namespace BooksEvents.Services
{
    public interface IUserServices
    {
        string GetId();
        bool LogedIn();
  
    }
}