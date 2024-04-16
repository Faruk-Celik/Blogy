using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponentPartial
{
    public class BlogDetailTagsComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
