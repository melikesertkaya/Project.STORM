using Project.CORE.DAL.Concrete;
using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Concrete
{
    public class CategoryDataAccess:EntityRepository<Category,MyContext>,ICategoryDataAccess
    {
    }
}
