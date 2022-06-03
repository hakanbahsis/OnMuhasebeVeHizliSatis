﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Satis.Entities.Interfaces;

namespace Satis.Entities.Tables
{
    public class Fis : IEntity
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string FisTuru { get; set; }
        
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string BelgeNo { get; set; }
        public DateTime Tarih { get; set; }
        public string PlasiyerKodu { get; set; }
        public string PlasiyerAdi { get; set; }
        public Nullable<decimal> IskontoOrani { get; set; }
        public Nullable<decimal> IskontoTutar { get; set; }
        public Nullable<decimal> ToplamTutar { get; set; }
        public string Aciklama { get; set; }


    }
}
