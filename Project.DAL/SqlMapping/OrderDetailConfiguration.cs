using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.SqlMapping
{
   public class OrderDetailConfiguration:BaseConfiguration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);//base'i oldugu gibi bırakıyoruz ki o ozelliklerini de alsın
            builder.Ignore(x => x.Id);//Order detail tablosunun ID'sını ignore edip veritabanına gondermiyoruz.
            builder.HasKey(x => new
            {
                x.ProductId,
                x.OrderId
            });
        }
    }
    }

