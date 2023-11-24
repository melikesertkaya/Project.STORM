using FluentValidation;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.FluentValidation
{
    public class OrderValidator: AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(x => x.OrderDate).NotNull();
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.OrderNumber).NotNull();
            RuleFor(x => x.Address).NotNull();
            RuleFor(x => x.City).NotNull();
            
        }
    }
}
