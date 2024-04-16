using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponentPartial
{
    public class BlogDetailByWriterInfoComponentPartial: ViewComponent
    {
        private readonly IArticleService _articleService;

        public BlogDetailByWriterInfoComponentPartial ( IArticleService articleService )
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke (int id)
        {
            var values = _articleService.TGetWriterInfoByArticleWriter(id);
            return View(values);
        }
    }
}
