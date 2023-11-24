using Project.CORE.Entities;
using Project.CORE.Entities.Concrete;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTO.Request
{
    public class AddToBasketRequest    
    {
        public Guid CustomerId { get; set; }
  
        public List<BasketItemDto> BasketItem { get; set; }
        public decimal TotalPrice
        {
            get => BasketItem.Sum(x => x.Price * x.Quantity);
        }





    }
}
