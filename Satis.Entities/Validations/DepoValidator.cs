using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Satis.Entities.Tables;

namespace Satis.Entities.Validations
{
    public class DepoValidator:AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(p => p.DepoKodu).NotEmpty().WithMessage("Depo Kodu Alanı Boş Geçilemez.");
            RuleFor(p => p.DepoAdi).NotEmpty().WithMessage("Depo Adı Alanı Boş Geçilemez.");
            
        }
    }
}
