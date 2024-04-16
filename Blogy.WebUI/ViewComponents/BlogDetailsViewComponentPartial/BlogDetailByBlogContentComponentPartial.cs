using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponentPartial
{
    public class BlogDetailByBlogContentComponentPartial: ViewComponent
    {
        private readonly IArticleService _articleService;

		public BlogDetailByBlogContentComponentPartial ( IArticleService articleService )
		{
			_articleService = articleService;
		}

		public IViewComponentResult Invoke (int id)
        {
            var values= _articleService.TGetById(id);
            return View(values);
        }
    }
}
