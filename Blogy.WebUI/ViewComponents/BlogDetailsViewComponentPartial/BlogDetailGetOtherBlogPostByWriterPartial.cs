using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponentPartial
{
    public class BlogDetailGetOtherBlogPostByWriterPartial: ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
