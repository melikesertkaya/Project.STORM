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
    public class BasketController : ControllerBase
    {
        IBasketService _basketService;
        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }
       
        [HttpPost("createBasket")]
        public IActionResult AddToBasket(AddToBasketRequest cart)
        {
            var result = _basketService.AddToBasket(cart);

            if (result.Success)
            {
                return Ok(result.Messange);
            }

            return BadRequest(result.Messange);
        }

        [HttpGet("getToCustomerBasket")]
        [ProducesResponseType((int)(HttpStatusCode.NotFound))]
        [ProducesResponseType(typeof(GetToBasketResponse), (int)HttpStatusCode.OK)]
        public IActionResult GetCartList(GetToBasketRequest cart)
        {
            var result = _basketService.GetToCustomerBasket(cart);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Messange);
        }
        [HttpDelete("DeleteAllToBasket")]
        [ProducesResponseType(typeof(DeleteAllToBasketRequest), (int)HttpStatusCode.OK)]

        public IActionResult DeleteCart(DeleteAllToBasketRequest cart)
        {
            var result = _basketService.DeleteAllToBasket(cart);
            if (result.Success)
            {
                return Ok(result.Messange);
            }

            return BadRequest(result.Messange);
        }

    }
}
