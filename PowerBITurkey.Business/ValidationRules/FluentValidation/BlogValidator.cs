using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using PowerBITurkey.Entities.Concrete;

namespace PowerBITurkey.Business.ValidationRules.FluentValidation
{
    public class BlogValidator :AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(b=>b.BlogContext).NotEmpty().WithMessage("BlogContext Boş Bırakılamaz");
            RuleFor(b => b.BlogContext).MinimumLength(20).WithMessage("BlogContext en az 20 karakter içermelidir.");
            RuleFor(b => b.BlogTitle).Length(2, 50).WithMessage("Blog Title minimum 2 maksimum 50 karakter olmalıdır.");
            RuleFor(b => b.BlogTitle).NotEmpty().WithMessage("Blog Title boş bırakılamaz");
        }
    }
}
