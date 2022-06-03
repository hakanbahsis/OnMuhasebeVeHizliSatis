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
    public class KasaHareketMap:EntityTypeConfiguration<KasaHareket>
    {
        public KasaHareketMap()
        {
            this.HasKey(p => p.Id);//Primary Key
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artan
            this.Property(p => p.FisKodu).HasMaxLength(12);
            this.Property(p => p.Hareket).HasMaxLength(15);
            this.Property(p => p.KasaKodu).HasMaxLength(12);
            this.Property(p => p.KasaAdi).HasMaxLength(30);
            this.Property(p => p.OdemeTuruKodu).HasMaxLength(12);
            this.Property(p => p.OdemeTuruAdi).HasMaxLength(30);
            this.Property(p => p.CariKodu).HasMaxLength(12);
            this.Property(p => p.CariAdi).HasMaxLength(50);
            this.Property(p => p.Tutar).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("KasaHareketleri");//Tablo Adı
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.Hareket).HasColumnName("Hareket");
            this.Property(p => p.KasaKodu).HasColumnName("KasaKodu");
            this.Property(p => p.KasaAdi).HasColumnName("KasaAdi");
            this.Property(p => p.OdemeTuruKodu).HasColumnName("OdemeTuruKodu");
            this.Property(p => p.OdemeTuruAdi).HasColumnName("OdemeTuruAdi");
            this.Property(p => p.CariKodu).HasColumnName("CariKodu");
            this.Property(p => p.CariAdi).HasColumnName("CariAdi");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.Tutar).HasColumnName("Tutar");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
