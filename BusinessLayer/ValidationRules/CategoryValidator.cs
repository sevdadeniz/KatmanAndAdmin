using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz!");
              //               .MinimumLength(3).WithMessage("Kategori adı en az 3 karakter olmalıdır!")
        //                        .MaximumLength(50).WithMessage("Kategori adı 50 karakterden fazla olamaz!");
        //}
        }
    }
}