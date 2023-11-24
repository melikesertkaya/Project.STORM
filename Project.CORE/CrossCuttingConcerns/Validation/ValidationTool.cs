using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.CrossCuttingConcerns
{
    public class ValidationTool
    {//IValidator Ilgılı metodun paremetrelerini validate etmek istedigimiz  Fluent validation classı (kurallarımızın oldugu class)
        //Bana bir IValidator ver yani ProductValidator object entity ise dogrulanacak class
        //Validate Parametreleri => Bana bir dogrulama kurallarının oldugu class ver ve dogrulanacak bir sınıf ver 
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            //object olmasının sebebi entity Dto herşeyi ekleyebilir oldugum için object yapıyorum.

            var result = validator.Validate(context);//valid ise
            if (!result.IsValid)//valid degilse 
            {
                throw new ValidationException(result.Errors);
            }

        }
    }
}
