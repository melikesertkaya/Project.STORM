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
    public interface IOrderService
    {
        IResult CreateOrder(CreateOrderRequest request);
 
        IResult DeleteOrder(DeleteOrderRequest request);
        IResult UpdateOrder(UpdateOrderRequest request);
        IDataResult<List<GetAllOrderQueryResponse>> GetAllOrder();
        IDataResult<GetByOrderIdQueryResponse> GetOrder(Guid id);
    }
}
