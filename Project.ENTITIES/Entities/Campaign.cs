using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Entities
{
   public class Campaign:BaseEntity
    {
        public string CampanyName { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Description { get; set; }

        //Relational Properties

        public virtual List<OrderCampaignDetail> OrderCampaignDetails { get; set; }
        public virtual List<ProductCampaignDetail> ProductCampaignDetails { get; set; }



    }
}
