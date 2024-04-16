using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents
{
	public class BlogListComponentPartial: ViewComponent
	{
		private readonly IArticleService _articleService;

		public BlogListComponentPartial ( IArticleService articleService )
		{
			_articleService = articleService;
		}

		

		public IViewComponentResult Invoke ()
		{
			var values = _articleService.TGetArticleWithWriter();
			return View(values);
		}
	}
}
