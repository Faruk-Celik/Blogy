using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.ValidationRules.ArticleValidation
{
    public class CreateArticleValidation:AbstractValidator<Article>
    {
        public CreateArticleValidation ()
        {
            RuleFor(x=> x.CategoryId).NotEmpty().WithMessage("Lütfen Makale için Bir Kategori Seçiniz");
            RuleFor(x=> x.Title).NotEmpty().WithMessage("Makale Başlığı Boş Geçilemez");
            RuleFor(x=> x.Description).NotEmpty().WithMessage("Makale Açıklaması Boş Geçilemez");
            RuleFor(x=> x.Title).MinimumLength(5).WithMessage("Makale Başlığı en az 5 karakter olmalıdır");
            RuleFor(x=> x.Title).MaximumLength(100).WithMessage("Makale Başlığı en fazla 100 karakter olmalıdır");


        }   
    }
}
