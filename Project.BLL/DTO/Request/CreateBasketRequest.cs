using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTO.Request
{
   public class CreateBasketRequest
    {
        public Guid CustomerId { get; set; }
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string CampaignName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Decimal { get; set; }
        public int Stock { get; set; }
    }
}
