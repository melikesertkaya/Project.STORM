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
    public interface IProductService
    {
        IDataResult<List<ProductGetByIdQueryResponse>> GetProductID(Guid id);
        //IDataResult<List<ProductDetailDto>> GetProductDetail();
        IDataResult<List<GetByPriceProductQueryResponse>> GetByPrice(decimal min, decimal max);
        IDataResult<List<GetAllProductQueryResponse>> GetAll();
        
        IResult Add(CreateProductRequest request);
        IResult Delete(DeleteProductRequest request);
        IResult Update(UpdateProductRequest request);
    
    }
}
