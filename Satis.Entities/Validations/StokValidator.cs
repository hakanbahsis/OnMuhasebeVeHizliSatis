using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Satis.Entities.Tables;

namespace Satis.Entities.Validations
{
   public class StokValidator:AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(p => p.StokKodu).NotEmpty().WithMessage("Stok Kodu Alanı Boş Geçilemez.");
            RuleFor(p => p.StokAdi).NotEmpty().WithMessage("Stok Adı Alanı Boş Geçilemez.").
                Length(1,50).WithMessage("Stok Adı Alanaı 1 ile 50 Karakter Arasında Olabilir.");
            RuleFor(p => p.Barkod).NotEmpty().WithMessage("Barkod Alanı Boş Geçilemez.");
            RuleFor(p => p.AlisFiyati1).GreaterThan(0).WithMessage("Alış Fiyatı -1 Alanı 0'dan Küçük Olmalıdır.");
            RuleFor(p => p.AlisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı -2 Alanı 0'dan Küçük Olmalıdır.");
            RuleFor(p => p.AlisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı -3 Alanı 0'dan Küçük Olmalıdır.");
            RuleFor(p => p.SatisFiyati1).GreaterThan(0).WithMessage("Satış Fiyatı -1 Alanı 0'dan Küçük Olmalıdır.");
            RuleFor(p => p.SatisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı -2 Alanı 0'dan Küçük Olmalıdır.");
            RuleFor(p => p.SatisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı -3 Alanı 0'dan Küçük Olmalıdır.");


        }
    }
}
