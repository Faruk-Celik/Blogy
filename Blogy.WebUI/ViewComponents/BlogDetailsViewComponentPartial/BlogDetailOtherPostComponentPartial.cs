using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponentPartial
{
    public class BlogDetailOtherPostComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
