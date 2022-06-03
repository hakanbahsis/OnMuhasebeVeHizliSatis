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
    public partial class FrmKasaSec : Form
    {
         KasaDAL kasaDal = new KasaDAL();
          SatisContext context = new SatisContext();
          public Entities.Tables.Kasa entity=new Entities.Tables.Kasa();
        public FrmKasaSec()
        {
            InitializeComponent();
        }

        private void FrmKasaSec_Load(object sender, EventArgs e)
        {
            gridContKasaSec.DataSource = kasaDal.KasaListele(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            string kasaKodu = gridKasaSec.GetFocusedRowCellValue(colKasaKodu).ToString();
           entity= context.Kasalar.SingleOrDefault(c => c.KasaKodu == kasaKodu);
           this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
