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
    public class FisMap:EntityTypeConfiguration<Fis>
    {
        public FisMap()
        {
            this.HasKey(p => p.Id);//primary key
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//otomatik artan
            this.Property(p => p.FisKodu).HasMaxLength(12);
            this.Property(p => p.FisTuru).HasMaxLength(30);
            this.Property(p => p.CariKodu).HasMaxLength(12);
            this.Property(p => p.CariAdi).HasMaxLength(50);
            this.Property(p => p.BelgeNo).HasMaxLength(20);
            this.Property(p => p.PlasiyerKodu).HasMaxLength(12);
            this.Property(p => p.PlasiyerAdi).HasMaxLength(50);
            this.Property(p => p.IskontoOrani).HasPrecision(5,2);
            this.Property(p => p.IskontoTutar).HasPrecision(12, 2);
            this.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Fisler");//Tablonun Adı
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.FisTuru).HasColumnName("FisTuru");
            this.Property(p => p.CariKodu).HasColumnName("CariKodu");
            this.Property(p => p.CariAdi).HasColumnName("CariAdi");
            this.Property(p => p.BelgeNo).HasColumnName("BelgeNo");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.PlasiyerKodu).HasColumnName("PlasiyerKodu");
            this.Property(p => p.PlasiyerAdi).HasColumnName("PlasiyerAdi");
            this.Property(p => p.IskontoOrani).HasColumnName("IskontoOrani");
            this.Property(p => p.IskontoTutar).HasColumnName("IskontoTutar");
            this.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");

        }
    }
}
