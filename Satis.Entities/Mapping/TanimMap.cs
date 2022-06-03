﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Satis.Entities.Tables;

namespace Satis.Entities.Mapping
{
   public class TanimMap:EntityTypeConfiguration<Tanim>
    {
        public TanimMap()
        {
            this.HasKey(p => p.Id);//Primary Key
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artan
            this.Property(p => p.Turu).HasMaxLength(15);
            this.Property(p => p.Tanimi).HasMaxLength(30);
            this.Property(p => p.Aciklama).HasMaxLength(200);


            this.ToTable("Tanimlar");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Turu).HasColumnName("Turu");
            this.Property(p => p.Tanimi).HasColumnName("Tanimi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
