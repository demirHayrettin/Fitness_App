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
    public class YemekKategoriMapping : IEntityTypeConfiguration<YemekKategori>
    {
        public void Configure(EntityTypeBuilder<YemekKategori> builder)
        {
            builder.ToTable("Yemek Kategorileri");
            builder.HasKey(yk => yk.YemekKategoriId);

            builder.Property(yk => yk.Ad).IsRequired().HasMaxLength(50);
        }
    }
}
