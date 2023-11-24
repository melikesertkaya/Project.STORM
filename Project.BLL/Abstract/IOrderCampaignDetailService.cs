using Project.CORE.Utilities.Results;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Abstract
{
    public interface IOrderCampaignDetailService
    {
        IResult Add(OrderCampaignDetail item);
        IResult Delete(OrderCampaignDetail item);
        IResult SoftDelete(Guid item);
        IResult UpdateAsync(OrderCampaignDetail item);
        IDataResult<List<OrderCampaignDetail>> GetAllOrderCampaignDetail();
        IDataResult<OrderCampaignDetail> GetOrderCampaignDetail(Guid id);
    }
}

