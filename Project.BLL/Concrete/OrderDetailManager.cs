using Microsoft.Extensions.Logging;
using Project.BLL.Abstract;
using Project.CORE.Utilities.Results;
using Project.DAL.Abstract;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDataAccess _orderDetailDataAccess;
        ILogger<OrderDetailManager> _logger;
        public OrderDetailManager(IOrderDetailDataAccess orderDataAccess,
             ILogger<OrderDetailManager> logger)
        {
            _orderDetailDataAccess = orderDataAccess;
            _logger = logger;
        }
        public IResult Add(OrderDetail item)
        {
            if (item == null)
            {
                return new ErrorResult("");
            }
            return new SuccessResult("");
        }

        public IResult Delete(OrderDetail item)
        {
            if (item.Id == Guid.Empty && item == null)
            {
                return new ErrorResult();
            }
            _orderDetailDataAccess.Remove(item.Id);
            return new SuccessResult("Remove");
        }

        public IDataResult<List<OrderDetail>> GetAllOrder(Guid userId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<OrderDetail> GetOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public IResult SoftDelete(Guid item)
        {
            throw new NotImplementedException();
        }

        public IResult Update(OrderDetail item)
        {
            if (item == null && item.Id == Guid.Empty)
            {
                return new ErrorResult("");
            }
            _orderDetailDataAccess.UpdateAsync(item);
            return new SuccessResult("");
        }
    }

}
