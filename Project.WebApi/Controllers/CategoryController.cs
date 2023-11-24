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
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getCategorybyid")]
        [ProducesResponseType((int)(HttpStatusCode.NotFound))]
        [ProducesResponseType(typeof(GetCategoryQueryResponse), (int)HttpStatusCode.OK)]
        public IActionResult GetCategoryById(Guid id)
        {
            var result = _categoryService.GetCategory(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Messange);
        }
        [HttpGet("getAllCategory")]
        [ProducesResponseType((int)(HttpStatusCode.NotFound))]
        [ProducesResponseType(typeof(GetAllCategoryQueryResponse), (int)HttpStatusCode.OK)]
        public IActionResult GetCategoryList()
        {
            var result = _categoryService.GetAllCategory();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Messange);
        }
        [HttpPost("createCategory")]
        [ProducesResponseType(typeof(CreateCategoryRequest),(int)HttpStatusCode.Created)]
        public IActionResult CreateCategory(CreateCategoryRequest category)
        {
            var result = _categoryService.Add(category);
            if (result.Success)
            {
                return Ok(result.Messange);
            }
            return BadRequest(result.Messange);
        }
        [HttpPut("updateCategory")]
        [ProducesResponseType(typeof(UpdateCategoryRequest),(int)HttpStatusCode.OK)]
        public IActionResult UpdateCategory(UpdateCategoryRequest category)
        {
            var result = _categoryService.Update(category);
            if (result.Success)
            {
                return Ok(result.Messange);
            }
            return BadRequest(result.Messange);
        }
        [HttpDelete("deleteCategory")]
        [ProducesResponseType(typeof(DeleteCategoryRequest),(int)HttpStatusCode.OK)]
        public IActionResult DeleteCategory(DeleteCategoryRequest category)
        {
            var result = _categoryService.Delete(category);
            if (result.Success)
            {
                return Ok(result.Messange);
            }
            return BadRequest(result.Messange);
        }
    }
}
