using BooksEvents.Models;
using System.Threading.Tasks;

namespace BooksEvents.Services
{
    public interface IEmailService
    {
        Task SendTestEmail(UserEmailOptionModel userEmailOption);
        Task SendEmailConfirmation(UserEmailOptionModel userEmailOption);
    }
}