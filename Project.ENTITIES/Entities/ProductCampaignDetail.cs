using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Entities
{
   public class ProductCampaignDetail:BaseEntity
    {
        public Guid ProductId { get; set; }
        public Guid CampaignId { get; set; }

        //Relational Properties

        public virtual Product Products { get; set; }
        public virtual Campaign Campaigns { get; set; }
    }
}
