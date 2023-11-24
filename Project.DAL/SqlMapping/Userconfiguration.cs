using Microsoft.EntityFrameworkCore;
using Project.CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.SqlMapping
{
    public class Userconfiguration: BaseConfiguration<User>
    {
        public Userconfiguration()
        {

        }
    }
}
