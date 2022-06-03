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

namespace Satis.BackOffice.Fiş
{
    public partial class FrmFis : DevExpress.XtraEditors.XtraForm
    {
        private SatisContext context = new SatisContext();
        FisDAL fisDal = new FisDAL();
        private KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        private StokHareketDAL stokHareketDal = new StokHareketDAL();

        public FrmFis()
        {
            InitializeComponent();
        }

        private void FrmFis_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            gridControlFisler.DataSource=fisDal.GetAll(context);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridViewFisler.GetFocusedRowCellValue(colFisKodu).ToString();
                fisDal.Delete(context, c => c.FisKodu == secilen);
                kasaHareketDal.Delete(context,c=>c.FisKodu==secilen);
                stokHareketDal.Delete(context,c=>c.FisKodu==secilen);
                fisDal.Save(context);
                Listele();
            }
        }
    }
}