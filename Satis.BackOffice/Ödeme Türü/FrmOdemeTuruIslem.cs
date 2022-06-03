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
    public partial class FrmOdemeTuruIslem : DevExpress.XtraEditors.XtraForm
    {
        private SatisContext context = new SatisContext();
        private OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();
        private OdemeTuru _entity;
        public FrmOdemeTuruIslem(OdemeTuru entity)
        {
            InitializeComponent();
            _entity = entity;
            txtOdemeKodu.DataBindings.Add("Text", _entity, "OdemeTuruKodu");
            txtOdemeAdi.DataBindings.Add("Text",_entity,"OdemeTuruAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void FrmOdemeTuruIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (odemeTuruDal.AddOrUpdate(context,_entity))
            {
                odemeTuruDal.Save(context);
                this.Close();
            }
        }
    }
}