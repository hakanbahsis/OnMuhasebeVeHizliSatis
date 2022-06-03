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
using Satis.BackOffice.Stok;
using Satis.Entities.Context;
using Satis.Entities.Data_Access;

namespace Satis.BackOffice.Cari
{
    public partial class FrmCari : Form
    {
         SatisContext context = new SatisContext();
          CariDAL cariDal = new CariDAL();
        private  string secilen=null;
        public FrmCari()
        {
            InitializeComponent();
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void FrmCari_Load(object sender, EventArgs e)
        {
            GetAll();
        }
        public void GetAll()
        {
            gridControl1.DataSource = cariDal.GetCariler(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               string secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
                cariDal.Delete(context, c => c.CariKodu == secilen);
                cariDal.Save(context);
                GetAll();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmCariIslem form = new FrmCariIslem(new Entities.Tables.Cari());
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
            
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            FrmCariIslem form = new FrmCariIslem(cariDal.GetByFilter(context, c => c.CariKodu == secilen));
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }

        private void btnCariHareket_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            string secilenAd = gridView1.GetFocusedRowCellValue(colCariAdi).ToString();
            FrmCariHareket form = new FrmCariHareket(secilen, secilenAd);
            form.ShowDialog();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount==0)
            {
                MessageBox.Show("Kopyalama Yapabilmek İçin Bir Kayıt Seçmelisiniz.");
                return;
            }
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            Entities.Tables.Cari cariEntity = new Entities.Tables.Cari();
            cariEntity = cariDal.GetByFilter(context, c => c.CariKodu == secilen);
            cariEntity.Id = -1;
            cariEntity.CariKodu = null;
            FrmCariIslem form = new FrmCariIslem(cariEntity);
            form.ShowDialog();
            context=new SatisContext();
            if (form.saved)
            {
                GetAll();
            }
        }
    }
}
