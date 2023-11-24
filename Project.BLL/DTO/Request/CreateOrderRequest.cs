using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTO.Request
{
    public class CreateOrderRequest : IDto
    {
        public Guid ProductId { get; set; }
        public Guid? CampaignId { get; set; }
        public Guid ShippingId { get; set; }
        public Guid BillingId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? TotalTax { get; set; }
        public int? OrderPoint { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public int Amount { get; set; }
        public decimal TotalAmount { get; set; }
        public Guid UserId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string MobilePhone { get; set; }
    }
}
