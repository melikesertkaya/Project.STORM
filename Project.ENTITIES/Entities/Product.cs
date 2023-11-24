using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Entities
{
   public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal UnitInPrice { get; set; }
        public int Stock { get; set; }
        public int BasketStock { get; set; }

        public bool IsActive { get; set; }
        public int Point { get; set; }
        public string Description { get; set; }
        public List<string> ImagePath { get; set; }
        public decimal UnitInPriceDiscount { get; set; }
        public Guid? CategoryId { get; set; }
        public int Quantity { get; set; }
       

        //Relational Properties
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual List<ProductCampaignDetail> ProductCampaignDetails { get; set; }


    }
}
