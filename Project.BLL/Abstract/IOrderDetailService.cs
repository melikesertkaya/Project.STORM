using Project.CORE.Utilities.Results;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Abstract
{
    public interface IOrderDetailService
    {
        IResult Add(OrderDetail item);
        IResult Delete(OrderDetail item);
        IResult SoftDelete(Guid item);
        IResult Update(OrderDetail item);
        IDataResult<List<OrderDetail>> GetAllOrder(Guid userId);
        IDataResult<OrderDetail> GetOrder(Guid orderId);
    }
}
