using Microsoft.AspNetCore.Http;
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
    public class OrderController : ControllerBase
    {
        IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("getAllOrder")]
        [ProducesResponseType((int)(HttpStatusCode.NotFound))]
        [ProducesResponseType(typeof(GetAllOrderQueryResponse), (int)HttpStatusCode.OK)]
        public IActionResult GetList()
        {
            var result = _orderService.GetAllOrder();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Messange);
        }



        [HttpGet("getbyid")]
        [ProducesResponseType((int)(HttpStatusCode.NotFound))]
        [ProducesResponseType(typeof(GetByOrderIdQueryResponse), (int)HttpStatusCode.OK)]
        public IActionResult GetById(Guid id)
        {
            var result = _orderService.GetOrder(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Messange);
        }

        [HttpPost("createorder")]
        [ProducesResponseType(typeof(CreateOrderRequest), (int)HttpStatusCode.Created)]
        public IActionResult CreateOrder(CreateOrderRequest order)
        {
            var result = _orderService.CreateOrder(order);

            if (result.Success)
            {
                return Ok(result.Messange);
            }

            return BadRequest(result.Messange);
        }

        [HttpPost("updateOrder")]
        [ProducesResponseType(typeof(UpdateOrderRequest), (int)HttpStatusCode.OK)]

        public IActionResult UpdateOrder(UpdateOrderRequest order)
        {
            var result = _orderService.UpdateOrder(order);
            if (result.Success)
            {
                return Ok(result.Messange);
            }

            return BadRequest(result.Messange);
        }

        [HttpDelete("deleteOrder")]
        [ProducesResponseType(typeof(DeleteOrderRequest), (int)HttpStatusCode.OK)]
        public IActionResult DeleteOrder(DeleteOrderRequest order)
        {
            var result = _orderService.DeleteOrder(order);
            if (result.Success)
            {
                return Ok(result.Messange);
            }
            return BadRequest(result.Messange);
        }

    }
}

