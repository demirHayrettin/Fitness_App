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
    public class YemekPlaniMapping : IEntityTypeConfiguration<YemekPlani>
    {
        public void Configure(EntityTypeBuilder<YemekPlani> builder)
        {
            builder.ToTable("YemekPlanlari");
            builder.HasKey(yp => yp.YemekPlaniId);

            builder.HasOne(yp => yp.Kullanici)
                   .WithMany()
                   .HasForeignKey(yp => yp.KullaniciId);

            builder.Property(yp => yp.Tarih).IsRequired();
        }
    }
}
