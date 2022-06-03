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

namespace Satis.BackOffice.Cari
{
    public partial class FrmCariHareket : Form
    {
         CariDAL cariDal = new CariDAL();
         SatisContext context = new SatisContext();
         private string _cariKodu = null;


        public FrmCariHareket(string cariKodu,string cariAdi)
        {
            InitializeComponent();
            _cariKodu = cariKodu;
            lblBaslik.Text = _cariKodu + " - " + cariAdi + " " + "Hareketleri";
        }

        private void FrmCariHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            gridContFisToplam.DataSource = cariDal.CariFisGenelToplam(context, _cariKodu);
            gridContBakiye.DataSource = cariDal.CariGenelToplam(context, _cariKodu);
            gridContCariHareket.DataSource = cariDal.CariFisAyrinti(context, _cariKodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridCariHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
