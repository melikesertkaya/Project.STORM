using Microsoft.AspNetCore.Mvc;
using Project.BLL.Abstract;
using Project.BLL.DTO.Request;
using Project.BLL.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        ICampaignService _campaignService;
        public CampaignController(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        [HttpGet("getCampaignbyid")]
        [ProducesResponseType((int)(HttpStatusCode.NotFound))]
        [ProducesResponseType(typeof(GetCampaignQueryResponse), (int)HttpStatusCode.OK)]
        public IActionResult GetCampaignById(Guid id)
        {
            var result = _campaignService.GetCampaign(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Messange);
        }
        [HttpGet("getAllCampaign")]
        [ProducesResponseType((int)(HttpStatusCode.NotFound))]
        [ProducesResponseType(typeof(GetAllCampaignQueryResponse), (int)HttpStatusCode.OK)]
        public IActionResult GetCampaignList()
        {
            var result = _campaignService.GetAllCampaign();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Messange);
        }

        [HttpPost("createCampaign")]
        [ProducesResponseType(typeof(CreateCampaignRequest), (int)HttpStatusCode.Created)]
        public IActionResult CreateCampaign(CreateCampaignRequest campaign)
        {
            var result = _campaignService.AddCampaign(campaign);

            if (result.Success)
            {
                return Ok(result.Messange);
            }

            return BadRequest(result.Messange);
        }
        [HttpPut("updateCampaign")]
        [ProducesResponseType(typeof(UpdateCampaignRequest), (int)HttpStatusCode.OK)]
        public IActionResult UpdateCampaign(UpdateCampaignRequest campaign)
        {

            var result = _campaignService.UpdateCampaignAsync(campaign);
            if (result.Success)
            {
                return Ok(result.Messange);
            }

            return BadRequest(result.Messange);
        }
        [HttpDelete("deleteCampaign")]
        [ProducesResponseType(typeof(DeleteCampaignRequest), (int)HttpStatusCode.OK)]
        public IActionResult DeleteCampaign(DeleteCampaignRequest campaign)
        {
            var result =_campaignService.DeleteCampaign(campaign);
            if (result.Success)
            {
                return Ok(result.Messange);
            }
            return BadRequest(result.Messange);
        }
    } 
}
