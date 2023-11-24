using Project.CORE.Entities;
using Project.CORE.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Entities
{
   public class Order:IEntity
    {
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public State State { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal TotalTax { get; set; }
        public string CargoNumber { get; set; }
        public int OrderPoint { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Order()
        {
            State = State.CreatingOrder;
            CreatedDate = DateTime.UtcNow;
            OrderDate = DateTime.UtcNow;
            OrderNumber = Guid.NewGuid().ToString().Substring(0, Guid.NewGuid().ToString().IndexOf("-")); // 8 Haneli benzersiz Alfa Şifresi Oluşturulacak.

        }
        //Relational Properties
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual List<OrderCampaignDetail> Campaigns { get; set; }

    }
}
