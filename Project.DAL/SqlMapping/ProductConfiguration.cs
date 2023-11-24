using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.SqlMapping
{
   public class ProductConfiguration:BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x=> x.ImagePath).HasConversion(
        v => JsonConvert.SerializeObject(v),
        v => JsonConvert.DeserializeObject<List<string>>(v));
        }
    }
}
