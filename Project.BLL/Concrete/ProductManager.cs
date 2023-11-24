using AutoMapper;
using Microsoft.Extensions.Logging;
using Project.BLL.Abstract;
using Project.BLL.DTO.Request;
using Project.BLL.DTO.Response;
using Project.BLL.FluentValidation;
using Project.CORE.Aspect.Caching;
using Project.CORE.Aspect.SecurityAspect;
using Project.CORE.Aspect.Validation;
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
    public class ProductManager : IProductService
    {
        private readonly IProductDataAccess _productDataAccess;
       private readonly IMapper _mapper;
       private readonly ILogger<ProductManager> _logger;

        public ProductManager(IProductDataAccess productDataAccess,
            IMapper mapper,
            ILogger<ProductManager> logger
            )
        {
            _productDataAccess = productDataAccess;
            _mapper = mapper;
            _logger = logger;
        }

        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("ProductService.Get")]
        [SecuredOperation("product.add,admin")]

        public IResult Add(CreateProductRequest request)
        {
            if (request == null && request.Stock <= 0)
            {
                return new ErrorResult("");
            }
            var product = _mapper.Map<Product>(request);
             _productDataAccess.CreateAsync(product);
            return new SuccessResult("Eklendi Kardeş");

        }

        public IResult Delete(DeleteProductRequest request)
        {
            if (request.Id == Guid.Empty && request == null)
            {
                return new ErrorResult();
            }
            var deletedProduct = _mapper.Map<Product>(request);
            _productDataAccess.Remove(deletedProduct.Id);
            return new SuccessResult("Remove");
        }

        [CacheAspect]
        public IDataResult<List<GetAllProductQueryResponse>> GetAll()
        {

            var result = _mapper.Map<List<GetAllProductQueryResponse>>(_productDataAccess.GetAllAsync());
            if (result == null)
            {
                new ErrorDataResult<GetAllProductQueryResponse>("");
            }
            return new SuccessDataResult<List<GetAllProductQueryResponse>>(result);

        }


        public IDataResult<List<GetByPriceProductQueryResponse>> GetByPrice(decimal min, decimal max)
        {
            if (min == 0 && max <=0 )
            {
                return new ErrorDataResult<List<GetByPriceProductQueryResponse>>("");
            }
            var result =  _mapper.Map<List<GetByPriceProductQueryResponse>>(_productDataAccess.Where(x => x.UnitInPrice >= min && x.UnitInPrice <= max));
            if (result != null)
            {
                return new SuccessDataResult<List<GetByPriceProductQueryResponse>>(result);

            }
            return new ErrorDataResult<List<GetByPriceProductQueryResponse>>("Ürün bulunamadı");


        }

        [CacheAspect]
        public IDataResult<List<ProductGetByIdQueryResponse>> GetProductID(Guid id)
        {
            var result = _mapper.Map<List<ProductGetByIdQueryResponse>>(_productDataAccess.Where(x => x.Id == id));

            return new SuccessDataResult<List<ProductGetByIdQueryResponse>>(result);
        }



        [CacheRemoveAspect("ProductService.Get")]
        public IResult Update(UpdateProductRequest request)
        {
            if (request == null && request.Id == Guid.Empty && request.UnitInPrice <0 && request.Stock <0)
            {
                return new ErrorResult("");
            }
           var updatedProduct =  _mapper.Map<Product>(request);
            _productDataAccess.UpdateAsync(updatedProduct);
            return new SuccessResult("");
        }
    }
}
