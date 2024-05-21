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
    internal class KullaniciMapping : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.ToTable("Kullanicilar");
            builder.HasKey(k => k.Id);

            builder.Property(k => k.Ad).IsRequired().HasMaxLength(50);
            builder.Property(k => k.Soyad).IsRequired().HasMaxLength(50);
            builder.Property(k => k.DogumTarihi).IsRequired();
            builder.Property(k => k.Cinsiyet).IsRequired().HasMaxLength(10);
            builder.Property(k => k.Boy).IsRequired();
            builder.Property(k => k.Kilo).IsRequired();
            builder.Property(k => k.Email).IsRequired().HasMaxLength(100);
            builder.Property(k => k.Sifre).IsRequired().HasMaxLength(100);
        }
    }
}
