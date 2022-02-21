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
    public class SiteConfiguration : IEntityTypeConfiguration<Site>
    {
        public void Configure(EntityTypeBuilder<Site> builder)
        {
            builder.ToTable("Site");

            builder.HasKey(x => x.SiteId);

            //builder.HasOne<SAP>(s => s.SAPCode)
            // .WithMany(cl => cl.Sites)
            // .HasForeignKey(f => f.SAPCode)
            // .OnDelete(DeleteBehavior.Restrict)
            // .IsRequired(true);
        }

       
    }
}
