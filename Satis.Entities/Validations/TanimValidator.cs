using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Satis.Entities.Tables;

namespace Satis.Entities.Validations
{
   public class TanimValidator:AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(p => p.Turu).NotEmpty().WithMessage("Tanım Türü Alanı Boş Geçilemez.");
            RuleFor(p => p.Tanimi).NotEmpty().WithMessage("Tanımı Alanı Boş Geçilemez.");
            
        }
    }
}
