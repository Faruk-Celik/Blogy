using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController ( UserManager<AppUser> userManager )
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index ()
        {
            return View();
        }   
        [HttpPost]
        public async Task<IActionResult> Index ( CreateRegisterViewModel m )
        {
            if(m.Password != null)
            {
                AppUser user = new AppUser
                {
                    Name = m.Name,
                    Surname = m.Surname,
                    UserName = m.Username,
                    Email = m.Email,
                    Description = "a",
                    ImageUrl = "b"
                };
                var result = await _userManager.CreateAsync(user, m.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Password is required");
                return View();
            }
        
                
                
          
        }   

    }
}
