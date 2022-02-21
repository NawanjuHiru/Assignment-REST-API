using Assignment_REST_API.Model.REST;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_REST_API.Data.Configurations
{
    public class AmountConfiguration : IEntityTypeConfiguration<Amount>
    {
        public void Configure(EntityTypeBuilder<Amount> builder)
        {
            builder.ToTable("Amount");

            builder.HasKey(x => new { x.SAPCode });

            //builder.HasOne<SAP>(s => s.SAPCode)
            // .WithMany(cl => cl.Amounts)
            // .HasForeignKey(f => f.SAPCode)
            // .OnDelete(DeleteBehavior.Restrict)
            // .IsRequired(true);
        }
    }
}
