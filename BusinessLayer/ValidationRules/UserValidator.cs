using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz!");
            //.MinimumLength(3).WithMessage("Kategori adı en az 3 karakter olmalıdır!")
            //.MaximumLength(50).WithMessage("Kategori adı 50 karakterden fazla olamaz!");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanını boş geçemezsiniz!");
            //.EmailAddress().WithMessage("Email adresiniz geçerli formatta değil. Lütfen geçerli formatta giriniz!")
            //.MaximumLength(50).WithMessage("Emaıl alanı 50 karakterden fazla olamaz!");

            RuleFor(x => x.Name).NotEmpty().WithMessage("Şifre alanını boş geçemezsiniz!");
                                //.MinimumLength(3).WithMessage("Şifreniz en az 3 karakter olmalıdır!")
                                //.MaximumLength(50).WithMessage("Şifreniz 50 karakterden fazla olamaz!");
        }
    }
}
