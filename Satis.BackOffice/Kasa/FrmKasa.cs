using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Satis.BackOffice.Cari;
using Satis.Entities.Context;
using Satis.Entities.Data_Access;

namespace Satis.BackOffice.Kasa
{
    public partial class FrmKasa : Form
    {
        KasaDAL kasaDal = new KasaDAL();
        SatisContext context = new SatisContext();
        private string secilen = null;
        public FrmKasa()
        {
            InitializeComponent();
        }

        public void Guncelle()
        {
           gridContKasalar.DataSource= kasaDal.KasaListele(context);
        }
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFiltreIptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmKasaIslem form = new FrmKasaIslem(new Entities.Tables.Kasa());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = layoutKasalar.GetFocusedRowCellValue(colKasaKodu).ToString();
            FrmKasaIslem form = new FrmKasaIslem(kasaDal.GetByFilter(context, c => c.KasaKodu == secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = layoutKasalar.GetFocusedRowCellValue(colKasaKodu).ToString();
                kasaDal.Delete(context, c => c.KasaKodu == secilen);
                kasaDal.Save(context);
                Guncelle();
            }
        }

        private void btnKasaHareket_Click(object sender, EventArgs e)
        {
            secilen = layoutKasalar.GetFocusedRowCellValue(colKasaKodu).ToString();
            string secilenAd = layoutKasalar.GetFocusedRowCellValue(colKasaAdi).ToString();
            FrmKasaHareketleri form = new FrmKasaHareketleri(secilen, secilenAd);
            form.ShowDialog();
        }
    }
}
