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
   public interface ICampaignService
    {
        IResult AddCampaign(CreateCampaignRequest request);
        IResult DeleteCampaign(DeleteCampaignRequest request);

        IResult UpdateCampaignAsync(UpdateCampaignRequest request);
        IDataResult<List<GetAllCampaignQueryResponse>> GetAllCampaign();
        IDataResult<List<GetCampaignQueryResponse>> GetCampaign(Guid id);
    }
}
