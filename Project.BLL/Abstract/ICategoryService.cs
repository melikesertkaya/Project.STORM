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
    public interface ICategoryService
    {
        IResult Add(CreateCategoryRequest request);
        IResult Delete(DeleteCategoryRequest request);
        IResult SoftDelete(Guid item);
        IResult Update(UpdateCategoryRequest request);
        IDataResult<List<GetAllCategoryQueryResponse>> GetAllCategory();
        IDataResult<List<GetCategoryQueryResponse>> GetCategory(Guid category);
    }
}
