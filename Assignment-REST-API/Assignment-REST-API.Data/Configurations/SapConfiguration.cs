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
    public class SapConfiguration : IEntityTypeConfiguration<SAP>
    {
        public void Configure(EntityTypeBuilder<SAP> builder)
        {
            builder.ToTable("Basic_Data");

            builder.HasKey(x => x.SAPCode);
        }
    }
}
