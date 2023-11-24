using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTO.Request
{
   public class UpdateProductRequest:IDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal UnitInPrice { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public int Point { get; set; }
        public string Description { get; set; }
        public List<string> ImagePath { get; set; }
        public decimal UnitInPriceDiscount { get; set; }
        public Guid? CategoryId { get; set; }
        public int Quantity { get; set; }
    }
}
