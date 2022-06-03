﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Satis.Entities.Interfaces;

namespace Satis.Entities.Tables
{
    public class StokHareket : IEntity
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string Hareket { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string BarkodTuru { get; set; }
        public string Barkod { get; set; }
        public string Birimi { get; set; }
        public Nullable<decimal> Miktar { get; set; }
        public int Kdv { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<decimal> IndırımOrani { get; set; }
        public Nullable<decimal> IndirimTutari { get; set; }
        public Nullable<decimal> ToplamTutar { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public string SeriNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }

    }
}
