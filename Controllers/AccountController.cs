using BooksEvents.Data.Repos;
using BooksEvents.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksEvents.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepo _account;

        public AccountController(IAccountRepo account)
        {
            _account = account;
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel signupModel)
        {
            if (ModelState.IsValid)
            {
               var result = await _account.CreateEvent(signupModel);
                if (!result.Succeeded)
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(signupModel);
                }
            }
            ModelState.Clear();
            return View();
        }

        public IActionResult  Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(SignInModel signInModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await _account.PasswordSignIn(signInModel);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
                else if(result.IsNotAllowed)
                {
                    ModelState.AddModelError("","Confirm Your email via mail sent to your mail box");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Email id or password");
                }
            }
          
            return View(signInModel);

        }
        public async Task<IActionResult> Signout()
        {
            await _account.SignOut();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel changePasswordModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _account.ChangePassword(changePasswordModel);
                if (result.Succeeded)
                {
                    ModelState.Clear();
                    await _account.SignOut();
                    return RedirectToAction("Index", "Home");
                }
                foreach (var errorMessage in result.Errors)
                {
                    ModelState.AddModelError("", errorMessage.Description);
                }
                return View(changePasswordModel);
            }
            return View(changePasswordModel);
        }

        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmail(string uid , string token)
        {
           
            if (!string.IsNullOrEmpty(uid) && !string.IsNullOrEmpty(token))
            {
                token = token.Replace(' ','+');
               var result = await _account.ConfirmEmailAsync(uid, token);
                if (result.Succeeded)
                {
                    ViewBag.value = true;
                }
            }

            return View();
        }
    }
}
