using FluentValidation;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotNull().NotEmpty().MinimumLength(0).MaximumLength(50).WithMessage("Ürün ismi boş olamaz");
            RuleFor(x => x.Point).NotEmpty().WithMessage("Puan Bos Geçilemez");
            RuleFor(x => x.ProductCode).NotEmpty().WithMessage("");
            RuleFor(x => x.Stock).NotEmpty().NotNull().WithMessage("");
            RuleFor(x => x.UnitInPrice).NotEmpty().WithMessage("");
            RuleFor(x => x.Category.CategoryName).NotEmpty().NotNull();
            RuleFor(x => x.UnitInPriceDiscount).NotNull();
            
            
        }
    }
}
