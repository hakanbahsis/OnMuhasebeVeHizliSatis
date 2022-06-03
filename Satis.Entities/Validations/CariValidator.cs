using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Satis.Entities.Tables;

namespace Satis.Entities.Validations
{
   public class CariValidator:AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("Cari Kodu Alanı Boş Geçilemez.");
            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("Cari Adı Alanı Boş Geçilemez.");
            RuleFor(p => p.YetkiliKisi).NotEmpty().WithMessage("Yetkili Kişi Alanı Boş Geçilemez.");
            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("Fatura Unvanı Alanı Boş Geçilemez.");
            RuleFor(p => p.EMail).EmailAddress().WithMessage("Girdiğiniz E-Mail Adresi Geçersiz");
            RuleFor(p => p.IskontoOrani).GreaterThanOrEqualTo(0).WithMessage("İskonto Oranı Alanı 0'dan Küçük Olamaz.");
            RuleFor(p => p.RiskLimiti).GreaterThanOrEqualTo(0).WithMessage("Risk Limiti Alanı 0'dan Küçük Olamaz.");
            RuleFor(p => p.CepTelefonu).NotEmpty().WithMessage("Cep Telefonu Alanı Boş Geçilemez.");

        }
    }
}
