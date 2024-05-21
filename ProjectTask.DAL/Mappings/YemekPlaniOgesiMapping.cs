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
    public class YemekPlaniOgesiMapping : IEntityTypeConfiguration<YemekPlaniOgesi>
    {
        public void Configure(EntityTypeBuilder<YemekPlaniOgesi> builder)
        {
            builder.ToTable("YemekPlaniOgesi");
            builder.HasKey(ypo => ypo.YemekPlaniOgesiId);

            builder.HasOne(ypo => ypo.Yemek)
                   .WithMany()
                   .HasForeignKey(ypo => ypo.YemekId);

            builder.HasOne(ypo => ypo.Ogun)
                   .WithMany()
                   .HasForeignKey(ypo => ypo.OgunId);

            builder.Property(ypo => ypo.Saat).IsRequired();
        }
    }
}
