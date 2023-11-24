using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Entities
{
   public class OrderCampaignDetail:BaseEntity
    {
        public Guid OrderId { get; set; }
        public Guid CampaignId { get; set; }

        //Relational Properties
        public virtual Order Orders { get; set; }
        public virtual Campaign Campaigns { get; set; }
    }
}
