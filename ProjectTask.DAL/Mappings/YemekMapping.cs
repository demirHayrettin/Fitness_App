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
    public class YemekMapping : IEntityTypeConfiguration<Yemek>
    {
        public void Configure(EntityTypeBuilder<Yemek> builder)
        {
            builder.ToTable("Yemekler");
            builder.HasKey(y => y.YemekId);

            builder.Property(y => y.Ad).IsRequired().HasMaxLength(100);
            builder.HasOne(y => y.Kategori).WithMany().HasForeignKey(y => y.YemekId);
            builder.Property(y => y.Tarif).HasColumnType("nvarchar(max)");
            builder.Property(y => y.ResimYolu).HasMaxLength(255);
            builder.HasOne(y => y.Porsiyon).WithMany().HasForeignKey(y => y.YemekId);
        }
    }
}
