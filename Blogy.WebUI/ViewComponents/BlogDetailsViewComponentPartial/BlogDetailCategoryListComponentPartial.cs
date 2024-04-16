using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponentPartial
{
    public class BlogDetailCategoryListComponentPartial: ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public BlogDetailCategoryListComponentPartial (ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke ()
        {
            var values = _categoryService.TGetListAll();
            return View(values);
        }
    }
}
