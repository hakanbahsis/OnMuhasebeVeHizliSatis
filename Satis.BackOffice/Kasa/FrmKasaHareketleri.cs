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

namespace Satis.BackOffice.Kasa
{
    public partial class FrmKasaHareketleri : Form
    {
        KasaDAL kasaDal = new KasaDAL();
        SatisContext context = new SatisContext();
        private string _kasaKodu;
        public FrmKasaHareketleri(string kasaKodu,string kasaAdi)
        {
            InitializeComponent();
            _kasaKodu = kasaKodu;
            lblBaslik.Text = kasaKodu + " - " + kasaAdi + " Hareketleri";
        }

        public void Guncelle()
        {
            gridContKasaHareket.DataSource = kasaDal.GetAll(context,c=>c.KasaKodu==_kasaKodu);
            gridContOdemeTuruToplam.DataSource = kasaDal.OdemeTuruToplamListele(context, _kasaKodu);
            gridContGenelToplam.DataSource = kasaDal.OdemeTuruToplamListele(context, _kasaKodu);
        }
        private void FrmKasaHareketleri_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridKasaHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
