using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Satis.Entities.Tables;

namespace Satis.Entities.Mapping
{
    public class DepoMap:EntityTypeConfiguration<Depo>
    {
        public DepoMap()
        {
            this.HasKey(p => p.Id);//Primary Key
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//otomatik Artan
            this.Property(p => p.DepoKodu).HasMaxLength(12);
            this.Property(p => p.DepoAdi).HasMaxLength(30);
            this.Property(p => p.YetkiliKodu).HasMaxLength(12);
            this.Property(p => p.YetkiliAdi).HasMaxLength(50);
            this.Property(p => p.Il).HasMaxLength(20);
            this.Property(p => p.Ilce).HasMaxLength(20);
            this.Property(p => p.Semt).HasMaxLength(30);
            this.Property(p => p.Adres).HasMaxLength(100);
            this.Property(p => p.Telefon).HasMaxLength(11);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Depolar"); //Tablo Adı
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.DepoKodu).HasColumnName("DepoKodu");
            this.Property(p => p.DepoAdi).HasColumnName("DepoAdi");
            this.Property(p => p.YetkiliKodu).HasColumnName("YetkiliKodu");
            this.Property(p => p.YetkiliAdi).HasColumnName("YetkiliAdi");
            this.Property(p => p.Il).HasColumnName("Il");
            this.Property(p => p.Ilce).HasColumnName("Ilce");
            this.Property(p => p.Semt).HasColumnName("Semt");
            this.Property(p => p.Adres).HasColumnName("Adres");
            this.Property(p => p.Telefon).HasColumnName("Telefon");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
