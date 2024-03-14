using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class StatisticController : Controller
    {
        private readonly ICategoryService _CategoryService;

        public StatisticController ( ICategoryService categoryService )
        {
            _CategoryService = categoryService;
        }

        public IActionResult Index ()
        {
           ViewBag.v= _CategoryService.TGetCategoryCount();
            return View();
        }
        
    }
}
