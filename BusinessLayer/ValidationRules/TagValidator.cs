using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TagValidator : AbstractValidator<Tag>
    {
        public TagValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Etiket adını boş geçemezsiniz!");
                                //.MinimumLength(3).WithMessage("Etiket adı en az 3 karakter olmalıdır!")
                                //.MaximumLength(50).WithMessage("Etiket adı 50 karakterden fazla olamaz!");
        }
    }
}
