using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.viewComponents
{
	public class BlogListHeadComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
