using BooksEvents.Models;
using BooksEvents.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksEvents.Data.Repos
{
    public class AccountRepo : IAccountRepo
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly SignInManager<UserModel> _usersigin;
        private readonly RoleManager<IdentityRole> _rolemanager;
        private readonly IUserServices _userServices;
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;

        public AccountRepo(UserManager<UserModel> userManager, SignInManager<UserModel> usersigin,IUserServices userServices, IEmailService emailService, IConfiguration configuration, RoleManager<IdentityRole> rolemanager)
        {
            _userManager = userManager;

            _usersigin = usersigin;

            _userServices = userServices;

            _emailService = emailService;

            _configuration = configuration;

            _rolemanager = rolemanager;
        }

        public async Task<IdentityResult> CreateEvent(SignUpModel signUpModel)
        {
            var user = new UserModel()
            {

                Email = signUpModel.Email,
                UserName = signUpModel.Email,
                FirstName = signUpModel.FirstName,
                LastName = signUpModel.LastName,
                Dob = signUpModel.DOB,
            };
            var result = await _userManager.CreateAsync(user, signUpModel.Password);
            if (result.Succeeded)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                if (!string.IsNullOrEmpty(token))
                {
                 // await  SendEmailConfirmation(user,token);
                }
            }
            return result;
        }
        public async Task<IdentityResult> ConfirmEmailAsync(string uid , string token)
        {
            var user = await _userManager.FindByIdAsync(uid);
          return  await  _userManager.ConfirmEmailAsync(user,token);
        }

        public async Task<SignInResult> PasswordSignIn(SignInModel signin)
        {
            var result = await _usersigin.PasswordSignInAsync(signin.Email, signin.Password, signin.RemeberMe, false);
            return result;
        }

        public async Task SignOut()
        {
            await _usersigin.SignOutAsync();

        }
        public async Task<IdentityResult> ChangePassword(ChangePasswordModel changePasswordModel)
        {
            var id = _userServices.GetId();

            var user = await _userManager.FindByIdAsync(id);

           return await _userManager.ChangePasswordAsync(user, changePasswordModel.CurrentPassword, changePasswordModel.ConfirmNewPassword);

        }

      
        private async Task SendEmailConfirmation(UserModel user,string token)
        {
          
            string appDomain = _configuration.GetSection("Application:AppDomain").Value;
            string link = _configuration.GetSection("Application:EmailConfirmation").Value;
            string link1 = appDomain + link;

            UserEmailOptionModel userEmailOption = new UserEmailOptionModel
            {
                 ToEmails =  user.Email  ,
                 PlaceHolders = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string,string>("{{UserName}}",user.FirstName),
                    new KeyValuePair<string,string>("{{link}}", string.Format(appDomain + link,user.Id,token)),

                }
            };
            //await _emailService.SendEmailConfirmation(userEmailOption);
        }
    }
}
