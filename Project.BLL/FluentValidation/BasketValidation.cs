using FluentValidation;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.FluentValidation
{
   public class BasketValidation: AbstractValidator<Basket>
    {
        public BasketValidation()
        {
        }
    }
}
