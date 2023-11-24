using Project.CORE.DAL.Abstarct;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Abstract
{
    public interface IOrderDetailDataAccess:IEntityRepository<OrderDetail>
    {
    }
}
