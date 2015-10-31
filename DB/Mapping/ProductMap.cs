using MVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Producto>
    {
        public ProductMap()
        {
            this.ToTable("Producto");

            this.HasKey(o => o.Id);

            this.Property(o => o.Id).HasColumnName("Id");

            this.Property(o => o.Code).HasColumnName("Code").HasMaxLength(250);

            this.Property(o => o.Name).HasColumnName("Name").HasMaxLength(250);
        }
    }
}
