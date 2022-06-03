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
    public class KasaHareketDAL:EntitiyRepositoryBase<SatisContext,KasaHareket,KasaHareketValidator>
    {
    }
}
