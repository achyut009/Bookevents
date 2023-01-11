using BooksEvents.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BooksEvents.Services
{
    public class UserServices : IUserServices
    {
        private readonly IHttpContextAccessor _httpContext;

        private readonly UserManager<UserModel> _userManager;

        public UserServices(IHttpContextAccessor httpContext, UserManager<UserModel> userManager)
        {
            _httpContext = httpContext;

            _userManager = userManager;
        }
        public string GetId()
        {
            return _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public bool LogedIn()
        {
            return _httpContext.HttpContext.User.Identity.IsAuthenticated;
        }
      
    }
}
