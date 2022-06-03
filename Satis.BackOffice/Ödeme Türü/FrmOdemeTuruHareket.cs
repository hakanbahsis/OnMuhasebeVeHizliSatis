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

namespace Satis.BackOffice.Ödeme_Türü
{
    public partial class FrmOdemeTuruHareket : DevExpress.XtraEditors.XtraForm
    {
        private SatisContext context = new SatisContext();
        private OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();
        private string _odemeTuruKodu;
        public FrmOdemeTuruHareket(string odemeTuruKodu,string odemeTuruAdi)
        {
            InitializeComponent();
            _odemeTuruKodu = odemeTuruKodu;
            lblBaslik.Text = odemeTuruKodu + " - " + odemeTuruAdi+" Hareketleri";
        }

        private void FrmOdemeTuruHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            gridControlKasaHareket.DataSource = odemeTuruDal.GetAll(context, c => c.OdemeTuruKodu == _odemeTuruKodu);
            gridControlKasaBakiye.DataSource = odemeTuruDal.KasaToplamListele(context, _odemeTuruKodu);
            gridContGenelToplam.DataSource = odemeTuruDal.GenelToplamListele(context, _odemeTuruKodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridViewKasaHareket.OptionsView.ShowAutoFilterRow = false ? true : false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}