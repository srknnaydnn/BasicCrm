
using Business.Abscrate;
using Business.Concrete;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class User : Controller
    {
        private IUserServices userServices;
        

        public User()
        {
            userServices = new UsersManagers();
            
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
     
        public async Task<IActionResult> Login(Users users)
        {
            var user = userServices.UserById(users);
            
            if (user != null)
            {
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,users.Username)
                    };
                var useridentity = new ClaimsIdentity(claims, "Login");
                
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                
                return RedirectToAction("Index", "Customer");

            }
            
            return View();
        }

    
      
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Users user)
        {
            {
                if (ModelState.IsValid)
                {
                    userServices.CreateUser(user);
 
                    return RedirectToAction("Login");
                }
                return View();

            }
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View("Login");
        }
    }
}
