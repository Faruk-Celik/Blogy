using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController ( SignInManager<AppUser> signInManager )
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index ()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index ( UserSignInViewModel m )
        {
            if (m.Username != null && m.Password != null)
            {
                var result = await _signInManager.PasswordSignInAsync(m.Username, m.Password, true, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Category");
                }
                else
                {
                    ModelState.AddModelError("", "Username or password is incorrect");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "Username and password are required");
                return View();
            }
            
        }   
    }
}
