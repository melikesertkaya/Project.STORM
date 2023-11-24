using Project.CORE.Utilities.Results;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Abstract
{
    public interface IProductCampaignDetailService
    {
        IResult Add(ProductCampaignDetail item);
        IResult Delete(ProductCampaignDetail item);
        IResult SoftDelete(Guid item);
        IResult Update(ProductCampaignDetail item);
        IDataResult<List<ProductCampaignDetail>> GetAllProductCampaignDetail();
        IDataResult<ProductCampaignDetail> GetProductCampaignDetail(Guid campaign);
    }
}
