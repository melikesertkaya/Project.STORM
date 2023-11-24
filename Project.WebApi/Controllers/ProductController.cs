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
    public class ProductController : ControllerBase
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getAllProduct")]
        [ProducesResponseType((int)(HttpStatusCode.NotFound))]
        [ProducesResponseType(typeof(GetAllProductQueryResponse), (int)HttpStatusCode.OK)]
        public IActionResult GetAllProducts()
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Messange);
        }
        [HttpGet("getbyid")]
        [ProducesResponseType((int)(HttpStatusCode.NotFound))]
        [ProducesResponseType(typeof(ProductGetByIdQueryResponse), (int)HttpStatusCode.OK)]
        public IActionResult GetProductById(Guid id)
        {
            var result = _productService.GetProductID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Messange);
        }

        [HttpPost("createProduct")]
        [ProducesResponseType(typeof(CreateProductRequest), (int)HttpStatusCode.Created)]
        public IActionResult CreateProduct(CreateProductRequest product)
        {
             
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result.Messange);
            }

            return BadRequest(result.Messange);
        }
        [HttpPost("deleteProduct")]
        [ProducesResponseType(typeof(DeleteProductRequest), (int)HttpStatusCode.OK)]
        public IActionResult DeleteProduct(DeleteProductRequest product)
        {

            var result = _productService.Delete(product);
            if (result.Success)
            {
                return Ok(result.Messange);
            }

            return BadRequest(result.Messange);
        }
        [HttpPost("updateProduct")]
        [ProducesResponseType(typeof(UpdateProductRequest), (int)HttpStatusCode.OK)]
        public IActionResult UpdateProduct(UpdateProductRequest product)
        {

            var result = _productService.Update(product);
            if (result.Success)
            {
                return Ok(result.Messange);
            }

            return BadRequest(result.Messange);
        }

    }
}
