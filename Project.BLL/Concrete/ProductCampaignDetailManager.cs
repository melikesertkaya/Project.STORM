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
    public class ProductCampaignDetailManager : IProductCampaignDetailService
    {
        IProductCampaignDetailDataAccess _productCampaignDetailDataAccess;
        ILogger<ProductCampaignDetailManager> _logger;
        public ProductCampaignDetailManager(IProductCampaignDetailDataAccess productCampaignDetailDataAccess,
          ILogger<ProductCampaignDetailManager> logger )
        {
            _productCampaignDetailDataAccess = productCampaignDetailDataAccess;
            _logger = logger;
        }
        public IResult Add(ProductCampaignDetail item)
        {
            if (item == null)
            {
                return new ErrorResult("");
            }
            return new SuccessResult("");
        }

        public IResult Delete(ProductCampaignDetail item)
        {
            if (item.Id == Guid.Empty && item == null)
            {
                return new ErrorResult();
            }
            _productCampaignDetailDataAccess.Remove(item.Id);
            return new SuccessResult("Remove");
        }

        public IDataResult<List<ProductCampaignDetail>> GetAllProductCampaignDetail()
        {
            throw new NotImplementedException();
        }

        public IDataResult<ProductCampaignDetail> GetProductCampaignDetail(Guid campaign)
        {
            throw new NotImplementedException();
        }

        public IResult SoftDelete(Guid item)
        {
            throw new NotImplementedException();
        }

        public IResult Update(ProductCampaignDetail item)
        {
            if (item == null && item.Id == Guid.Empty)
            {
                return new ErrorResult("");
            }
            _productCampaignDetailDataAccess.UpdateAsync(item);
            return new SuccessResult("");
        }
    }
}
