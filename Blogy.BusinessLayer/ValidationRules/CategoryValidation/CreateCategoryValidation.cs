using Blogy.EntityLayer.Concrete;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.ValidationRules.CategoryValidation
{
    public class CreateCategoryValidation:AbstractValidator<Category>
    {
        public CreateCategoryValidation ()
        {
            RuleFor(x=> x.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez");
            RuleFor(x=> x.CategoryName).MinimumLength(3).WithMessage("Kategori adı en az 3 karakter olmalıdır");
            RuleFor(x=> x.CategoryName).MaximumLength(30).WithMessage("Kategori adı en fazla 30 karakter olmalıdır");
        }
    }
}
