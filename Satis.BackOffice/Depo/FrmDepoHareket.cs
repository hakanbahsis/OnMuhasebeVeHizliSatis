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
    public partial class FrmDepoHareket : DevExpress.XtraEditors.XtraForm
    {
        SatisContext context = new SatisContext();
        private StokHareketDAL stokHareketDal = new StokHareketDAL();
        private string _depoKodu;

        public FrmDepoHareket(string depoKodu, string depoAdi)
        {
            InitializeComponent();
            _depoKodu = depoKodu;
            lblBaslik.Text = depoKodu + " - " + depoAdi + " Hareketleri";
        }

        private void FrmDepoHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            gridControlHareket.DataSource = stokHareketDal.GetAll(context, c => c.DepoKodu == _depoKodu);
            gridControlDepoStok.DataSource = stokHareketDal.DepoStokListele(context, _depoKodu);
            gridControlIstatistik.DataSource = stokHareketDal.DepoIstatistikListele(context, _depoKodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridViewHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridViewHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridViewHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}