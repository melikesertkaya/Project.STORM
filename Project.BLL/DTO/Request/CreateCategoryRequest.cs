using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTO.Request
{
    public class CreateCategoryRequest:IDto
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string CategoryType { get; set; }
    }
}
