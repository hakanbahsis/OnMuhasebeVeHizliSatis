using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Satis.Entities.Context;
using Satis.Entities.Data_Access;

namespace Satis.BackOffice.Stok
{
    public partial class FrmStokİslem : Form
    {
        private Entities.Tables.Stok _entity;
        private StokDAL stokDal = new StokDAL();
        private SatisContext context = new SatisContext();
        public bool saved = false;
        public FrmStokİslem(Entities.Tables.Stok entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu");
            txtStokKodu.DataBindings.Add("Text", _entity, "StokKodu");
            txtBarkod.DataBindings.Add("Text", _entity, "Barkod");
            cmbBarkodTuru.DataBindings.Add("Text", _entity, "BarkodTuru");
            txtStokAdi.DataBindings.Add("Text", _entity, "StokAdi");
            btnBirimi.DataBindings.Add("Text", _entity, "Birimi");
            txtUreticiKodu.DataBindings.Add("Text", _entity, "UreticiKodu");
            txtGarantiSuresi.DataBindings.Add("Text", _entity, "GarantiSuresi");

            calcMaxStokMiktarı.DataBindings.Add("Text", _entity, "MaxStokMiktari");
            calcMaxStokMiktarı.DataBindings[0].FormattingEnabled = true;
            calcMaxStokMiktarı.DataBindings[0].FormatString = "N3";

            calcminStokMiktarı.DataBindings.Add("Text", _entity, "MinStokMiktari");
            calcminStokMiktarı.DataBindings[0].FormattingEnabled = true;
            calcminStokMiktarı.DataBindings[0].FormatString = "N3";

            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            btnStokGrubu.DataBindings.Add("Text", _entity, "StokGrubu");
            btnStokAltGrubu.DataBindings.Add("Text", _entity, "StokAltGrubu");
            btnMarka.DataBindings.Add("Text", _entity, "Marka");
            btnModel.DataBindings.Add("Text", _entity, "Modeli");
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1");
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2");
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3");
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4");

            calcAlisKdv.DataBindings.Add("Text", _entity, "AlisKdv");
            calcAlisKdv.DataBindings[0].FormattingEnabled = true;
            calcAlisKdv.DataBindings[0].FormatString = "'%'0";
            calcAlisKdv.DataBindings[0].DataSourceNullValue = "0";

            calcSatisKdv.DataBindings.Add("Text", _entity, "SatisKdv");
            calcSatisKdv.DataBindings[0].FormattingEnabled = true;
            calcSatisKdv.DataBindings[0].FormatString = "'%'0";
            calcSatisKdv.DataBindings[0].DataSourceNullValue = "0";

            calcAlisFiyati1.DataBindings.Add("Text", _entity, "AlisFiyati1");
            calcAlisFiyati1.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati1.DataBindings[0].FormatString = "C2";

            calcAlisFiyati2.DataBindings.Add("Text", _entity, "AlisFiyati2");
            calcAlisFiyati2.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati2.DataBindings[0].FormatString = "C2";

            calcAlisFiyati3.DataBindings.Add("Text", _entity, "AlisFiyati3");
            calcAlisFiyati3.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati3.DataBindings[0].FormatString = "C2";

            calcSatisFiyati1.DataBindings.Add("Text", _entity, "SatisFiyati1");
            calcSatisFiyati1.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati1.DataBindings[0].FormatString = "C2";

            calcSatisFiyati2.DataBindings.Add("Text", _entity, "SatisFiyati2");
            calcSatisFiyati2.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati2.DataBindings[0].FormatString = "C2";

            calcSatisFiyati3.DataBindings.Add("Text", _entity, "SatisFiyati3");
            calcSatisFiyati3.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati3.DataBindings[0].FormatString = "C2";
        }
        private void FrmStokİslem_Load(object sender, EventArgs e)
        {
            toggleDurumu.IsOn = true;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (stokDal.AddOrUpdate(context,_entity))
            {
                stokDal.Save(context);
                this.Close();
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
