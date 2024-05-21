using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectTask.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask.DAL.Mappings
{
    public class PorsiyonMapping : IEntityTypeConfiguration<Porsiyon>
    {
        public void Configure(EntityTypeBuilder<Porsiyon> builder)
        {
            builder.ToTable("Porsiyonlar");
            builder.HasKey(p => p.PorsiyonId);

            builder.Property(p => p.Ad).IsRequired().HasMaxLength(50);
        }
    }
}
