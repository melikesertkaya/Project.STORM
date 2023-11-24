using Project.BLL.DTO.Request;
using Project.BLL.DTO.Response;
using Project.CORE.Utilities.Results;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Abstract
{
    public interface IBasketService
    {
 
        IResult AddToBasket(AddToBasketRequest request);
        IResult DeleteToBasket(DeleteBasketRequest request);
        IResult DeleteAllToBasket(DeleteAllToBasketRequest request);

        IDataResult<GetToBasketResponse> GetToCustomerBasket(GetToBasketRequest request);

    }
}
