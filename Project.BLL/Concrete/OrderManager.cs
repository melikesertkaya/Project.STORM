using AutoMapper;
using Microsoft.Extensions.Logging;
using Project.BLL.Abstract;
using Project.BLL.DTO.Request;
using Project.BLL.DTO.Response;
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
    public class OrderManager : IOrderService
    {
        IOrderDataAccess _orderDataAccess;
        IProductDataAccess _productDataAccess;
        IOrderDetailDataAccess _orderDetailDataAccess;
        ILogger<OrderManager> _logger;


        IMapper _mapper;

        public OrderManager(IOrderDataAccess orderDataAccess,
            IMapper mapper,
            IProductDataAccess productDataAccess,
            IOrderDetailDataAccess orderDetailDataAccess,
            ILogger<OrderManager> logger)
        {
            _orderDataAccess = orderDataAccess;
            _productDataAccess = productDataAccess;
            _orderDetailDataAccess = orderDetailDataAccess;
            _mapper = mapper;
            _logger = logger;
        }
        public IResult CreateOrder(CreateOrderRequest request)
        {
            try
            {
                if (request == null && request.Address == null && request.City == null)
                {
                    return new ErrorResult("");
                }
                var order = _mapper.Map<Order>(request);
                //TODO Order detay aktarılmasına bakılacak stocklar calısıyor.
                //var orderDetail = _mapper.Map<OrderDetail>(order);
                _orderDataAccess.CreateAsync(order);
                //  _orderDetailDataAccess.CreateAsync(orderDetail);
                var stockOut = _productDataAccess.Find(request.ProductId);
                stockOut.Stock -= request.Amount;
                _productDataAccess.UpdateAsync(stockOut);
                _logger.LogInformation($"OrderId:{order.Id} OrderDate:{order.CreatedDate} OrderNumber:{order.OrderNumber}");

                return new SuccessResult("");
            }
            catch (Exception ex)
            {

                _logger.LogInformation($"Order Log exception: {ex.Message}");
                return new ErrorResult("");

            }

        }



        public IResult DeleteOrder(DeleteOrderRequest request)
        {
            if (request.Id == Guid.Empty)
            {
                return new ErrorResult();
            }
            var deleted = _mapper.Map<Order>(request.Id);
            _orderDataAccess.Remove(request.Id);
            return new SuccessResult("Remove");
        }

        public IDataResult<List<GetAllOrderQueryResponse>> GetAllOrder()
        {
            var response = _mapper.Map<List<GetAllOrderQueryResponse>>(_orderDataAccess.GetAllAsync());
            if (response == null)
            {
                return new ErrorDataResult<List<GetAllOrderQueryResponse>>("");
            }
            return new SuccessDataResult<List<GetAllOrderQueryResponse>>(response);
        }

        public IDataResult<GetByOrderIdQueryResponse> GetOrder(Guid id)
        {
            var response = _mapper.Map<GetByOrderIdQueryResponse>(_orderDataAccess.Where(x => x.Id == id));
            if (response == null)
            {
                return new ErrorDataResult<GetByOrderIdQueryResponse>("");
            }
            return new SuccessDataResult<GetByOrderIdQueryResponse>(response);
        }



        public IResult UpdateOrder(UpdateOrderRequest request)
        {
            if (request.Id == Guid.Empty)
            {
                return new ErrorResult("");
            }
            var updated = _mapper.Map<Order>(request);
            _orderDataAccess.UpdateAsync(updated);
            return new SuccessResult("");
        }
    }
}
