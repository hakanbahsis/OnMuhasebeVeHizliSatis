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
    public partial class FrmStokHareket : Form
    {
        private StokHareketDAL stokHareketDal = new StokHareketDAL();
         SatisContext context = new SatisContext();
        private string _stokKodu;
        public FrmStokHareket(string stokKodu,string stokAdi)
        {
            InitializeComponent();
            _stokKodu = stokKodu;

            lblBaslik.Text = _stokKodu + " - "+ stokAdi+" " + "Hareketleri";
        }

        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            
            Guncelle();
        }

        private void Guncelle()
        {
            gridcontStokHareket.DataSource = stokHareketDal.GetAll(context, c => c.StokKodu == _stokKodu);
            gridcontGenelStok.DataSource = stokHareketDal.GetGenelStok(context, _stokKodu);
            gridcontDepoStok.DataSource = stokHareketDal.GetDepoStok(context, _stokKodu);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            
            if (gridStokHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}
