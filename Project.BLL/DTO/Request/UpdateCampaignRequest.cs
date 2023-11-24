using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTO.Request
{
    public class UpdateCampaignRequest : IDto
    {
        public Guid Id { get; set; }
        public string CampanyName { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Description { get; set; }

    }
}
