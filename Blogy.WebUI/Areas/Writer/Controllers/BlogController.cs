using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class BlogController : Controller
    {


        private readonly IArticleService _articleService;
        private readonly UserManager<AppUser> _userManager;
        private readonly ICategoryService _categoryService;

        public BlogController ( IArticleService articleService, UserManager<AppUser> userManager, ICategoryService categoryService )
        {
            _articleService = articleService;
            _userManager = userManager;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> MyBlogList ()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.id = user.Id + "" + user.UserName + "" + user.Surname;

            var values = _articleService.TGetArticleByWriter(user.Id);
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateBlog ()
        {
            List<SelectListItem> values = (from x in _categoryService.TGetListAll()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog ( Article article )
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            article.AppUserId = user.Id;
            article.WriterId = 1;
            article.CreatedDate = DateTime.Now;
            _articleService.TInsert(article);
            return RedirectToAction("MyBlogList");
        }
        public IActionResult DeleteBlog ( int id )
        {
            _articleService.TDelete(id);
            return RedirectToAction("MyBlogList");
        }
    }
}