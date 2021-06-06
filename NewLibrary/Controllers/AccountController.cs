using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewLibrary.DataBaseConnection;
using NewLibrary.DataBaseConnection.Factory;
using NewLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NewLibrary.Controllers
{
    public class AccountController : Controller
    {
        public AccountController() { }
        [HttpGet]
        public IActionResult Register(string returnUrl)
        {

            return View();
        }
        
        [HttpPost]
        public IActionResult Register(Profile profile)
        {
            var lstUser = Factory.GetAllProfiles(DatabaseConnection.GetAllProfiles());
            if (lstUser.Count != 0)
            {
                foreach (Profile u in lstUser)
                {
                    if (u.NickName != profile.NickName)
                    {
                        if (ModelState.IsValid)
                        {
                            Factory.InsertProfile(profile);
                            return Redirect("/");
                        }
                        else { return Redirect("/"); }
                    }
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    Factory.InsertProfile(profile);
                    return Redirect("/");
                }
            }
            TempData["Error"] = "Ошибка, данные введены неверно";
            return View();
        }
        [HttpGet("login")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(Profile profile, string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            var listUser = Factory.GetAllProfiles(DatabaseConnection.GetAllProfiles());

            foreach (Profile us in listUser)
            {
                if (us.NickName == profile.NickName && us.Password == profile.Password)
                {
                    var claims = new List<Claim>();
                    claims.Add(new Claim("Id", us.Id.ToString()));
                    claims.Add(new Claim("Nick",us.NickName));
                    //claims.Add(new Claim(ClaimTypes.NameIdentifier, us.Name));
                    //claims.Add(new Claim(ClaimTypes.Name, us.Id.ToString()));
                    //claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    // var t1 = claims[0].Value;
                    // var t2 = claims[1].Value;
                    await HttpContext.SignInAsync(claimsPrincipal);
                    if (returnUrl != null)
                    {
                        return Redirect(returnUrl);
                    }
                    else
                        return Redirect("/");

                }
            }
            TempData["Error"] = "Ошибка, Логин или пароль введены неверно";
            return View("login");
        }
        [Authorize]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
