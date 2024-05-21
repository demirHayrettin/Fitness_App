using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTask.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask.DAL.Mappings
{
    public class BesinMapping : IEntityTypeConfiguration<Besin>
    {
        public void Configure(EntityTypeBuilder<Besin> builder)
        {
            builder.ToTable("Besinler");
            builder.HasKey(b => b.BesinId);

            builder.Property(b => b.Ad).IsRequired().HasMaxLength(100);
            builder.Property(b => b.Kalori).IsRequired();
        }
    }
}
