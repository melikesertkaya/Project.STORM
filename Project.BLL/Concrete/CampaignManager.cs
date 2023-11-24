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
    public class CampaignManager : ICampaignService
    {
        private readonly ICampaignDataAccess _campaignDataAccess;
        private readonly IMapper _mapper;
        private readonly ILogger<CampaignManager> _logger;
        public CampaignManager(ICampaignDataAccess campaignDataAccess,
            IMapper mapper,
            ILogger<CampaignManager> logger
            )
        {
            _campaignDataAccess = campaignDataAccess;
            _mapper = mapper;
            _logger = logger;
        }
        public IResult AddCampaign(CreateCampaignRequest request)
        {
            if (request == null)
            {
                return new ErrorResult("");
            }
            var campaign = _mapper.Map<Campaign>(request);
            _campaignDataAccess.CreateAsync(campaign);
            return new SuccessResult("");
        }

        public IResult DeleteCampaign(DeleteCampaignRequest request)
        {
            if (request.Id == Guid.Empty && request == null)
            {
                return new ErrorResult();
            }
            var deletedCampaign = _mapper.Map<Campaign>(request);
            _campaignDataAccess.Remove(deletedCampaign.Id);
            return new SuccessResult("Remove");
        }

        public IDataResult<List<GetAllCampaignQueryResponse>> GetAllCampaign()
        {
            var result = _mapper.Map<List<GetAllCampaignQueryResponse>>(_campaignDataAccess.GetAllAsync());
            if (result==null)
            {
                new ErrorDataResult<GetAllCampaignQueryResponse>("");
            }
            return new SuccessDataResult<List<GetAllCampaignQueryResponse>>(result);
        }

        public IDataResult<List<GetCampaignQueryResponse>>GetCampaign(Guid id)
        {
            var result = _mapper.Map<List<GetCampaignQueryResponse>>
                (_campaignDataAccess.Where(x => x.Id == id));
            return new SuccessDataResult<List<GetCampaignQueryResponse>>(result);
        }

     

        public IResult UpdateCampaignAsync(UpdateCampaignRequest request)
        {
            if (request == null && request.Id == Guid.Empty)
            {
                return new ErrorResult("");
            }
            var updatedCampaign = _mapper.Map<Campaign>(request);
            _campaignDataAccess.UpdateAsync(updatedCampaign);
            return new SuccessResult("");
        }
    }
}
