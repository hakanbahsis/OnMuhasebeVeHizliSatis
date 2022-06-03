using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Satis.Entities.Context;
using Satis.Entities.Data_Access;

namespace Satis.BackOffice.Stok
{
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {
        private SatisContext context = new SatisContext();
        private StokDAL stokDal = new StokDAL();
        private string secilen;
        public FrmStok()
        {
            InitializeComponent();
        }
        private void FrmStok_Load(object sender, EventArgs e)
        {
            GetAll();
        }
        public void GetAll()
        {
            gridControl1.DataSource= stokDal.GetAllJoin(context);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnFiltreIptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }
        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }
        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll(); 
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                 secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                stokDal.Delete(context,c=>c.StokKodu==secilen);
                stokDal.Save(context);
                GetAll();
            }
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokİslem form = new FrmStokİslem(new Entities.Tables.Stok());
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
             secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            FrmStokİslem form = new FrmStokİslem(stokDal.GetByFilter(context,c=>c.StokKodu==secilen));
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
             secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok stokEntity = new Entities.Tables.Stok();
            stokEntity = stokDal.GetByFilter(context, c => c.StokKodu == secilen);
            stokEntity.Id = -1;
            stokEntity.StokKodu = null;
            FrmStokİslem form = new FrmStokİslem(stokEntity);
            form.ShowDialog();
            context = new SatisContext();
            if (form.saved)
            {
                GetAll();
            }
        }

        private void btnStokHareket_Click(object sender, EventArgs e)
        {
             secilen= gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
             string secilenAd= gridView1.GetFocusedRowCellValue(colStokAdi).ToString();
            FrmStokHareket form = new FrmStokHareket(secilen,secilenAd);
            form.ShowDialog();
        }
    }
}