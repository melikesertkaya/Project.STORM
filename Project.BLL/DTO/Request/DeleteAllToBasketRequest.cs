using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTO.Request
{
    public class DeleteAllToBasketRequest:IDto
    {
        public Guid CartId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public int Amount { get; set; }
    }
}
