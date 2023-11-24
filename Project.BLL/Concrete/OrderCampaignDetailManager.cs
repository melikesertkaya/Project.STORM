using AutoMapper;
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
    public class OrderCampaignDetailManager : IOrderCampaignDetailService
    {
        private readonly IOrderCampaignDetailDataAccess _orderCampaignDetailDataAccess;
        private readonly IMapper _mapper;
        private readonly ILogger<OrderCampaignDetailManager> _logger;
        public OrderCampaignDetailManager(IOrderCampaignDetailDataAccess orderCampaignDetailDataAccess,
            IMapper mapper,
            ILogger<OrderCampaignDetailManager> logger)
        {
            _orderCampaignDetailDataAccess = orderCampaignDetailDataAccess;
            _mapper = mapper;
            _logger = logger;
        }
        public IResult Add(OrderCampaignDetail item)
        {
            if (item==null)
            {
                return new ErrorResult("");
            }
            return new SuccessResult("");
        }

        public IResult Delete(OrderCampaignDetail item)
        {
            if (item==null && item.Id==Guid.Empty)
            {
                return new ErrorResult();
            }
            _orderCampaignDetailDataAccess.Remove(item.Id);
            return new SuccessResult("Remove");
        }

        public IDataResult<List<OrderCampaignDetail>> GetAllOrderCampaignDetail()
        {
            return new SuccessDataResult<List<OrderCampaignDetail>>
                (_orderCampaignDetailDataAccess.GetAllAsync());
        }

        public IDataResult<OrderCampaignDetail> GetOrderCampaignDetail(Guid id)
        {
            throw new NotImplementedException();
        }

        public IResult SoftDelete(Guid item)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateAsync(OrderCampaignDetail item)
        {
            if (item==null && item.Id==Guid.Empty)
            {
                return new ErrorResult("");
            }
            _orderCampaignDetailDataAccess.UpdateAsync(item);
            return new SuccessResult("");
        }
        }
    }

