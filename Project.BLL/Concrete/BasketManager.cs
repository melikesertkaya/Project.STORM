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
    public class BasketManager : IBasketService
    {
        IBasketDataAccess _basketDataAccess;
        IProductDataAccess _productDataAccess;
        IUserDataAccess _userDataAccess;
        IMapper _mapper;
        ILogger<BasketManager> _logger;

        public BasketManager(IBasketDataAccess basketDataAccess,
            IMapper mapper,
            IProductDataAccess productDataAccess,
            IUserDataAccess userDataAccess,
            ILogger<BasketManager> logger)
        {
            _basketDataAccess = basketDataAccess;
            _productDataAccess = productDataAccess;
            _userDataAccess = userDataAccess;
            _mapper = mapper;
            _logger = logger;
        }



        public IResult AddToBasket(AddToBasketRequest request)
        {
           
            var customerBasket = _basketDataAccess.Where(x => x.CustomerId == request.CustomerId);
            var result = _mapper.Map<Basket>(request);
            if (customerBasket == null)
            {
                var basket = _basketDataAccess.CreateAsync(result);
                return new SuccessResult();

            }
            customerBasket.Add(result);
            return new SuccessResult();

        }



        public IResult DeleteAllToBasket(DeleteAllToBasketRequest request)
        {
            if (request.CartId == Guid.Empty && request.CustomerId == Guid.Empty)
            {
                return new ErrorResult("");
            }
            var result = _mapper.Map<List<Basket>>(request);
            _basketDataAccess.DeleteRange(result);
            var stock = _productDataAccess.Find(request.ProductId);
            stock.Stock += request.Amount;
            _productDataAccess.UpdateAsync(stock);
            return new SuccessResult("");
        }



        public IResult DeleteToBasket(DeleteBasketRequest request)
        {

            if (request.ProductId == Guid.Empty && request.CustomerId == Guid.Empty)
            {
                return new ErrorResult();
            }
            var result = _mapper.Map<Basket>(request);
            _basketDataAccess.Remove(result.ProductId);
            var stock = _productDataAccess.Find(request.ProductId);
            stock.BasketStock += request.Amount;
            stock.Stock -= request.Amount;
            _productDataAccess.UpdateAsync(stock);
            return new SuccessResult("");
        }

        public IDataResult<GetToBasketResponse> GetToCustomerBasket(GetToBasketRequest request)
        {
            if (request == null)
            {
                return new ErrorDataResult<GetToBasketResponse>("");
            }
            var result =  _basketDataAccess.FirstOrDefault(x => x.CustomerId == request.CustomerId);

            var basket = _mapper.Map<GetToBasketResponse>(result);
            return new SuccessDataResult<GetToBasketResponse>(basket);
        }
    }
}
