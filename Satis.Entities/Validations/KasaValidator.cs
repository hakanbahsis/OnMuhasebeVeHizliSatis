using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Satis.Entities.Tables;

namespace Satis.Entities.Validations
{
   public class KasaValidator:AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(p => p.KasaKodu).NotEmpty().WithMessage("Kasa Kodu Alanı Boş Geçilemez.");
            RuleFor(p => p.KasaAdi).NotEmpty().WithMessage("KAsa Adı Alanı Boş Geçilemez.");
        }
    }
}
