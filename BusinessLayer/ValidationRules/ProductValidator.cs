using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı boş geçilemez!");
                                //.MinimumLength(2).WithMessage("Ürün adı 2 karakteden fazla olamaz!")
                                //.MaximumLength(20).WithMessage("Ürün adı 20 karakterden fazla olamaz!");

            RuleFor(x => x.Price).Must((x, list, context) =>
            {
                if (x.Price.ToString() != "")
                {
                    context.MessageFormatter.AppendArgument("Price", x.Price);
                    return Int32.TryParse(x.Price.ToString(), out int number);
                }
                return true;
            }).WithMessage("")
                                .NotEmpty().WithMessage("Ürün fiyatı boş geçilemez!");

            RuleFor(x => x.Quantity).Must((x, list, context) =>
            {
                if (x.Price.ToString() != "")
                {
                    context.MessageFormatter.AppendArgument("Quantity", x.Quantity);
                    return Int32.TryParse(x.Quantity.ToString(), out int number);
                }
                return true;
            }).WithMessage("")
                                .NotEmpty().WithMessage("Ürün adedi boş geçilemez!");

        }
    }
}
