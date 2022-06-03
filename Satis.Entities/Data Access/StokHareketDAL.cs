using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Satis.Entities.Context;
using Satis.Entities.Repositories;
using Satis.Entities.Tables;
using Satis.Entities.Validations;

namespace Satis.Entities.Data_Access
{
   public class StokHareketDAL:EntitiyRepositoryBase<SatisContext,StokHareket,StokHareketValidator>
    {
        public object GetGenelStok(SatisContext context, string stokKodu)
        {
            var result = (from c in context.StokHareketleri.Where(c => c.StokKodu == stokKodu)
                group c by new { c.Hareket }
                into g
                select new
                {
                    Bilgi = g.Key.Hareket,
                    KayitSayisi = g.Count(),
                    GenelToplam = g.Sum(c => c.Miktar)
                }).ToList();
            return result;
        }

        public object GetDepoStok(SatisContext context, string stokKodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokKodu),
                c => c.DepoKodu, c => c.DepoKodu, (depolar, stokhareketleri) => new
                {
                    depolar.DepoKodu,
                    depolar.DepoAdi,
                    StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = (stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ??
                                  0) - (stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0),
                }).ToList();
            return result;
        }
        public object DepoStokListele(SatisContext context,string depoKodu)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu), c => c.StokKodu, c => c.StokKodu,
                (Stoklar, StokHareketleri) =>
                    new
                    {
                        
                        Stoklar.StokAdi,
                        Stoklar.Barkod,
                        StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                        StokCikis = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                        MevcutStok = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) -
                            StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0
                    }).ToList();
            return tablo;
        }

        public object DepoIstatistikListele(SatisContext context, string depoKodu)
        {
            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi = "Stok Giriş",
                    KayitSayisi = context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu && c.Hareket=="Stok Giriş").Count(),
                    Tutar = context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu).Sum(c=>c.Miktar)??0
                },
                new GenelToplam
                {
                    Bilgi = "Stok Çıkış",
                    KayitSayisi = context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu && c.Hareket=="Stok Çıkış").Count(),
                    Tutar = context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu).Sum(c=>c.Miktar)??0
                }
            };
            return genelToplamlar;
        }
    }
}
