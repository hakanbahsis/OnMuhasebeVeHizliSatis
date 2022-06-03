using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Satis.Entities.Context;
using Satis.Entities.Data_Access;

namespace Satis.BackOffice.Depo
{
    public partial class FrmDepoSec : DevExpress.XtraEditors.XtraForm
    {
        private SatisContext context = new SatisContext();
        private DepoDAL depoDal = new DepoDAL();
        public Entities.Tables.Depo entity = new Entities.Tables.Depo();
        private string _stokKodu;
        public FrmDepoSec(string stokKodu)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
            }

        private void FrmDepoSec_Load(object sender, EventArgs e)
        {
            gridControlDepolar.DataSource = depoDal.DepoBazindaStokListele(context, _stokKodu);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
             string depoKodu = gridViewDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
            entity = context.Depolar.SingleOrDefault(c => c.DepoKodu == depoKodu);
            this.Close();
        }
    }
}