using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.ValidationRules.CategoryValidation
{
    public class UpdateCategoryValidation : AbstractValidator<Category>
    {
        public UpdateCategoryValidation ()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez").MinimumLength(3).WithMessage("Kategori adı en az 3 karakter olmalıdır").MaximumLength(30).WithMessage("Kategori adı en fazla 30 karakter olmalıdır").Equal("a").WithMessage("Lütfen Kategori adına a Harfi ekleyiniz");
        }
    }
}
