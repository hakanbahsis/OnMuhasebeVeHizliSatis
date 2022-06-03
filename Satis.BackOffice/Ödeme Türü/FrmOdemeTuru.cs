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
using Satis.Entities.Tables;

namespace Satis.BackOffice.Ödeme_Türü
{
    public partial class FrmOdemeTuru : DevExpress.XtraEditors.XtraForm
    {
         SatisContext context = new SatisContext();
         OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();
         public FrmOdemeTuru()
        {
            InitializeComponent();
        }

        private void FrmOdemeTuru_Load(object sender, EventArgs e)
        {
            Listtele();
        }

        void Listtele()
        {
            gridControlOdemeTurleri.DataSource = odemeTuruDal.OdemeTuruListele(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listtele();
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridViewOdemeTurleri.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
                odemeTuruDal.Delete(context, c => c.OdemeTuruKodu == secilen);
                odemeTuruDal.Save(context);
                Listtele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmOdemeTuruIslem form = new FrmOdemeTuruIslem(new OdemeTuru());
            form.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridViewOdemeTurleri.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
            FrmOdemeTuruIslem form = new FrmOdemeTuruIslem(odemeTuruDal.GetByFilter(context,c=>c.OdemeTuruKodu==secilen));
            form.ShowDialog();
        }
    }

    
}