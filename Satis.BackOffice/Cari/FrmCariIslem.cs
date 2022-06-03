using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Satis.BackOffice.Tanım;
using Satis.Entities.Context;
using Satis.Entities.Data_Access;

namespace Satis.BackOffice.Cari
{
    public partial class FrmCariIslem : Form
    {
        private Entities.Tables.Cari _entity;
        private CariDAL cariDal = new CariDAL();
        private SatisContext context = new SatisContext();
        public bool saved = false;
        public FrmCariIslem(Entities.Tables.Cari entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu");
            txtCariKodu.DataBindings.Add("Text", _entity, "CariKodu");
            
            txtCariAdi.DataBindings.Add("Text", _entity, "CariAdi");

            cmbCariTuru.DataBindings.Add("Text", _entity, "CariTuru");
            txtYetkiliKisi.DataBindings.Add("Text", _entity, "YetkiliKisi");
            txtFaturaUnvani.DataBindings.Add("Text", _entity, "FaturaUnvani");
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi");
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            txtCepTelefonu.DataBindings.Add("Text", _entity, "CepTelefonu");
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtFax.DataBindings.Add("Text", _entity, "Fax");
            txtEMail.DataBindings.Add("Text", _entity, "EMail");
            txtWeb.DataBindings.Add("Text", _entity, "Web");
            txtIl.DataBindings.Add("Text", _entity, "Il");
            txtIlce.DataBindings.Add("Text", _entity, "Ilce");
            txtAdres.DataBindings.Add("Text", _entity, "Adres");
            btnCariGrubu.DataBindings.Add("Text", _entity, "CariGrubu");
            btnCariAltGrubu.DataBindings.Add("Text", _entity, "CariAltGrubu");
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKodu1");
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKodu2");
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKodu3");
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKodu4");
            calcAlisOzelFiyati.DataBindings.Add("Text", _entity, "AlisOzelFiyati");
            calcSatisOzelFiyati.DataBindings.Add("Text", _entity, "SatisOzelFiyati");

            calcIskontoOrani.DataBindings.Add("Text", _entity, "IskontoOrani");
            calcIskontoOrani.DataBindings[0].FormattingEnabled = true;
            calcIskontoOrani.DataBindings[0].FormatString = "'%'0";
            calcIskontoOrani.DataBindings[0].DataSourceNullValue = "0";

            calcRiskLimiti.DataBindings.Add("Text", _entity, "RiskLimiti");
            calcRiskLimiti.DataBindings[0].FormattingEnabled = true;
            calcRiskLimiti.DataBindings[0].FormatString = "C2";
            calcRiskLimiti.DataBindings[0].DataSourceNullValue = "0";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCariIslem_Load(object sender, EventArgs e)
        {
            toggleDurumu.IsOn = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cariDal.AddOrUpdate(context,_entity))
            {
                cariDal.Save(context);
                saved = true;
                this.Close();
            }
        }

        private void btnCariGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.CariGrubu);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnCariGrubu.Text=form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnCariGrubu.Text = null;
                    break;
            }
        }

        private void btnOzelKod1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.CariOzelKod1);
                    form.ShowDialog();
                    if (form.secildi)
                    {btnOzelKod1.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnOzelKod1.Text = null;
                    break;
            }
        }

        private void groupGruplar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
