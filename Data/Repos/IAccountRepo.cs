using BooksEvents.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BooksEvents.Data.Repos
{
    public interface IAccountRepo
    {
        Task<IdentityResult> CreateEvent(SignUpModel signUpModel);
        Task<SignInResult> PasswordSignIn(SignInModel signin);
        Task SignOut();
        Task<IdentityResult> ChangePassword(ChangePasswordModel changePasswordModel);
        Task<IdentityResult> ConfirmEmailAsync(string uid, string token);


    }
}