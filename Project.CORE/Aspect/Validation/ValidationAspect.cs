using Castle.DynamicProxy;
using FluentValidation;
using Project.CORE.CrossCuttingConcerns;
using Project.CORE.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Aspect.Validation
{
   public class ValidationAspect: MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)//validatortype'ı ver diyor.
        {
            //Defensive coding 
            if (!typeof(IValidator).IsAssignableFrom(validatorType))//validatorType IValidator'mü atanabiliyormu diye kontrul ediyor.
            {
                throw new System.Exception("Bu bir doğrulama sınıfı degildir.");//valdatiortype dogru degil ise hata fırlat 
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)//OnBefore'u ovverride ettik. Somutunu verdik...
        {

            var validator = (IValidator)Activator.CreateInstance(_validatorType);//reflection calısma anında birşeyleri calıstırmanı saglar.(birşeyleri newliyoruz ya o newlemeyi calısma anında yapmamızı saglar)
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];//validatorun calısma tipini bul.onun generic argumanını bul
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);//onun da parametrelerini bul ( calıstıgın ilgili metodun parametrelerini bul demek)
            foreach (var entity in entities)
            {//ValidationTool'u kullanarak 
                ValidationTool.Validate(validator, entity);
            }
        }
        //protected override void OnException(IInvocation invocation, Exception e)
        //{
        //      //Hata aldıgında calıscak kodlar 
        //}

    }
}
