using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsByCoverInfoComponentPartial
{
    public class BlogDetailByCoverInfoComponentPartial: ViewComponent
    {
        private readonly IArticleService _articleService;

		public BlogDetailByCoverInfoComponentPartial ( IArticleService articleService )
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
