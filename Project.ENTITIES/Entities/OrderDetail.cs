using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Entities
{
  public  class OrderDetail:BaseEntity
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }

        public Guid UserId { get; set; }
        public Guid ShippingId { get; set; }
        public Guid BillingId { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentType { get; set; }
        public int OrderNumber { get; set; }
        public string Email { get; set; }
        public string MobilPhone { get; set; }
      

        //Relational Properties
        public virtual Order Orders { get; set; }
        public virtual Product Products { get; set; }
    }
}
