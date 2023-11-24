using AutoMapper;
using Microsoft.Extensions.Logging;
using Project.BLL.Abstract;
using Project.BLL.DTO.Request;
using Project.BLL.DTO.Response;
using Project.CORE.Aspect.Caching;
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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDataAccess _categoryDataAccess;
        private readonly IMapper _mapper;
        private readonly ILogger<CategoryManager> _logger;
        public CategoryManager(ICategoryDataAccess categoryDataAccess,
            IMapper mapper,
            ILogger<CategoryManager> logger)
        {
            _categoryDataAccess = categoryDataAccess;
            _mapper = mapper;
            _logger = logger;
        }
        public IResult Add(CreateCategoryRequest request)
        {
            if (request == null)
            {
                return new ErrorResult("");
            }
            var category = _mapper.Map<Category>(request);
            _categoryDataAccess.CreateAsync(category);
            return new SuccessResult("");
        }

        public IResult Delete(DeleteCategoryRequest request)
        {
            if (request.Id==Guid.Empty&& request == null)
            {
                return new ErrorResult();
            }
            var deletedCategory = _mapper.Map<Category>(request);
            _categoryDataAccess.Remove(deletedCategory.Id);
            return new SuccessResult("Remove");
        }

        public IDataResult<List<GetAllCategoryQueryResponse>> GetAllCategory()
        {
            var result = _mapper.Map<List<GetAllCategoryQueryResponse>>(_categoryDataAccess.GetAllAsync());
            if (result == null)
            {
                new ErrorDataResult<GetAllCategoryQueryResponse>("");
            }
            return new SuccessDataResult<List<GetAllCategoryQueryResponse>>(result);

        }

        public IDataResult<List<GetCategoryQueryResponse>> GetCategory(Guid category)
        {
            var result = _mapper.Map<List<GetCategoryQueryResponse>>
              (_categoryDataAccess.Where(x => x.Id == category));
            return new SuccessDataResult<List<GetCategoryQueryResponse>>(result);
        }

        public IResult SoftDelete(Guid item)
        {
            throw new NotImplementedException();
        }
       
        public IResult Update(UpdateCategoryRequest request)
        {
            if (request == null && request.Id==Guid.Empty)
            {
                return new ErrorResult("");
            }
            var updatedCategory = _mapper.Map<Category>(request);
            _categoryDataAccess.UpdateAsync(updatedCategory);
            return new SuccessResult("");
        }
    }
}
