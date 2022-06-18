using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webLab2._6.Models;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

namespace webLab2._6.Controllers
{
    public class AuthController : Controller
    {

        private readonly ForumContext _db;
        public AuthController(ForumContext context)
        {
            _db = context;
        }


        [HttpGet]
        public IActionResult Register()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var result = Validate(model.Password);
                if (result.Result.Succeeded)
                {
                    UserModel user = null;
                    user = _db.Users.Where(u => u.Email == model.Email).FirstOrDefault();
                    if (user != null)
                    {
                        ModelState.AddModelError(String.Empty, "Email is taken.");
                        return View();
                    }

                    int rid = 2;            // Если в email содержится "admin" роль регистрирующегося будет Администратор.
                    if (model.Email.Contains("admin")) // Все остальные будут иметь роль User.
                    {
                        rid = 1;
                    }

                    _db.Users.Add(new UserModel
                    {
                        Email = model.Email,
                        Password = model.Password,
                        RoleId = rid
                    });

                    await _db.SaveChangesAsync();

                    return View("LogIn");
                }


                foreach(var error in result.Result.Errors)
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                }
                return View();
            }
            return View(model);
        }


        [HttpGet]     
        public IActionResult LogIn()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]    
        public async Task<IActionResult> LogIn(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                UserModel user = await _db.Users.FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
                if (user != null)
                {
                    await Authenticate(user.Id, model.Email, user.RoleId); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(String.Empty, "Incorrect login or/and password.");
                    return View(model);
                }
            }

            return View(model);
        }


        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }


        private static Task<IdentityResult> Validate(string item)
        {            
            int RequiredLength = 6;

            if (String.IsNullOrEmpty(item) || item.Length < RequiredLength)
            {
                var identityError = new IdentityError();
                identityError.Description = String.Format("The required length of the password is {0}", RequiredLength);
                return Task.FromResult(IdentityResult.Failed(identityError));
            }

            List<IdentityError> errors = new();

            if(!Regex.IsMatch(item, @"[0-9]"))
            {
                var identityError = new IdentityError();
                identityError.Description = String.Format("Password must have at least one digit ('0-9').");
                errors.Add(identityError);
            }

            if (!Regex.IsMatch(item, @"[#$^+=!*()@%&]"))
            {
                var identityError = new IdentityError();
                identityError.Description = String.Format("Password must have at least one non alphanumeric character.");
                errors.Add(identityError);
            }

            if (!Regex.IsMatch(item, @"[a-z]"))
            {
                var identityError = new IdentityError();
                identityError.Description = String.Format("Password must have at least one lowercase ('a-z').");
                errors.Add(identityError);
            }

            if (!Regex.IsMatch(item, @"[A-Z]"))
            {
                var identityError = new IdentityError();
               identityError.Description = String.Format("Password must have at least one uppercase ('A-Z').");
               errors.Add(identityError);
            }

            if (errors.ToArray().Length == 0)
            {
                return Task.FromResult(IdentityResult.Success);
            } else
            {
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }
            
        }

        private async Task Authenticate(int Id, string userName, int RoleId)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim("Id", Id.ToString()),
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName),
                new Claim("RoleId", RoleId.ToString())
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}

